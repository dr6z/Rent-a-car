using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace rentcar
{
    public partial class Form3 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;
        private int korisnikId;

        public Form3(int korisnikId)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
        }

        private void btnViewLocation_Click(object sender, EventArgs e)
        {
            FormLocation frm = new FormLocation();
            frm.ShowDialog();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars(string markaModel = "", decimal? cijenaOd = null, decimal? cijenaDo = null, int? godisteOd = null, int? godisteDo = null, string gorivo = "")
        {
            flowLayoutPanelCars.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT AutomobilID, Marka, Model, Godište, ZapreminaMotora, CijenaPoDanu, Gorivo, ImagePath FROM Automobili WHERE Dostupno = 1";

                if (!string.IsNullOrEmpty(markaModel)) query += " AND (Marka LIKE @pretraga OR Model LIKE @pretraga)";
               // query += " AND (Marka LIKE @pretraga OR Model LIKE @pretraga)";
                if (cijenaOd.HasValue)
                    query += " AND CijenaPoDanu >= @cijenaOd";
                if (cijenaDo.HasValue)
                    query += " AND CijenaPoDanu <= @cijenaDo";
                if (godisteOd.HasValue)
                    query += " AND Godište >= @godisteOd";
                if (godisteDo.HasValue)
                    query += " AND Godište <= @godisteDo";
                if (!string.IsNullOrEmpty(gorivo))
                    query += " AND Gorivo = @gorivo";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(markaModel))
                    cmd.Parameters.AddWithValue("@pretraga", "%" + markaModel + "%");
                if (cijenaOd.HasValue)
                    cmd.Parameters.AddWithValue("@cijenaOd", cijenaOd.Value);
                if (cijenaDo.HasValue)
                    cmd.Parameters.AddWithValue("@cijenaDo", cijenaDo.Value);
                if (godisteOd.HasValue)
                    cmd.Parameters.AddWithValue("@godisteOd", godisteOd.Value);
                if (godisteDo.HasValue)
                    cmd.Parameters.AddWithValue("@godisteDo", godisteDo.Value);
                if (!string.IsNullOrEmpty(gorivo))
                    cmd.Parameters.AddWithValue("@gorivo", gorivo);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int carId = Convert.ToInt32(reader["AutomobilID"]);
                    decimal cijenaPoDanu = reader["CijenaPoDanu"] != DBNull.Value ?
                         Convert.ToDecimal(reader["CijenaPoDanu"])
                        : 0;

                    Panel panel = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(220, 330),
                        Margin = new Padding(10)
                    };

                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(200, 130),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10, 10)
                    };

                    string baseName = reader["ImagePath"].ToString();
                    string folderPath = @"C:\SlikeAuta\";
                    string imgPathJpg = Path.Combine(folderPath, baseName + ".jpg");
                    string imgPathJpeg = Path.Combine(folderPath, baseName + ".jpeg");

                    if (File.Exists(imgPathJpg))
                        pb.Image = Image.FromFile(imgPathJpg);
                    else if (File.Exists(imgPathJpeg))
                        pb.Image = Image.FromFile(imgPathJpeg);
                    else
                        pb.BackColor = Color.LightGray;

                    Label lblTitle = new Label
                    {
                        Text = reader["Marka"].ToString() + " " + reader["Model"].ToString(),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        AutoSize = true,
                        Location = new Point(10, 150)
                    };

                    Label lblGodiste = new Label
                    {
                        Text = "Godište: " + reader["Godište"].ToString(),
                        AutoSize = true,
                        Location = new Point(10, 175)
                    };

                    Label lblZapreminaMotora = new Label
                    {
                        Text = "Motor: " + reader["ZapreminaMotora"].ToString() + " cm³",
                        AutoSize = true,
                        Location = new Point(10, 195)
                    };

                    Label lblGorivo = new Label
                    {
                        Text = "Gorivo: " + reader["Gorivo"].ToString(),
                        AutoSize = true,
                        Location = new Point(10, 215)
                    };

                    Label lblCijena = new Label
                    {
                        Text = "Cijena: " + (cijenaPoDanu > 0 ? cijenaPoDanu.ToString() : "N/A") + " KM/dan",
                        AutoSize = true,
                        Location = new Point(10, 235)
                    };

                    Button btnRent = new Button
                    {
                        Text = cijenaPoDanu > 0 ? "Iznajmi" : "Cijena Nije Unesena",
                        Size = new Size(100, 30),
                        Location = new Point(10, 265),
                        Enabled = cijenaPoDanu > 0
                    };

                    if (btnRent.Enabled)
                    {
                        btnRent.Click += (s, e) =>
                        {
                            Form4 f4 = new Form4(carId, cijenaPoDanu, korisnikId);
                            f4.ShowDialog();
                            LoadCars();
                        };
                    }

                    panel.Controls.Add(pb);
                    panel.Controls.Add(lblTitle);
                    panel.Controls.Add(lblGodiste);
                    panel.Controls.Add(lblZapreminaMotora);
                    panel.Controls.Add(lblGorivo);
                    panel.Controls.Add(lblCijena);
                    panel.Controls.Add(btnRent);

                    flowLayoutPanelCars.Controls.Add(panel);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal? cijenaOd = string.IsNullOrWhiteSpace(txtCijenaOd.Text) ? (decimal?)null : Convert.ToDecimal(txtCijenaOd.Text);
            decimal? cijenaDo = string.IsNullOrWhiteSpace(txtCijenaDo.Text) ? (decimal?)null : Convert.ToDecimal(txtCijenaDo.Text);
            int? godOd = string.IsNullOrWhiteSpace(txtGodisteOd.Text) ? (int?)null : Convert.ToInt32(txtGodisteOd.Text);
            int? godDo = string.IsNullOrWhiteSpace(txtGodisteDo.Text) ? (int?)null : Convert.ToInt32(txtGodisteDo.Text);
            string gorivo = cmbGorivo.SelectedIndex > 0 ? cmbGorivo.SelectedItem.ToString() : "";

            LoadCars(txtSearch.Text, cijenaOd, cijenaDo, godOd, godDo, gorivo);
        }
    }
}
