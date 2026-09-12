using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentcar
{
    public partial class Form4 : Form
    {
        private int carId;
        private int korisnikId;
        private decimal cijenaPoDanu;
        private string connectionString = ConfigurationManager.ConnectionStrings["RentaCar"].ConnectionString;

        public Form4(int carId, decimal cijenaPoDanu, int korisnikId)
        {
            InitializeComponent();
            this.carId = carId;
            this.cijenaPoDanu = cijenaPoDanu;
            this.korisnikId = korisnikId;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dateTimePickerOd.Value = DateTime.Now;
            dateTimePickerDo.Value = DateTime.Now.AddDays(1);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            DateTime datumOd = dateTimePickerOd.Value;
            DateTime datumDo = dateTimePickerDo.Value;

            if (datumDo <= datumOd)
            {
                MessageBox.Show("Datum vraćanja mora biti poslije datuma preuzimanja!");
                return;
            }

            int brojDana = (int)(datumDo - datumOd).TotalDays;
            decimal ukupnaCijena = brojDana * cijenaPoDanu;

            // 🔹 Prvo otvori formu za plaćanje
            Form5 paymentForm = new Form5();
            paymentForm.ShowDialog();

            // 🔹 Ako korisnik nije uspješno platio, prekini proces
            if (!paymentForm.PaymentSuccessful)
            {
                MessageBox.Show("Plaćanje nije izvršeno. Najam nije moguć.", "Otkazano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Unos u tabelu Najam
                    string insertQuery = @"
            INSERT INTO Najam (KorisnikID, AutomobilID, DatumNajma, DatumVracanja, UkupnaCijena)
            VALUES (@korisnik, @auto, @od, @do, @cijena)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@korisnik", korisnikId);
                    insertCmd.Parameters.AddWithValue("@auto", carId);
                    insertCmd.Parameters.AddWithValue("@od", datumOd);
                    insertCmd.Parameters.AddWithValue("@do", datumDo);
                    insertCmd.Parameters.AddWithValue("@cijena", ukupnaCijena);
                    insertCmd.ExecuteNonQuery();

                    // Ažuriraj dostupnost auta
                    string updateQuery = "UPDATE Automobili SET Dostupno = 0 WHERE AutomobilID = @id";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@id", carId);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Auto uspješno iznajmljen!\nUkupna cijena: {ukupnaCijena} KM", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom upisa u bazu: " + ex.Message);
            }
        }
    }
}
