using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentcar
{
    public partial class FormAddLocation : Form
    {
        //  Povezujemo se na istu bazu kao u ostatku aplikacije
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public FormAddLocation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Unesite naziv i adresu lokacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Lokacija (Naziv, Adresa, Opis) VALUES (@n, @a, @o)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNaziv.Text.Trim());
                        cmd.Parameters.AddWithValue("@a", txtAdresa.Text.Trim());
                        cmd.Parameters.AddWithValue("@o", txtOpis.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lokacija uspješno dodana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNaziv.Clear();
                txtAdresa.Clear();
                txtOpis.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju lokacije: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddLocation_Load(object sender, EventArgs e)
        {

        }
    }
}
