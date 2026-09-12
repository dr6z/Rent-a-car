namespace rentcar
{
    partial class FormAddLocation
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNaziv;
        private Label lblAdresa;
        private Label lblOpis;
        private TextBox txtNaziv;
        private TextBox txtAdresa;
        private TextBox txtOpis;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddLocation));
            lblNaziv = new Label();
            lblAdresa = new Label();
            lblOpis = new Label();
            txtNaziv = new TextBox();
            txtAdresa = new TextBox();
            txtOpis = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.Location = new Point(30, 30);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(100, 23);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // lblAdresa
            // 
            lblAdresa.Location = new Point(30, 70);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(100, 23);
            lblAdresa.TabIndex = 2;
            lblAdresa.Text = "Adresa:";
            // 
            // lblOpis
            // 
            lblOpis.Location = new Point(30, 110);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(100, 23);
            lblOpis.TabIndex = 4;
            lblOpis.Text = "Opis:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(150, 30);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 27);
            txtNaziv.TabIndex = 1;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(150, 70);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(300, 27);
            txtAdresa.TabIndex = 3;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(150, 110);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(300, 60);
            txtOpis.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(150, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FormAddLocation
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(500, 226);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblAdresa);
            Controls.Add(txtAdresa);
            Controls.Add(lblOpis);
            Controls.Add(txtOpis);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddLocation";
            Text = "Dodaj lokaciju";
            Load += FormAddLocation_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
