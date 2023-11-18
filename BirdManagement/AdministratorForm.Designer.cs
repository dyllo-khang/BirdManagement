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
            btnShopping = new Button();
            panelSubUser = new Panel();
            btnChangePass = new Button();
            btnManageAcc = new Button();
            btnLogout = new Button();
            btnSetting = new Button();
            btnManageBills = new Button();
            btnManageOrders = new Button();
            btnProduct = new Button();
            panel1 = new Panel();
            lbName = new Label();
            lbRole = new Label();
            pictureBox1 = new PictureBox();
            panelSlide1 = new Panel();
            panelTitle = new Panel();
            picClose = new PictureBox();
            lbTitle = new Label();
            panelMain = new Panel();
            panel2 = new Panel();
            btnUpdateInfo = new Button();
            panelSlide.SuspendLayout();
            panelSubUser.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.Controls.Add(btnShopping);
            panelSlide.Controls.Add(panelSubUser);
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(btnSetting);
            panelSlide.Controls.Add(btnManageBills);
            panelSlide.Controls.Add(btnManageOrders);
            panelSlide.Controls.Add(btnProduct);
            panelSlide.Controls.Add(panel1);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(200, 700);
            panelSlide.TabIndex = 2;
            // 
            // btnShopping
            // 
            btnShopping.Dock = DockStyle.Top;
            btnShopping.FlatAppearance.BorderSize = 0;
            btnShopping.FlatStyle = FlatStyle.Flat;
            btnShopping.ForeColor = Color.White;
            btnShopping.Location = new Point(0, 530);
            btnShopping.Name = "btnShopping";
            btnShopping.Padding = new Padding(5, 0, 0, 0);
            btnShopping.Size = new Size(200, 50);
            btnShopping.TabIndex = 9;
            btnShopping.Text = "Shopping Offline";
            btnShopping.TextAlign = ContentAlignment.MiddleLeft;
            btnShopping.UseVisualStyleBackColor = true;
            btnShopping.Click += btnShopping_Click;
            // 
            // panelSubUser
            // 
            panelSubUser.BackColor = Color.FromArgb(0, 70, 200);
            panelSubUser.Controls.Add(btnUpdateInfo);
            panelSubUser.Controls.Add(btnChangePass);
            panelSubUser.Controls.Add(btnManageAcc);
            panelSubUser.Dock = DockStyle.Top;
            panelSubUser.Location = new Point(0, 380);
            panelSubUser.Name = "panelSubUser";
            panelSubUser.Size = new Size(200, 150);
            panelSubUser.TabIndex = 8;
            // 
            // btnChangePass
            // 
            btnChangePass.Dock = DockStyle.Top;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(0, 50);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Padding = new Padding(20, 0, 0, 0);
            btnChangePass.Size = new Size(200, 50);
            btnChangePass.TabIndex = 7;
            btnChangePass.Text = "Change Password";
            btnChangePass.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnManageAcc
            // 
            btnManageAcc.Dock = DockStyle.Top;
            btnManageAcc.FlatAppearance.BorderSize = 0;
            btnManageAcc.FlatStyle = FlatStyle.Flat;
            btnManageAcc.ForeColor = Color.White;
            btnManageAcc.Location = new Point(0, 0);
            btnManageAcc.Name = "btnManageAcc";
            btnManageAcc.Padding = new Padding(20, 0, 0, 0);
            btnManageAcc.Size = new Size(200, 50);
            btnManageAcc.TabIndex = 6;
            btnManageAcc.Text = "Manage Account";
            btnManageAcc.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAcc.UseVisualStyleBackColor = true;
            btnManageAcc.Click += btnManageAcc_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 650);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.ForeColor = Color.White;
            btnSetting.Location = new Point(0, 330);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(5, 0, 0, 0);
            btnSetting.Size = new Size(200, 50);
            btnSetting.TabIndex = 5;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
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
            btnProduct.Text = "Manage Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(lbRole);
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
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(37, 143);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(126, 21);
            lbRole.TabIndex = 1;
            lbRole.Text = "Administrator";
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
            // panelSlide1
            // 
            panelSlide1.Location = new Point(0, 180);
            panelSlide1.Name = "panelSlide1";
            panelSlide1.Size = new Size(8, 50);
            panelSlide1.TabIndex = 6;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(picClose);
            panelTitle.Controls.Add(lbTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            panelTitle.Location = new Point(208, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(974, 40);
            panelTitle.TabIndex = 3;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(944, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 30);
            picClose.TabIndex = 10;
            picClose.TabStop = false;
            picClose.Click += picClose_Click_1;
            // 
            // lbTitle
            // 
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(306, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(378, 21);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Title Name";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Location = new Point(208, 40);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(974, 660);
            panelMain.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelSlide1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 700);
            panel2.TabIndex = 5;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.Dock = DockStyle.Top;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.ForeColor = Color.White;
            btnUpdateInfo.Location = new Point(0, 100);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Padding = new Padding(20, 0, 0, 0);
            btnUpdateInfo.Size = new Size(200, 50);
            btnUpdateInfo.TabIndex = 11;
            btnUpdateInfo.Text = "Update Info";
            btnUpdateInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateInfo.UseVisualStyleBackColor = true;
            btnUpdateInfo.Click += btnUpdateInfo_Click;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1182, 700);
            Controls.Add(panelTitle);
            Controls.Add(panel2);
            Controls.Add(panelMain);
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
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Button btnProduct;
        private Panel panel1;
        private Button btnLogout;
        private Button btnSetting;
        private Button btnManageBills;
        private Button btnManageOrders;
        private Label lbRole;
        private PictureBox pictureBox1;
        private Panel panelSlide;
        private Panel panelTitle;
        private Label lbTitle;
        private Panel panelMain;
        private Label lbName;
        private Button btnShopping;
        private Panel panelSubUser;
        private Button btnChangePass;
        private Button btnManageAcc;
        private Panel panelSlide1;
        private Panel panel2;
        private PictureBox picClose;
        private Button btnUpdateInfo;
    }
}