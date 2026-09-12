using System;
using System.Drawing;
using System.Windows.Forms;

namespace rentcar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignin;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignin = new Button();
            btnRegister = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(15, 158);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 20);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(15, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 20);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.White;
            btnSignin.Location = new Point(46, 299);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(150, 40);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "Prijavi se";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Honeydew;
            btnRegister.Location = new Point(15, 369);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Napravi novi nalog";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(60, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(134, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Korisničko ime";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(87, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Šifra";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(221, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(633, 408);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(488, 371);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 8;
            label1.Text = "Rent a car";
            // 
            // Form1
            // 
            BackColor = Color.Silver;
            ClientSize = new Size(891, 432);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(btnSignin);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Rentacar Prijava";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox2;
        private Label label1;
    }
}
