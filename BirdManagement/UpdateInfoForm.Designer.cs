namespace BirdManagement
{
    partial class UpdateInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfoForm));
            btnUpdate = new Button();
            label9 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(624, 500);
            btnUpdate.Margin = new Padding(6, 4, 6, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 50);
            btnUpdate.TabIndex = 84;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 250);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 82;
            label9.Text = "Address : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 241);
            txtAddress.Margin = new Padding(7, 5, 7, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(739, 30);
            txtAddress.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 330);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 80;
            label6.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 174);
            txtName.Margin = new Padding(7, 5, 7, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(739, 30);
            txtName.TabIndex = 79;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 174);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 78;
            label7.Text = "Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 102);
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 408);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 85;
            label1.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 321);
            txtPhone.Margin = new Padding(7, 5, 7, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(739, 30);
            txtPhone.TabIndex = 86;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 399);
            txtEmail.Margin = new Padding(7, 5, 7, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(739, 30);
            txtEmail.TabIndex = 87;
            // 
            // UpdateInfoForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 660);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UPDATE INFO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label9;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtName;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtEmail;
    }
}