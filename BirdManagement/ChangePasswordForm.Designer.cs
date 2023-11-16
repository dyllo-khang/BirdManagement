namespace BirdManagement
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            btnPassCancel = new Button();
            btnUpdate = new Button();
            txtRePass2 = new TextBox();
            label9 = new Label();
            txtNPass = new TextBox();
            label6 = new Label();
            txtCurPass = new TextBox();
            label7 = new Label();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPassCancel
            // 
            btnPassCancel.BackColor = Color.Gainsboro;
            btnPassCancel.FlatAppearance.BorderSize = 0;
            btnPassCancel.FlatStyle = FlatStyle.Flat;
            btnPassCancel.ForeColor = Color.Black;
            btnPassCancel.Location = new Point(798, 458);
            btnPassCancel.Margin = new Padding(4);
            btnPassCancel.Name = "btnPassCancel";
            btnPassCancel.Size = new Size(152, 48);
            btnPassCancel.TabIndex = 76;
            btnPassCancel.Text = "Cancel";
            btnPassCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(605, 458);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 48);
            btnUpdate.TabIndex = 75;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtRePass2
            // 
            txtRePass2.Location = new Point(184, 385);
            txtRePass2.Margin = new Padding(5);
            txtRePass2.Name = "txtRePass2";
            txtRePass2.Size = new Size(768, 30);
            txtRePass2.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 315);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(157, 22);
            label9.TabIndex = 73;
            label9.Text = "New Password : ";
            // 
            // txtNPass
            // 
            txtNPass.Location = new Point(184, 309);
            txtNPass.Margin = new Padding(5);
            txtNPass.Name = "txtNPass";
            txtNPass.Size = new Size(768, 30);
            txtNPass.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 391);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(188, 22);
            label6.TabIndex = 71;
            label6.Text = "Re-type Password : ";
            // 
            // txtCurPass
            // 
            txtCurPass.Location = new Point(184, 237);
            txtCurPass.Margin = new Padding(5);
            txtCurPass.Name = "txtCurPass";
            txtCurPass.Size = new Size(768, 30);
            txtCurPass.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 243);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 22);
            label7.TabIndex = 69;
            label7.Text = "Password : ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(217, 169);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 22);
            lblUsername.TabIndex = 68;
            lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 88);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 101);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(31, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 14;
            label2.Text = "User Setting";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 586);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 75);
            panel1.TabIndex = 77;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(5581, -169);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(156, 60);
            button1.TabIndex = 16;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Controls.Add(btnPassCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtRePass2);
            Controls.Add(label9);
            Controls.Add(txtNPass);
            Controls.Add(label6);
            Controls.Add(txtCurPass);
            Controls.Add(label7);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPassCancel;
        private Button btnUpdate;
        private TextBox txtRePass2;
        private Label label9;
        private TextBox txtNPass;
        private Label label6;
        private TextBox txtCurPass;
        private Label label7;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Button button1;
    }
}