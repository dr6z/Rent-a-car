using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace rentcar
{
    public partial class FormReservations : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public FormReservations()
        {
            InitializeComponent();
        }

        private void FormReservations_Load(object sender, EventArgs e)
        {
            LoadReservations();
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Ime_Prezime");
            cmbFilter.Items.Add("Ime");
            cmbFilter.Items.Add("Prezime");
            cmbFilter.Items.Add("Email");
            cmbFilter.Items.Add("Marka");
            cmbFilter.Items.Add("Model");
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadReservations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            k.Ime AS [Ime],
                            k.Prezime AS [Prezime],
                            k.Email AS [Email],
                            n.NajamID,
                            n.DatumNajma AS [Datum najma],
                            n.DatumVracanja AS [Datum vraćanja],
                            n.UkupnaCijena AS [Ukupna cijena (KM)],
                            a.Marka AS [Marka],
                            a.Model AS [Model],
                            a.ZapreminaMotora AS [Zapremina (ccm)],
                            a.Tip AS [Tip vozila]
                        FROM Automobili a
                        JOIN Najam n ON a.AutomobilID = n.AutomobilID
                        JOIN Korisnici k ON n.KorisnikID = k.KorisnikID
                        ORDER BY n.DatumNajma DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReservations.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja podataka: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Unesite pojam za pretragu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = dgvReservations.DataSource as DataTable;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nema dostupnih podataka!");
                    return;
                }

                if (cmbFilter.SelectedItem != null && cmbFilter.SelectedItem.ToString() == "Ime_Prezime")
                {
                    var filtered = dt.AsEnumerable().Where(row =>
                        (row["Ime"]?.ToString().ToLower().Contains(searchValue) == true) ||
                        (row["Prezime"]?.ToString().ToLower().Contains(searchValue) == true) ||
                        ((row["Ime"]?.ToString() + " " + row["Prezime"]?.ToString()).ToLower().Contains(searchValue))
                    );

                    dgvReservations.DataSource = filtered.Any() ? filtered.CopyToDataTable() : null;
                    if (!filtered.Any())
                        MessageBox.Show("Nema rezultata za uneseni pojam.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string column = cmbFilter.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(column))
                    {
                        MessageBox.Show("Odaberite kolonu za pretragu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var filtered = dt.AsEnumerable().Where(row =>
                        row[column]?.ToString().ToLower().Contains(searchValue) == true);

                    dgvReservations.DataSource = filtered.Any() ? filtered.CopyToDataTable() : null;
                    if (!filtered.Any())
                        MessageBox.Show("Nema rezultata za uneseni pojam.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom pretrage: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadReservations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite rezervaciju za brisanje!");
                return;
            }

            int najamId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["NajamID"].Value);

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati ovu rezervaciju?",
                                                  "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Najam WHERE NajamID = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", najamId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Rezervacija je uspješno obrisana!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV fajlovi|*.csv",
                FileName = "Rezervacije.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = dgvReservations.DataSource as DataTable;
                    if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nema podataka za izvoz!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    StringBuilder sb = new StringBuilder();

                    foreach (DataColumn col in dt.Columns)
                        sb.Append(col.ColumnName + ",");
                    sb.AppendLine();

                    foreach (DataRow row in dt.Rows)
                        sb.AppendLine(string.Join(",", row.ItemArray));

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Podaci su uspješno eksportovani u CSV fajl!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom izvoza: " + ex.Message);
                }
            }
        }

        // 🔍 Filtriranje po datumu najma i cijeni
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            k.Ime AS [Ime],
                            k.Prezime AS [Prezime],
                            k.Email AS [Email],
                            n.NajamID,
                            n.DatumNajma AS [Datum najma],
                            n.DatumVracanja AS [Datum vraćanja],
                            n.UkupnaCijena AS [Ukupna cijena (KM)],
                            a.Marka AS [Marka],
                            a.Model AS [Model],
                            a.ZapreminaMotora AS [Zapremina (ccm)],
                            a.Tip AS [Tip vozila]
                        FROM Automobili a
                        JOIN Najam n ON a.AutomobilID = n.AutomobilID
                        JOIN Korisnici k ON n.KorisnikID = k.KorisnikID
                        WHERE 1=1";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    // 📅 Filtriranje samo po datumu najma (od–do)
                    if (dtpOdNajma.Value.Date <= dtpDoNajma.Value.Date)
                    {
                        query += " AND n.DatumNajma BETWEEN @OdNajma AND @DoNajma";
                        cmd.Parameters.AddWithValue("@OdNajma", dtpOdNajma.Value.Date);
                        cmd.Parameters.AddWithValue("@DoNajma", dtpDoNajma.Value.Date);
                    }

                    // 💰 Filtriranje po cijeni (opcionalno)
                    if (decimal.TryParse(txtMinCijena.Text, out decimal minCijena))
                    {
                        query += " AND n.UkupnaCijena >= @MinCijena";
                        cmd.Parameters.AddWithValue("@MinCijena", minCijena);
                    }

                    if (decimal.TryParse(txtMaxCijena.Text, out decimal maxCijena))
                    {
                        query += " AND n.UkupnaCijena <= @MaxCijena";
                        cmd.Parameters.AddWithValue("@MaxCijena", maxCijena);
                    }

                    query += " ORDER BY n.DatumNajma DESC";
                    cmd.CommandText = query;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReservations.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Nema rezultata za zadate filtere.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom filtriranja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
