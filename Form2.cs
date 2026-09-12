using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentcar
{
    public partial class Form2 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ime = txtUsername.Text.Trim();   
            string prezime = txtLastname.Text.Trim(); 
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Lozinke se ne podudaraju!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Korisnici (Ime, Prezime, Email, Lozinka, IsAdmin) VALUES (@i, @pr, @e, @p, 0)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@i", ime);
                    cmd.Parameters.AddWithValue("@pr", prezime);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Korisnik uspješno registrovan!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška: " + ex.Message);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
