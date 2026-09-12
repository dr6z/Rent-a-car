using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rentcar
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string Ime, string Lozinka, out bool isAdmin, out int korisnikId)
        {
            isAdmin = false;
            korisnikId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT KorisnikID, IsAdmin FROM Korisnici WHERE Ime=@I AND Lozinka=@L";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@I", Ime);
                cmd.Parameters.AddWithValue("@L", Lozinka);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        korisnikId = Convert.ToInt32(reader["KorisnikID"]);
                        isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                        return true;
                    }
                }
                return false;
            }
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            string Ime = txtUsername.Text.Trim();
            string Lozinka = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Lozinka))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!");
                return;
            }

            bool isAdmin;
            int korisnikId;
            if (ValidateUser(Ime, Lozinka, out isAdmin, out korisnikId))
            {
                MessageBox.Show($"Prijavljeni ste kao {(isAdmin ? "Admin" : "Korisnik")}!");

                this.Hide();

                if (isAdmin)
                {
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.Show();
                }
                else
                {
                    Form3 userForm = new Form3(korisnikId); // 🔹 proslijedi ID korisnika
                    userForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili šifra!");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

    }
}
