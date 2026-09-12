namespace rentcar
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtMotor = new TextBox();
            txtYear = new TextBox();
            txtType = new TextBox();
            txtGorivo = new TextBox();
            txtPricePerDey = new TextBox();
            txtImagePath = new TextBox();
            txtSearch = new TextBox();
            chkAvailable = new CheckBox();
            button1 = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnReset = new Button();
            btnAddImage = new Button();
            btnExportExcel = new Button();
            btnReservations = new Button();
            cmbFilterBy = new ComboBox();
            dgvCars = new DataGridView();
            label10 = new Label();
            btnAddLocation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 94);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 160);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Godina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 193);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "Tip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 226);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Gorivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 259);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 4;
            label5.Text = "Cijena po danu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 292);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "Ime slike";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 58);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "Marka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 127);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 7;
            label8.Text = "Zapremina motora";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 19);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 8;
            label9.Text = "Pretraga po:";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(151, 58);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(125, 27);
            txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(151, 91);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 10;
            // 
            // txtMotor
            // 
            txtMotor.Location = new Point(151, 124);
            txtMotor.Name = "txtMotor";
            txtMotor.Size = new Size(125, 27);
            txtMotor.TabIndex = 11;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(151, 157);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 12;
            // 
            // txtType
            // 
            txtType.Location = new Point(151, 190);
            txtType.Name = "txtType";
            txtType.Size = new Size(125, 27);
            txtType.TabIndex = 13;
            // 
            // txtGorivo
            // 
            txtGorivo.Location = new Point(151, 223);
            txtGorivo.Name = "txtGorivo";
            txtGorivo.Size = new Size(125, 27);
            txtGorivo.TabIndex = 14;
            // 
            // txtPricePerDey
            // 
            txtPricePerDey.Location = new Point(151, 256);
            txtPricePerDey.Name = "txtPricePerDey";
            txtPricePerDey.Size = new Size(125, 27);
            txtPricePerDey.TabIndex = 15;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(151, 289);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(125, 27);
            txtImagePath.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(527, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 17;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Checked = true;
            chkAvailable.CheckState = CheckState.Checked;
            chkAvailable.Location = new Point(168, 322);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(96, 24);
            chkAvailable.TabIndex = 18;
            chkAvailable.Text = "Dostupno";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(11, 351);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 19;
            button1.Text = "Dodaj Auto ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGreen;
            btnUpdate.Location = new Point(151, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 30);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Ažuriraj Auto ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(11, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Obriši Auto";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(717, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Pretraži";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(224, 224, 224);
            btnReset.Location = new Point(827, 15);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 23;
            btnReset.Text = "Resetuj";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = SystemColors.ActiveCaption;
            btnAddImage.Location = new Point(151, 387);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(125, 30);
            btnAddImage.TabIndex = 24;
            btnAddImage.Text = "Dodaj sliku";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Lime;
            btnExportExcel.Location = new Point(1207, 16);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(125, 30);
            btnExportExcel.TabIndex = 25;
            btnExportExcel.Text = "Izvoz u Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnReservations
            // 
            btnReservations.BackColor = Color.OliveDrab;
            btnReservations.BackgroundImage = (Image)resources.GetObject("btnReservations.BackgroundImage");
            btnReservations.BackgroundImageLayout = ImageLayout.Stretch;
            btnReservations.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservations.Location = new Point(11, 432);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(265, 48);
            btnReservations.TabIndex = 26;
            btnReservations.Text = "Rezervacije";
            btnReservations.TextAlign = ContentAlignment.BottomCenter;
            btnReservations.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReservations.UseVisualStyleBackColor = false;
            btnReservations.Click += btnReservations_Click;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Items.AddRange(new object[] { "Marka", "Model", "Tip", "Gorivo", "Godina" });
            cmbFilterBy.Location = new Point(387, 16);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(130, 28);
            cmbFilterBy.TabIndex = 27;
            // 
            // dgvCars
            // 
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCars.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCars.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCars.GridColor = SystemColors.MenuHighlight;
            dgvCars.Location = new Point(291, 58);
            dgvCars.Name = "dgvCars";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 29;
            dgvCars.Size = new Size(1041, 422);
            dgvCars.TabIndex = 28;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 16);
            label10.Name = "label10";
            label10.Size = new Size(251, 28);
            label10.TabIndex = 29;
            label10.Text = "Administrativni Panel 🛠️";
            // 
            // btnAddLocation
            // 
            btnAddLocation.BackColor = Color.Honeydew;
            btnAddLocation.Location = new Point(1060, 12);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(141, 37);
            btnAddLocation.TabIndex = 0;
            btnAddLocation.Text = "Dodaj lokaciju";
            btnAddLocation.UseVisualStyleBackColor = false;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // FormAdmin
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1344, 572);
            Controls.Add(btnAddLocation);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(txtMotor);
            Controls.Add(txtYear);
            Controls.Add(txtType);
            Controls.Add(txtGorivo);
            Controls.Add(txtPricePerDey);
            Controls.Add(txtImagePath);
            Controls.Add(txtSearch);
            Controls.Add(chkAvailable);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(btnAddImage);
            Controls.Add(btnExportExcel);
            Controls.Add(btnReservations);
            Controls.Add(cmbFilterBy);
            Controls.Add(dgvCars);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdmin";
            Text = "Administracija automobila";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private TextBox txtBrand, txtModel, txtMotor, txtYear, txtType, txtGorivo, txtPricePerDey, txtImagePath, txtSearch;
        private CheckBox chkAvailable;
        private Button button1, btnUpdate, btnDelete, btnSearch, btnReset, btnAddImage, btnExportExcel, btnReservations;
        private ComboBox cmbFilterBy;
        private DataGridView dgvCars;
        private Label label10;
        private Button btnAddLocation;
    }
}
