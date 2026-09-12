using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace rentcar
{
    public partial class FormAdmin : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;
        private int selectedCarId = -1;
        private string selectedImageFileName = "";

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadCars();
            dgvCars.CellClick += dgvCars_CellClick;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            FormAddLocation form = new FormAddLocation();
            form.ShowDialog();
        }


        private void LoadCars()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AutomobilID AS AutomobilID, Marka AS Brand, Model, ZapreminaMotora, " +
                               "CijenaPoDanu AS CijenaPoDanu, Godište AS Godište, Tip, Gorivo, Dostupno AS Dostupno, ImagePath AS Putanjaslike " +
                               "FROM Automobili WHERE Obrisan = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCars.DataSource = dt;
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];
                selectedCarId = Convert.ToInt32(row.Cells["AutomobilID"].Value);
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtMotor.Text = row.Cells["ZapreminaMotora"].Value.ToString();
                txtYear.Text = row.Cells["Godište"].Value.ToString();
                txtType.Text = row.Cells["Tip"].Value.ToString();
                txtGorivo.Text = row.Cells["Gorivo"].Value.ToString();
                txtPricePerDey.Text = row.Cells["CijenaPoDanu"].Value.ToString();
                chkAvailable.Checked = Convert.ToBoolean(row.Cells["Dostupno"].Value);
                txtImagePath.Text = row.Cells["Putanjaslike"].Value.ToString();
            }
        }

        private bool ValidateCarInput(out decimal pricePerDay, out int year, out int engineDisplacement)
        {
            pricePerDay = 0;
            year = 0;
            engineDisplacement = 0;

            if (string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text) || string.IsNullOrWhiteSpace(txtGorivo.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtPricePerDey.Text.Trim(), out pricePerDay) || pricePerDay <= 0)
            {
                MessageBox.Show("Unesite validnu pozitivnu cijenu po danu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out year) || year < 1950 || year > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Unesite validnu godinu (1950 - trenutna).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtMotor.Text.Trim(), out engineDisplacement) || engineDisplacement < 500 || engineDisplacement > 10000)
            {
                MessageBox.Show("Unesite validnu zapreminu motora (500–10000 ccm).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //  DODAJ SLIKU — dugme koje otvara FileDialog
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Odaberi sliku automobila",
                Filter = "Slike (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string folderPath = @"C:\SlikeAuta\";
                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    // Uzimamo originalno ime i ekstenziju
                    string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                    string extension = Path.GetExtension(ofd.FileName);

                    // Kreiramo novo jedinstveno ime (sa ekstenzijom radi kopiranja, ali bez za bazu)
                    string newFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    string destPath = Path.Combine(folderPath, newFileName);

                    // Kopiramo fajl u folder
                    File.Copy(ofd.FileName, destPath, true);

                    // U bazu ide ime BEZ ekstenzije
                    selectedImageFileName = Path.GetFileNameWithoutExtension(newFileName);
                    txtImagePath.Text = selectedImageFileName;

                    MessageBox.Show("Slika uspješno dodana!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dodavanju slike: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateCarInput(out decimal pricePerDay, out int year, out int engineDisplacement))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Automobili 
                                     (Marka, Model, ZapreminaMotora, Godište, Tip, Gorivo, ImagePath, Dostupno, CijenaPoDanu, Obrisan)
                                     VALUES (@b, @m, @z, @y, @t, @g, @i, @d, @p, 0)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@b", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@m", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@z", engineDisplacement);
                    cmd.Parameters.AddWithValue("@y", year);
                    cmd.Parameters.AddWithValue("@t", txtType.Text.Trim());
                    cmd.Parameters.AddWithValue("@g", txtGorivo.Text.Trim());
                    cmd.Parameters.AddWithValue("@i", selectedImageFileName);
                    cmd.Parameters.AddWithValue("@d", chkAvailable.Checked);
                    cmd.Parameters.AddWithValue("@p", pricePerDay);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Auto uspješno dodan!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCars();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju automobila: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCarId == -1)
            {
                MessageBox.Show("Odaberite automobil za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateCarInput(out decimal pricePerDay, out int year, out int engineDisplacement))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Automobili 
                                     SET Marka=@b, Model=@m, ZapreminaMotora=@z, Godište=@y, 
                                         Tip=@t, Gorivo=@g, CijenaPoDanu=@p, Dostupno=@d, ImagePath=@i
                                     WHERE AutomobilID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@b", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@m", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@z", engineDisplacement);
                    cmd.Parameters.AddWithValue("@y", year);
                    cmd.Parameters.AddWithValue("@t", txtType.Text.Trim());
                    cmd.Parameters.AddWithValue("@g", txtGorivo.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", pricePerDay);
                    cmd.Parameters.AddWithValue("@d", chkAvailable.Checked);
                    cmd.Parameters.AddWithValue("@i", txtImagePath.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedCarId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Automobil uspješno ažuriran!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCars();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri ažuriranju: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCarId == -1)
            {
                MessageBox.Show("Odaberite automobil za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da želite obrisati automobil?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Automobili SET Obrisan = 1 WHERE AutomobilID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedCarId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Automobil obrisan.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju: " + ex.Message);
                }
            }
        }


        //  Dugme za pretragu
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterColumn = cmbFilterBy.SelectedItem?.ToString();
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(filterColumn) || string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Unesite pojam i izaberite kolonu za pretragu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT AutomobilID AS AutomobilID, Marka AS Brand, Model, ZapreminaMotora, " +
                               $"CijenaPoDanu AS CijenaPoDanu, Godište AS Godište, Tip, Gorivo, Dostupno AS Dostupno, ImagePath AS Putanja Slike " +
                               $"FROM Automobili WHERE Obrisan = 0 AND {filterColumn} LIKE @value";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@value", "%" + searchValue + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCars.DataSource = dt;
            }
        }

        //  Dugme za reset (osvježava tabelu)
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterBy.SelectedIndex = -1;
            LoadCars();
        }

        // 📊 Dugme za izvoz u Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCars.Rows.Count == 0)
                {
                    MessageBox.Show("Nema podataka za izvoz!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel fajl|*.csv", FileName = "Automobili.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            // zaglavlja kolona
                            for (int i = 0; i < dgvCars.Columns.Count; i++)
                            {
                                sw.Write(dgvCars.Columns[i].HeaderText);
                                if (i < dgvCars.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();

                            // podaci
                            foreach (DataGridViewRow row in dgvCars.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < dgvCars.Columns.Count; i++)
                                    {
                                        sw.Write(row.Cells[i].Value?.ToString());
                                        if (i < dgvCars.Columns.Count - 1)
                                            sw.Write(",");
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show("Podaci uspješno izvezeni u CSV fajl!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izvozu: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtMotor.Clear();
            txtYear.Clear();
            txtType.Clear();
            txtGorivo.Clear();
            txtPricePerDey.Clear();
            txtImagePath.Clear();
            chkAvailable.Checked = true;
            selectedImageFileName = "";
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FormReservations frm = new FormReservations();
            frm.ShowDialog();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
