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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            picClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCancel = new Button();
            button1 = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 79);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(902, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 30);
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(331, 43);
            label1.TabIndex = 0;
            label1.Text = "Bird Farm Shop";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(398, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 250);
            label2.Name = "label2";
            label2.Size = new Size(304, 52);
            label2.TabIndex = 2;
            label2.Text = "Please Login First";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(0, 70, 160);
            label3.Location = new Point(279, 314);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 3;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(0, 70, 160);
            label4.Location = new Point(279, 409);
            label4.Name = "label4";
            label4.Size = new Size(131, 29);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 346);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 441);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 34);
            textBox2.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(279, 552);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(338, 42);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 70, 160);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(279, 504);
            button1.Name = "button1";
            button1.Size = new Size(338, 42);
            button1.TabIndex = 35;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 70, 160);
            label12.Location = new Point(357, 624);
            label12.Name = "label12";
            label12.Size = new Size(183, 21);
            label12.TabIndex = 37;
            label12.Text = "Create an account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 700);
            Controls.Add(label12);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picClose;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCancel;
        private Button button1;
        private Label label12;
    }
}