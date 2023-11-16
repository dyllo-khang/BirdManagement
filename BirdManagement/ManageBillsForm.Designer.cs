namespace BirdManagement
{
    partial class ManageBillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBillsForm));
            label9 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(711, 41);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(185, 25);
            label9.TabIndex = 50;
            label9.Text = "View Bill Details";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(603, 84);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(358, 300);
            dataGridView2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 48;
            label1.Text = "Bills Management";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 84);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(536, 300);
            dataGridView1.TabIndex = 47;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(13, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 37);
            label2.TabIndex = 14;
            label2.Text = "Manage Bill";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 586);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 75);
            panel1.TabIndex = 51;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3999, -117);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(156, 60);
            button1.TabIndex = 16;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 543);
            label3.Name = "label3";
            label3.Size = new Size(182, 22);
            label3.TabIndex = 52;
            label3.Text = "Filter By Date: From";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 535);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 543);
            label4.Name = "label4";
            label4.Size = new Size(30, 22);
            label4.TabIndex = 54;
            label4.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(465, 535);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 30);
            dateTimePicker2.TabIndex = 55;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 70, 160);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(695, 527);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 56;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 422);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 57;
            label5.Text = "Total :";
            // 
            // ManageBillsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageBillsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Bills";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dataGridView2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Label label5;
    }
}