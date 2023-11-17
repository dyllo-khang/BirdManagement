namespace BirdManagement
{
    partial class ManageAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccountForm));
            label1 = new Label();
            dgvAccount = new DataGridView();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            button2 = new Button();
            btnProperties = new Button();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            cbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 70, 160);
            label1.Location = new Point(354, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 27);
            label1.TabIndex = 50;
            label1.Text = "Account Management";
            // 
            // dgvAccount
            // 
            dgvAccount.BackgroundColor = Color.White;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(11, 52);
            dgvAccount.Margin = new Padding(4);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 25;
            dgvAccount.Size = new Size(958, 204);
            dgvAccount.TabIndex = 49;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(0, 70, 160);
            label11.Location = new Point(543, 404);
            label11.Name = "label11";
            label11.Size = new Size(77, 21);
            label11.TabIndex = 63;
            label11.Text = "Phone :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(0, 70, 160);
            label10.Location = new Point(543, 341);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 56;
            label10.Text = "Email :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(0, 70, 160);
            label9.Location = new Point(543, 283);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 55;
            label9.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 70, 160);
            label8.Location = new Point(10, 460);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 54;
            label8.Text = "Fullname :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(0, 70, 160);
            label7.Location = new Point(12, 404);
            label7.Name = "label7";
            label7.Size = new Size(176, 21);
            label7.TabIndex = 53;
            label7.Text = "Re-type Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 70, 160);
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 52;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 70, 160);
            label5.Location = new Point(10, 283);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 51;
            label5.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 70, 160);
            label2.Location = new Point(543, 460);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 65;
            label2.Text = "Role :";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 70, 160);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(729, 511);
            button2.Name = "button2";
            button2.Size = new Size(86, 45);
            button2.TabIndex = 67;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnProperties
            // 
            btnProperties.BackColor = Color.FromArgb(192, 192, 0);
            btnProperties.FlatAppearance.BorderSize = 0;
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.ForeColor = Color.White;
            btnProperties.Location = new Point(857, 511);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(112, 45);
            btnProperties.TabIndex = 68;
            btnProperties.Text = "Properties";
            btnProperties.UseVisualStyleBackColor = false;
            btnProperties.Click += btnProperties_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(639, 274);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(331, 30);
            txtAddress.TabIndex = 72;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(639, 332);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 30);
            txtEmail.TabIndex = 73;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(638, 395);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(331, 30);
            txtPhone.TabIndex = 74;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(194, 274);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(331, 30);
            txtUsername.TabIndex = 76;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(331, 30);
            txtPassword.TabIndex = 77;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(194, 395);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(331, 30);
            txtRePassword.TabIndex = 78;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(194, 451);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(331, 30);
            txtFullName.TabIndex = 79;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(13, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 37);
            label3.TabIndex = 14;
            label3.Text = "Manage Account";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 578);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 75);
            panel1.TabIndex = 80;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(4781, -142);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(156, 60);
            button4.TabIndex = 16;
            button4.Text = "Logout";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(639, 457);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 29);
            cbRole.TabIndex = 81;
            // 
            // ManageAccountForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(cbRole);
            Controls.Add(panel1);
            Controls.Add(txtFullName);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(btnProperties);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dgvAccount);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANAGE ACCOUNTS";
            Load += ManageAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAccount;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button button2;
        private Button btnProperties;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private TextBox txtFullName;
        private Label label3;
        private Panel panel1;
        private Button button4;
        private ComboBox cbRole;
    }
}