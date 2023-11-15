namespace Bird_Farm_Shop
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            panelSlide = new Panel();
            btnDashboard = new Button();
            panelSubUser = new Panel();
            btnActAccount = new Button();
            btnChangePass = new Button();
            btnUpdateAcc = new Button();
            btnCreateAcc = new Button();
            btnLogout = new Button();
            btnUserSetting = new Button();
            btnManageBills = new Button();
            btnManageOrders = new Button();
            btnProduct = new Button();
            panel1 = new Panel();
            lbName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelTitle = new Panel();
            lbTitle = new Label();
            panelMain = new Panel();
            panelSlide.SuspendLayout();
            panelSubUser.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.Controls.Add(btnDashboard);
            panelSlide.Controls.Add(panelSubUser);
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(btnUserSetting);
            panelSlide.Controls.Add(btnManageBills);
            panelSlide.Controls.Add(btnManageOrders);
            panelSlide.Controls.Add(btnProduct);
            panelSlide.Controls.Add(panel1);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(200, 686);
            panelSlide.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 580);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5, 0, 0, 0);
            btnDashboard.Size = new Size(200, 50);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelSubUser
            // 
            panelSubUser.BackColor = Color.FromArgb(0, 70, 200);
            panelSubUser.Controls.Add(btnActAccount);
            panelSubUser.Controls.Add(btnChangePass);
            panelSubUser.Controls.Add(btnUpdateAcc);
            panelSubUser.Controls.Add(btnCreateAcc);
            panelSubUser.Dock = DockStyle.Top;
            panelSubUser.Location = new Point(0, 380);
            panelSubUser.Name = "panelSubUser";
            panelSubUser.Size = new Size(200, 200);
            panelSubUser.TabIndex = 8;
            // 
            // btnActAccount
            // 
            btnActAccount.Dock = DockStyle.Top;
            btnActAccount.FlatAppearance.BorderSize = 0;
            btnActAccount.FlatStyle = FlatStyle.Flat;
            btnActAccount.ForeColor = Color.White;
            btnActAccount.Location = new Point(0, 150);
            btnActAccount.Name = "btnActAccount";
            btnActAccount.Padding = new Padding(20, 0, 0, 0);
            btnActAccount.Size = new Size(200, 50);
            btnActAccount.TabIndex = 9;
            btnActAccount.Text = "Active/UnActive Account";
            btnActAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnActAccount.UseVisualStyleBackColor = true;
            btnActAccount.Click += btnActAccount_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.Dock = DockStyle.Top;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(0, 100);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Padding = new Padding(20, 0, 0, 0);
            btnChangePass.Size = new Size(200, 50);
            btnChangePass.TabIndex = 8;
            btnChangePass.Text = "Change Password";
            btnChangePass.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnUpdateAcc
            // 
            btnUpdateAcc.Dock = DockStyle.Top;
            btnUpdateAcc.FlatAppearance.BorderSize = 0;
            btnUpdateAcc.FlatStyle = FlatStyle.Flat;
            btnUpdateAcc.ForeColor = Color.White;
            btnUpdateAcc.Location = new Point(0, 50);
            btnUpdateAcc.Name = "btnUpdateAcc";
            btnUpdateAcc.Padding = new Padding(20, 0, 0, 0);
            btnUpdateAcc.Size = new Size(200, 50);
            btnUpdateAcc.TabIndex = 7;
            btnUpdateAcc.Text = "Update Account";
            btnUpdateAcc.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateAcc.UseVisualStyleBackColor = true;
            btnUpdateAcc.Click += btnUpdateAcc_Click;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.Dock = DockStyle.Top;
            btnCreateAcc.FlatAppearance.BorderSize = 0;
            btnCreateAcc.FlatStyle = FlatStyle.Flat;
            btnCreateAcc.ForeColor = Color.White;
            btnCreateAcc.Location = new Point(0, 0);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Padding = new Padding(20, 0, 0, 0);
            btnCreateAcc.Size = new Size(200, 50);
            btnCreateAcc.TabIndex = 6;
            btnCreateAcc.Text = "Create Account";
            btnCreateAcc.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateAcc.UseVisualStyleBackColor = true;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 636);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUserSetting
            // 
            btnUserSetting.Dock = DockStyle.Top;
            btnUserSetting.FlatAppearance.BorderSize = 0;
            btnUserSetting.FlatStyle = FlatStyle.Flat;
            btnUserSetting.ForeColor = Color.White;
            btnUserSetting.Location = new Point(0, 330);
            btnUserSetting.Name = "btnUserSetting";
            btnUserSetting.Padding = new Padding(5, 0, 0, 0);
            btnUserSetting.Size = new Size(200, 50);
            btnUserSetting.TabIndex = 5;
            btnUserSetting.Text = "User Setting";
            btnUserSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnUserSetting.UseVisualStyleBackColor = true;
            btnUserSetting.Click += btnUserSetting_Click;
            // 
            // btnManageBills
            // 
            btnManageBills.Dock = DockStyle.Top;
            btnManageBills.FlatAppearance.BorderSize = 0;
            btnManageBills.FlatStyle = FlatStyle.Flat;
            btnManageBills.ForeColor = Color.White;
            btnManageBills.Location = new Point(0, 280);
            btnManageBills.Name = "btnManageBills";
            btnManageBills.Padding = new Padding(5, 0, 0, 0);
            btnManageBills.Size = new Size(200, 50);
            btnManageBills.TabIndex = 4;
            btnManageBills.Text = "Manage Bills";
            btnManageBills.TextAlign = ContentAlignment.MiddleLeft;
            btnManageBills.UseVisualStyleBackColor = true;
            btnManageBills.Click += btnManageBills_Click;
            // 
            // btnManageOrders
            // 
            btnManageOrders.Dock = DockStyle.Top;
            btnManageOrders.FlatAppearance.BorderSize = 0;
            btnManageOrders.FlatStyle = FlatStyle.Flat;
            btnManageOrders.ForeColor = Color.White;
            btnManageOrders.Location = new Point(0, 230);
            btnManageOrders.Name = "btnManageOrders";
            btnManageOrders.Padding = new Padding(5, 0, 0, 0);
            btnManageOrders.Size = new Size(200, 50);
            btnManageOrders.TabIndex = 3;
            btnManageOrders.Text = "Manage Orders";
            btnManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnManageOrders.UseVisualStyleBackColor = true;
            btnManageOrders.Click += btnManageOrders_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(0, 180);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(5, 0, 0, 0);
            btnProduct.Size = new Size(200, 50);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 180);
            panel1.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(50, 122);
            lbName.Name = "lbName";
            lbName.Size = new Size(98, 21);
            lbName.TabIndex = 2;
            lbName.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 143);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 1;
            label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lbTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            panelTitle.Location = new Point(200, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(982, 40);
            panelTitle.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(328, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(378, 21);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Title Name";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 40);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(982, 646);
            panelMain.TabIndex = 4;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1182, 686);
            Controls.Add(panelMain);
            Controls.Add(panelTitle);
            Controls.Add(panelSlide);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator Form";
            Load += AdministratorForm_Load;
            panelSlide.ResumeLayout(false);
            panelSubUser.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Button btnProduct;
        private Panel panel1;
        private Button btnLogout;
        private Button btnUserSetting;
        private Button btnManageBills;
        private Button btnManageOrders;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelSlide;
        private Panel panelTitle;
        private Label lbTitle;
        private Panel panelMain;
        private Label lbName;
        private Button btnDashboard;
        private Panel panelSubUser;
        private Button btnActAccount;
        private Button btnChangePass;
        private Button btnUpdateAcc;
        private Button btnCreateAcc;
    }
}