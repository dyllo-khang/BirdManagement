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
            textBox4 = new TextBox();
            label8 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button3 = new Button();
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
            label2.Size = new Size(49, 20);
            label2.TabIndex = 69;
            label2.Text = "Role :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(493, 25);
            textBox4.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 106);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 67;
            label8.Text = "Fullname :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 239);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 71;
            label1.Text = "Activate :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 27);
            comboBox1.TabIndex = 72;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(152, 231);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(493, 27);
            comboBox2.TabIndex = 73;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 70, 160);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(406, 286);
            button3.Name = "button3";
            button3.Size = new Size(99, 45);
            button3.TabIndex = 74;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = false;
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
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(229, 43);
            label3.TabIndex = 0;
            label3.Text = "Account Properties";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AccountPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 362);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private Label label8;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button3;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private PictureBox picClose;
    }
}