namespace BirdManagement
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSlide = new Panel();
            btnChangePassword = new Button();
            btnLogout = new Button();
            btnOPreview = new Button();
            btnBPreview = new Button();
            btnOProduct = new Button();
            btnNTran = new Button();
            panel1 = new Panel();
            lb1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panelSlide1 = new Panel();
            panel2 = new Panel();
            picClose = new PictureBox();
            pictureBox2 = new PictureBox();
            lbName = new Label();
            panelMain = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelBottom = new Panel();
            pictureBox3 = new PictureBox();
            lblDashboard = new Label();
            lblTimer = new Label();
            panelSlide.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.Controls.Add(btnChangePassword);
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(btnOPreview);
            panelSlide.Controls.Add(btnBPreview);
            panelSlide.Controls.Add(btnOProduct);
            panelSlide.Controls.Add(btnNTran);
            panelSlide.Controls.Add(panel1);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(200, 700);
            panelSlide.TabIndex = 6;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Dock = DockStyle.Top;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Image = (Image)resources.GetObject("btnChangePassword.Image");
            btnChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.Location = new Point(0, 380);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Padding = new Padding(5, 0, 0, 0);
            btnChangePassword.Size = new Size(200, 55);
            btnChangePassword.TabIndex = 10;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
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
            // btnOPreview
            // 
            btnOPreview.Dock = DockStyle.Top;
            btnOPreview.FlatAppearance.BorderSize = 0;
            btnOPreview.FlatStyle = FlatStyle.Flat;
            btnOPreview.ForeColor = Color.White;
            btnOPreview.Image = (Image)resources.GetObject("btnOPreview.Image");
            btnOPreview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOPreview.Location = new Point(0, 330);
            btnOPreview.Name = "btnOPreview";
            btnOPreview.Padding = new Padding(5, 0, 0, 0);
            btnOPreview.Size = new Size(200, 50);
            btnOPreview.TabIndex = 5;
            btnOPreview.Text = "Order Preview";
            btnOPreview.TextAlign = ContentAlignment.MiddleLeft;
            btnOPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOPreview.UseVisualStyleBackColor = true;
            btnOPreview.Click += btnOPreview_Click;
            // 
            // btnBPreview
            // 
            btnBPreview.Dock = DockStyle.Top;
            btnBPreview.FlatAppearance.BorderSize = 0;
            btnBPreview.FlatStyle = FlatStyle.Flat;
            btnBPreview.ForeColor = Color.White;
            btnBPreview.Image = (Image)resources.GetObject("btnBPreview.Image");
            btnBPreview.ImageAlign = ContentAlignment.MiddleLeft;
            btnBPreview.Location = new Point(0, 280);
            btnBPreview.Name = "btnBPreview";
            btnBPreview.Padding = new Padding(5, 0, 0, 0);
            btnBPreview.Size = new Size(200, 50);
            btnBPreview.TabIndex = 4;
            btnBPreview.Text = "Bills Preview";
            btnBPreview.TextAlign = ContentAlignment.MiddleLeft;
            btnBPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBPreview.UseVisualStyleBackColor = true;
            btnBPreview.Click += btnBPreview_Click;
            // 
            // btnOProduct
            // 
            btnOProduct.Dock = DockStyle.Top;
            btnOProduct.FlatAppearance.BorderSize = 0;
            btnOProduct.FlatStyle = FlatStyle.Flat;
            btnOProduct.ForeColor = Color.White;
            btnOProduct.Image = (Image)resources.GetObject("btnOProduct.Image");
            btnOProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnOProduct.Location = new Point(0, 230);
            btnOProduct.Name = "btnOProduct";
            btnOProduct.Padding = new Padding(5, 0, 0, 0);
            btnOProduct.Size = new Size(200, 50);
            btnOProduct.TabIndex = 3;
            btnOProduct.Text = " Order Product";
            btnOProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnOProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOProduct.UseVisualStyleBackColor = true;
            btnOProduct.Click += btnOProduct_Click;
            // 
            // btnNTran
            // 
            btnNTran.Dock = DockStyle.Top;
            btnNTran.FlatAppearance.BorderSize = 0;
            btnNTran.FlatStyle = FlatStyle.Flat;
            btnNTran.ForeColor = Color.White;
            btnNTran.Image = (Image)resources.GetObject("btnNTran.Image");
            btnNTran.ImageAlign = ContentAlignment.MiddleLeft;
            btnNTran.Location = new Point(0, 180);
            btnNTran.Name = "btnNTran";
            btnNTran.Padding = new Padding(5, 0, 0, 0);
            btnNTran.Size = new Size(200, 50);
            btnNTran.TabIndex = 2;
            btnNTran.Text = "New  Transaction";
            btnNTran.TextAlign = ContentAlignment.MiddleLeft;
            btnNTran.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNTran.UseVisualStyleBackColor = true;
            btnNTran.Click += btnNTran_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 180);
            panel1.TabIndex = 0;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(73, 139);
            lb1.Name = "lb1";
            lb1.Size = new Size(46, 21);
            lb1.TabIndex = 2;
            lb1.Text = "User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 70, 160);
            panel3.Controls.Add(panelSlide1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 700);
            panel3.TabIndex = 8;
            // 
            // panelSlide1
            // 
            panelSlide1.Location = new Point(0, 190);
            panelSlide1.Name = "panelSlide1";
            panelSlide1.Size = new Size(8, 50);
            panelSlide1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(picClose);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lbName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(208, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 50);
            panel2.TabIndex = 9;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(962, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 30);
            picClose.TabIndex = 3;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbName
            // 
            lbName.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(53, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(130, 38);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Location = new Point(208, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(992, 600);
            panelMain.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(0, 70, 160);
            panelBottom.Controls.Add(pictureBox3);
            panelBottom.Controls.Add(lblDashboard);
            panelBottom.Controls.Add(lblTimer);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(208, 650);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(992, 50);
            panelBottom.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(53, 7);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(267, 35);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Bird Farm Shop";
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.FromArgb(0, 70, 160);
            lblTimer.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(511, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(481, 50);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1200, 700);
            Controls.Add(panelBottom);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelSlide);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelSlide.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlide;
        private Button btnLogout;
        private Button btnOPreview;
        private Button btnBPreview;
        private Button btnOProduct;
        private Button btnNTran;
        private Panel panel1;
        private Label lb1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panelSlide1;
        private Panel panel2;
        private Label lbName;
        private Panel panelMain;
        private Button btnChangePassword;
        private PictureBox pictureBox2;
        private PictureBox picClose;
        private System.Windows.Forms.Timer timer1;
        private Panel panelBottom;
        private PictureBox pictureBox3;
        private Label lblDashboard;
        private Label lblTimer;
    }
}