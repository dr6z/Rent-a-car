namespace rentcar
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dateTimePickerOd = new DateTimePicker();
            dateTimePickerDo = new DateTimePicker();
            btnPotvrdi = new Button();
            lblOd = new Label();
            lblDo = new Label();
            SuspendLayout();
            // 
            // dateTimePickerOd
            // 
            dateTimePickerOd.Location = new Point(123, 23);
            dateTimePickerOd.Name = "dateTimePickerOd";
            dateTimePickerOd.Size = new Size(250, 27);
            dateTimePickerOd.TabIndex = 1;
            // 
            // dateTimePickerDo
            // 
            dateTimePickerDo.Location = new Point(123, 75);
            dateTimePickerDo.Name = "dateTimePickerDo";
            dateTimePickerDo.Size = new Size(250, 27);
            dateTimePickerDo.TabIndex = 3;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.BackColor = Color.FromArgb(192, 255, 192);
            btnPotvrdi.ForeColor = Color.Black;
            btnPotvrdi.Location = new Point(123, 117);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(250, 35);
            btnPotvrdi.TabIndex = 4;
            btnPotvrdi.Text = "Potvrdi najam";
            btnPotvrdi.UseVisualStyleBackColor = false;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(30, 30);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(87, 20);
            lblOd.TabIndex = 0;
            lblOd.Text = "Od datuma:";
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(30, 80);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(87, 20);
            lblDo.TabIndex = 2;
            lblDo.Text = "Do datuma:";
            // 
            // Form4
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(450, 200);
            Controls.Add(lblOd);
            Controls.Add(dateTimePickerOd);
            Controls.Add(lblDo);
            Controls.Add(dateTimePickerDo);
            Controls.Add(btnPotvrdi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odabir datuma";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
