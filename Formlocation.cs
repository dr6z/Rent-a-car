using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentcar
{
    public partial class FormLocation : Form
    {
        //  Povezivanje na bazu iz App.config fajla
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public FormLocation()
        {
            InitializeComponent();
        }

        private async void FormLocation_Load(object sender, EventArgs e)
        {
            string adresa = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 Adresa FROM Lokacija ORDER BY LokacijaID DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    adresa = cmd.ExecuteScalar()?.ToString();
                }

                if (string.IsNullOrEmpty(adresa))
                {
                    MessageBox.Show("Nema dostupnih lokacija u bazi.");
                    return;
                }

                string mapUrl = "https://www.google.com/maps?q=" + Uri.EscapeDataString(adresa);
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate(mapUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}

