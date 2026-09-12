using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace rentcar
{
    public partial class Form5 : Form
    {
        public bool PaymentSuccessful { get; private set; } = false;

        public Form5()
        {
            InitializeComponent();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            // Validacija svih polja
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtBrojKartice.Text) ||
                string.IsNullOrWhiteSpace(txtDatumIsteka.Text) ||
                string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                MessageBox.Show("Molimo popunite sva polja za plaćanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBrojKartice.Text.Length < 12 || txtBrojKartice.Text.Length > 19)
            {
                MessageBox.Show("Broj kartice mora imati između 12 i 19 cifara!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV mora imati 3 cifre!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ako su svi podaci u redu
            PaymentSuccessful = true;
            MessageBox.Show("Plaćanje uspješno! Najam se može završiti.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
