namespace rentcar
{
    partial class FormReservations
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservations));
            lblTitle = new Label();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            dgvReservations = new DataGridView();
            btnDelete = new Button();
            btnExport = new Button();
            lblOdNajma = new Label();
            dtpOdNajma = new DateTimePicker();
            lblDoNajma = new Label();
            dtpDoNajma = new DateTimePicker();
            lblCijena = new Label();
            txtMinCijena = new TextBox();
            txtMaxCijena = new TextBox();
            btnFilter = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Pregled rezervacija 📋";
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.FromArgb(128, 255, 255);
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Location = new Point(30, 60);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(120, 28);
            cmbFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(160, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(320, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Pretraži";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(224, 224, 224);
            btnReset.Location = new Point(410, 59);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Resetuj";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.ColumnHeadersHeight = 29;
            dgvReservations.Location = new Point(30, 100);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(900, 300);
            dgvReservations.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(545, 59);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Obriši rezerv.";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(0, 192, 0);
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.Location = new Point(793, 59);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(137, 29);
            btnExport.TabIndex = 6;
            btnExport.Text = "Izvezi u CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // lblOdNajma
            // 
            lblOdNajma.AutoSize = true;
            lblOdNajma.Location = new Point(30, 418);
            lblOdNajma.Name = "lblOdNajma";
            lblOdNajma.Size = new Size(124, 20);
            lblOdNajma.TabIndex = 8;
            lblOdNajma.Text = "Datum najma od:";
            // 
            // dtpOdNajma
            // 
            dtpOdNajma.Format = DateTimePickerFormat.Short;
            dtpOdNajma.Location = new Point(172, 415);
            dtpOdNajma.Name = "dtpOdNajma";
            dtpOdNajma.Size = new Size(120, 27);
            dtpOdNajma.TabIndex = 9;
            // 
            // lblDoNajma
            // 
            lblDoNajma.AutoSize = true;
            lblDoNajma.Location = new Point(298, 420);
            lblDoNajma.Name = "lblDoNajma";
            lblDoNajma.Size = new Size(30, 20);
            lblDoNajma.TabIndex = 10;
            lblDoNajma.Text = "do:";
            // 
            // dtpDoNajma
            // 
            dtpDoNajma.Format = DateTimePickerFormat.Short;
            dtpDoNajma.Location = new Point(334, 415);
            dtpDoNajma.Name = "dtpDoNajma";
            dtpDoNajma.Size = new Size(120, 27);
            dtpDoNajma.TabIndex = 11;
            // 
            // lblCijena
            // 
            lblCijena.AutoSize = true;
            lblCijena.Location = new Point(470, 418);
            lblCijena.Name = "lblCijena";
            lblCijena.Size = new Size(163, 20);
            lblCijena.TabIndex = 12;
            lblCijena.Text = "Ukupna cijena (KM) od:";
            // 
            // txtMinCijena
            // 
            txtMinCijena.Location = new Point(639, 415);
            txtMinCijena.Name = "txtMinCijena";
            txtMinCijena.Size = new Size(73, 27);
            txtMinCijena.TabIndex = 13;
            // 
            // txtMaxCijena
            // 
            txtMaxCijena.Location = new Point(754, 415);
            txtMaxCijena.Name = "txtMaxCijena";
            txtMaxCijena.Size = new Size(80, 27);
            txtMaxCijena.TabIndex = 14;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(224, 224, 224);
            btnFilter.Location = new Point(840, 415);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(90, 27);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filtriraj";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(718, 420);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 16;
            label1.Text = "do:";
            // 
            // FormReservations
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(960, 470);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cmbFilter);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnExport);
            Controls.Add(dgvReservations);
            Controls.Add(lblOdNajma);
            Controls.Add(dtpOdNajma);
            Controls.Add(lblDoNajma);
            Controls.Add(dtpDoNajma);
            Controls.Add(lblCijena);
            Controls.Add(txtMinCijena);
            Controls.Add(txtMaxCijena);
            Controls.Add(btnFilter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReservations";
            Text = "Pregled rezervacija";
            Load += FormReservations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblOdNajma;
        private System.Windows.Forms.DateTimePicker dtpOdNajma;
        private System.Windows.Forms.Label lblDoNajma;
        private System.Windows.Forms.DateTimePicker dtpDoNajma;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtMinCijena;
        private System.Windows.Forms.TextBox txtMaxCijena;
        private System.Windows.Forms.Button btnFilter;
        private Label label1;
    }
}
