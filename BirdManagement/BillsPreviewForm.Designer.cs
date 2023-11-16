namespace BirdManagement
{
    partial class BillsPreviewForm
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
            button5 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label14 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label17 = new Label();
            label16 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 70, 160);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(781, 558);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 13;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(459, 558);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 30);
            dateTimePicker2.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(423, 567);
            label15.Name = "label15";
            label15.Size = new Size(30, 21);
            label15.TabIndex = 11;
            label15.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 558);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 567);
            label14.Name = "label14";
            label14.Size = new Size(182, 21);
            label14.TabIndex = 9;
            label14.Text = "Filter By Date : From";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(556, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(414, 217);
            dataGridView2.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(522, 217);
            dataGridView1.TabIndex = 53;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(686, 20);
            label17.Name = "label17";
            label17.Size = new Size(147, 27);
            label17.TabIndex = 57;
            label17.Text = "Bill Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(218, 20);
            label16.Name = "label16";
            label16.Size = new Size(110, 27);
            label16.TabIndex = 56;
            label16.Text = "Bill List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 319);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 58;
            label1.Text = "Total :";
            // 
            // label2
            // 
            label2.Location = new Point(373, 319);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 59;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BillsPreviewForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Controls.Add(label14);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BillsPreviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillsPreviewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private DateTimePicker dateTimePicker2;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label17;
        private Label label16;
        private Label label1;
        private Label label2;
    }
}