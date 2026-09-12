namespace rentcar
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojKartice;
        private System.Windows.Forms.Label lblDatumIsteka;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtBrojKartice;
        private System.Windows.Forms.TextBox txtDatumIsteka;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnPlati;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lblIme = new Label();
            lblBrojKartice = new Label();
            lblDatumIsteka = new Label();
            lblCVV = new Label();
            txtIme = new TextBox();
            txtBrojKartice = new TextBox();
            txtDatumIsteka = new TextBox();
            txtCVV = new TextBox();
            btnPlati = new Button();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.Location = new Point(30, 30);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(114, 23);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime na kartici:";
            // 
            // lblBrojKartice
            // 
            lblBrojKartice.Location = new Point(30, 68);
            lblBrojKartice.Name = "lblBrojKartice";
            lblBrojKartice.Size = new Size(100, 23);
            lblBrojKartice.TabIndex = 2;
            lblBrojKartice.Text = "Broj kartice:";
            // 
            // lblDatumIsteka
            // 
            lblDatumIsteka.Location = new Point(30, 109);
            lblDatumIsteka.Name = "lblDatumIsteka";
            lblDatumIsteka.Size = new Size(162, 23);
            lblDatumIsteka.TabIndex = 4;
            lblDatumIsteka.Text = "Datum isteka (MM/YY):";
            // 
            // lblCVV
            // 
            lblCVV.Location = new Point(30, 150);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(100, 23);
            lblCVV.TabIndex = 6;
            lblCVV.Text = "CVV:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(198, 26);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(220, 27);
            txtIme.TabIndex = 1;
            txtIme.Tag = "jo";
            txtIme.WordWrap = false;
            // 
            // txtBrojKartice
            // 
            txtBrojKartice.Location = new Point(198, 64);
            txtBrojKartice.Name = "txtBrojKartice";
            txtBrojKartice.Size = new Size(220, 27);
            txtBrojKartice.TabIndex = 3;
            // 
            // txtDatumIsteka
            // 
            txtDatumIsteka.Location = new Point(198, 105);
            txtDatumIsteka.Name = "txtDatumIsteka";
            txtDatumIsteka.Size = new Size(220, 27);
            txtDatumIsteka.TabIndex = 5;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(198, 147);
            txtCVV.MaxLength = 3;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(220, 27);
            txtCVV.TabIndex = 7;
            // 
            // btnPlati
            // 
            btnPlati.BackColor = Color.FromArgb(192, 255, 192);
            btnPlati.Location = new Point(130, 190);
            btnPlati.Name = "btnPlati";
            btnPlati.Size = new Size(188, 48);
            btnPlati.TabIndex = 8;
            btnPlati.Text = "Potvrdi plaćanje";
            btnPlati.UseVisualStyleBackColor = false;
            btnPlati.Click += btnPlati_Click;
            // 
            // Form5
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(459, 250);
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblBrojKartice);
            Controls.Add(txtBrojKartice);
            Controls.Add(lblDatumIsteka);
            Controls.Add(txtDatumIsteka);
            Controls.Add(lblCVV);
            Controls.Add(txtCVV);
            Controls.Add(btnPlati);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Plaćanje karticom";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
