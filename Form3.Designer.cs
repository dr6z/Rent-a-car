namespace rentcar
{
    partial class Form3
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtCijenaOd = new TextBox();
            txtCijenaDo = new TextBox();
            txtGodisteOd = new TextBox();
            txtGodisteDo = new TextBox();
            cmbGorivo = new ComboBox();
            flowLayoutPanelCars = new FlowLayoutPanel();
            btnViewLocation = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pretraga po marki ili modelu...";
            txtSearch.Size = new Size(255, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(745, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Filtriraj";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCijenaOd
            // 
            txtCijenaOd.Location = new Point(281, 20);
            txtCijenaOd.Name = "txtCijenaOd";
            txtCijenaOd.PlaceholderText = "Cijena od";
            txtCijenaOd.Size = new Size(80, 27);
            txtCijenaOd.TabIndex = 5;
            // 
            // txtCijenaDo
            // 
            txtCijenaDo.Location = new Point(367, 20);
            txtCijenaDo.Name = "txtCijenaDo";
            txtCijenaDo.PlaceholderText = "Cijena do";
            txtCijenaDo.Size = new Size(80, 27);
            txtCijenaDo.TabIndex = 4;
            // 
            // txtGodisteOd
            // 
            txtGodisteOd.Location = new Point(467, 21);
            txtGodisteOd.Name = "txtGodisteOd";
            txtGodisteOd.PlaceholderText = "Godište od";
            txtGodisteOd.Size = new Size(80, 27);
            txtGodisteOd.TabIndex = 3;
            // 
            // txtGodisteDo
            // 
            txtGodisteDo.Location = new Point(553, 21);
            txtGodisteDo.Name = "txtGodisteDo";
            txtGodisteDo.PlaceholderText = "Godište do";
            txtGodisteDo.Size = new Size(80, 27);
            txtGodisteDo.TabIndex = 2;
            // 
            // cmbGorivo
            // 
            cmbGorivo.BackColor = Color.Silver;
            cmbGorivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorivo.Items.AddRange(new object[] { "Sva goriva", "Benzin", "Dizel", "Električno", "Hibrid" });
            cmbGorivo.Location = new Point(639, 21);
            cmbGorivo.Name = "cmbGorivo";
            cmbGorivo.Size = new Size(100, 28);
            cmbGorivo.TabIndex = 1;
            // 
            // flowLayoutPanelCars
            // 
            flowLayoutPanelCars.AutoScroll = true;
            flowLayoutPanelCars.Location = new Point(20, 55);
            flowLayoutPanelCars.Name = "flowLayoutPanelCars";
            flowLayoutPanelCars.Size = new Size(940, 517);
            flowLayoutPanelCars.TabIndex = 0;
            // 
            // btnViewLocation
            // 
            btnViewLocation.BackColor = Color.Blue;
            btnViewLocation.BackgroundImage = (Image)resources.GetObject("btnViewLocation.BackgroundImage");
            btnViewLocation.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewLocation.ForeColor = Color.Black;
            btnViewLocation.Location = new Point(851, 20);
            btnViewLocation.Name = "btnViewLocation";
            btnViewLocation.Size = new Size(109, 29);
            btnViewLocation.TabIndex = 8;
            btnViewLocation.UseVisualStyleBackColor = false;
            btnViewLocation.Click += btnViewLocation_Click;
            // 
            // Form3
            // 
            ClientSize = new Size(1002, 605);
            Controls.Add(flowLayoutPanelCars);
            Controls.Add(cmbGorivo);
            Controls.Add(txtGodisteDo);
            Controls.Add(txtGodisteOd);
            Controls.Add(txtCijenaDo);
            Controls.Add(txtCijenaOd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnViewLocation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Pregled automobila";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCijenaOd;
        private System.Windows.Forms.TextBox txtCijenaDo;
        private System.Windows.Forms.TextBox txtGodisteOd;
        private System.Windows.Forms.TextBox txtGodisteDo;
        private System.Windows.Forms.ComboBox cmbGorivo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCars;
        private Button btnViewLocation;
    }
}
