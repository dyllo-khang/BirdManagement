namespace BirdManagement
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnImport = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 605);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 56);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1935, -25);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 16;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 19);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 14;
            label2.Text = "Manage Product";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(984, 270);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 21);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 4;
            label1.Text = "Bird Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 360);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 5;
            label3.Text = "ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 416);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "Bird Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 468);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 7;
            label5.Text = "Quantity :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 360);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 8;
            label6.Text = "Saleprice  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 416);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 9;
            label7.Text = "Input Price :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 468);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 10;
            label8.Text = "Category  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 26);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 410);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 26);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(590, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 26);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(590, 410);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 26);
            textBox4.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 462);
            numericUpDown1.Margin = new Padding(13, 16, 13, 16);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(118, 26);
            numericUpDown1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(590, 460);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 28);
            comboBox1.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 70, 160);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(77, 536);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 38);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add New ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(251, 536);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 38);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(0, 70, 160);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(570, 536);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(118, 38);
            btnImport.TabIndex = 20;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Red;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(764, 536);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(118, 38);
            btnExport.TabIndex = 21;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnImport;
        private Button btnExport;
    }
}