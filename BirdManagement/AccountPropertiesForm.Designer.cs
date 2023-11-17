namespace BirdManagement
{
    partial class AccountPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPropertiesForm));
            label2 = new Label();
            txtFullname = new TextBox();
            label8 = new Label();
            label1 = new Label();
            cbRole = new ComboBox();
            cbActive = new ComboBox();
            btnApply = new Button();
            button1 = new Button();
            panel1 = new Panel();
            picClose = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 172);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 69;
            label2.Text = "Role :";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(152, 97);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(493, 30);
            txtFullname.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 106);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 67;
            label8.Text = "Fullname :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 239);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 71;
            label1.Text = "Activate :";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(152, 164);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(493, 29);
            cbRole.TabIndex = 72;
            // 
            // cbActive
            // 
            cbActive.FormattingEnabled = true;
            cbActive.Location = new Point(152, 231);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(493, 29);
            cbActive.TabIndex = 73;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(0, 70, 160);
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(406, 286);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(99, 45);
            btnApply.TabIndex = 74;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(546, 286);
            button1.Name = "button1";
            button1.Size = new Size(99, 45);
            button1.TabIndex = 75;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 70);
            panel1.TabIndex = 76;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(652, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 29);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(271, 43);
            label3.TabIndex = 0;
            label3.Text = "Account Properties";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AccountPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 362);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnApply);
            Controls.Add(cbActive);
            Controls.Add(cbRole);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtFullname);
            Controls.Add(label8);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AccountPropertiesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Properties";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtFullname;
        private Label label8;
        private Label label1;
        private ComboBox cbRole;
        private ComboBox cbActive;
        private Button btnApply;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private PictureBox picClose;
    }
}