namespace rentcar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            txtUsername = new TextBox();
            panel2 = new Panel();
            txtPassword = new TextBox();
            panel3 = new Panel();
            txtEmail = new TextBox();
            panel4 = new Panel();
            txtConfirmPassword = new TextBox();
            panelPrezime = new Panel();
            txtLastname = new TextBox();
            buttonRegister = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelPrezime.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(40, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 49);
            panel1.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(16, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(325, 20);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Ime";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(40, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 49);
            panel2.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(16, 15);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(325, 20);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Šifra";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(40, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 49);
            panel3.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(16, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 20);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Email";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtConfirmPassword);
            panel4.Location = new Point(40, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 49);
            panel4.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.ForeColor = Color.Gray;
            txtConfirmPassword.Location = new Point(16, 15);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(325, 20);
            txtConfirmPassword.TabIndex = 0;
            txtConfirmPassword.Text = "Potvrdi šifru";
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panelPrezime
            // 
            panelPrezime.BackColor = Color.White;
            panelPrezime.Controls.Add(txtLastname);
            panelPrezime.Location = new Point(40, 110);
            panelPrezime.Name = "panelPrezime";
            panelPrezime.Size = new Size(355, 49);
            panelPrezime.TabIndex = 15;
            // 
            // txtLastname
            // 
            txtLastname.BorderStyle = BorderStyle.None;
            txtLastname.ForeColor = Color.Gray;
            txtLastname.Location = new Point(16, 15);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(325, 20);
            txtLastname.TabIndex = 0;
            txtLastname.Text = "Prezime";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(40, 355);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(171, 38);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Registruj se";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += btnRegister_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(432, 439);
            Controls.Add(panelPrezime);
            Controls.Add(buttonRegister);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Registracija";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelPrezime.ResumeLayout(false);
            panelPrezime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panelPrezime;
        private System.Windows.Forms.TextBox txtLastname;
    }
}
