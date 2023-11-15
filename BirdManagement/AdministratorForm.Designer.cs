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
            panel4 = new Panel();
            button1 = new Button();
            panelSlide = new Panel();
            btnLogout = new Button();
            btnUserSetting = new Button();
            btnManageBills = new Button();
            btnManageOrders = new Button();
            btnProduct = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lbTitle = new Label();
            panelMain = new Panel();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panelSlide);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnUserSetting);
            panel4.Controls.Add(btnManageBills);
            panel4.Controls.Add(btnManageOrders);
            panel4.Controls.Add(btnProduct);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 686);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 380);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 8;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelSlide
            // 
            panelSlide.Location = new Point(191, 180);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 50);
            panelSlide.TabIndex = 7;
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
            btnUserSetting.Size = new Size(200, 50);
            btnUserSetting.TabIndex = 5;
            btnUserSetting.Text = "User Setting";
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
            btnManageBills.Size = new Size(200, 50);
            btnManageBills.TabIndex = 4;
            btnManageBills.Text = "Manage Bills";
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
            btnManageOrders.Size = new Size(200, 50);
            btnManageOrders.TabIndex = 3;
            btnManageOrders.Text = "Manage Orders";
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
            btnProduct.Size = new Size(200, 50);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 180);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 143);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 1;
            label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 40);
            panel2.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(488, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(166, 36);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Title Name";
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
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1182, 686);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator Form";
            Load += AdministratorForm_Load;
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button btnProduct;
        private Panel panel1;
        private Button btnLogout;
        private Button btnUserSetting;
        private Button btnManageBills;
        private Button btnManageOrders;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelSlide;
        private Button button1;
        private Panel panel2;
        private Label lbTitle;
        private Panel panelMain;
    }
}