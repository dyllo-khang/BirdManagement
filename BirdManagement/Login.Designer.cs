namespace Bird_Farm_Shop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picClose = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(920, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(30, 29);
            picClose.TabIndex = 12;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 0;
            label1.Text = "Bird Farm Shop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 70);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(417, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(305, 314);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 34);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(305, 400);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(325, 34);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 221);
            label2.Name = "label2";
            label2.Size = new Size(343, 40);
            label2.TabIndex = 11;
            label2.Text = "Please Login First";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 70, 160);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(305, 469);
            button1.Name = "button1";
            button1.Size = new Size(325, 40);
            button1.TabIndex = 12;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Location = new Point(305, 287);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 13;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.Location = new Point(305, 373);
            label4.Name = "label4";
            label4.Size = new Size(112, 24);
            label4.TabIndex = 14;
            label4.Text = "Password :";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(305, 525);
            button2.Name = "button2";
            button2.Size = new Size(325, 40);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picClose;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}