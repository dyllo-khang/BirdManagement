namespace BirdManagement
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnCancel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 246);
            label1.Name = "label1";
            label1.Size = new Size(179, 45);
            label1.TabIndex = 0;
            label1.Text = "User name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 384);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(268, 246);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(693, 57);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(268, 384);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(693, 57);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(268, 578);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 70);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(545, 578);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(165, 70);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(805, 578);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 70);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(268, 55);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(622, 59);
            label3.TabIndex = 7;
            label3.Text = "Phần Mềm Quản Lý Bán Chim";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 692);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnCancel;
        private Label label3;
    }
}