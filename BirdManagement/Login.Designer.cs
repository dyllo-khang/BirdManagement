namespace Bird_Farm_Shop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picClose = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            label5 = new Label();
            lblRegister = new Label();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(915, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 29);
            picClose.TabIndex = 12;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 0;
            label1.Text = "Bird Farm Shop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 70);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(417, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(296, 314);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(343, 34);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "sa";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(296, 400);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(343, 34);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 221);
            label2.Name = "label2";
            label2.Size = new Size(276, 32);
            label2.TabIndex = 11;
            label2.Text = "Please Login First";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 70, 160);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(296, 469);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 40);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.Location = new Point(296, 287);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 13;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.Location = new Point(296, 373);
            label4.Name = "label4";
            label4.Size = new Size(112, 24);
            label4.TabIndex = 14;
            label4.Text = "Password :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(296, 525);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(343, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.Location = new Point(292, 584);
            label5.Name = "label5";
            label5.Size = new Size(225, 24);
            label5.TabIndex = 16;
            label5.Text = "Don't have account ?";
            // 
            // lblRegister
            // 
            lblRegister.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(0, 70, 160);
            lblRegister.Location = new Point(490, 584);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(149, 24);
            lblRegister.TabIndex = 17;
            lblRegister.Text = "Register here !";
            lblRegister.Click += lblRegister_Click;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(lblRegister);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picClose;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Label label5;
        private Label lblRegister;
    }
}