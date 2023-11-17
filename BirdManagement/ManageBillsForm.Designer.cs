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
            dgvBillDetail = new DataGridView();
            label1 = new Label();
            dgvBill = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnSearch = new Button();
            label5 = new Label();
            lbTotalPrice = new Label();
            lbTotalProfit = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 70, 160);
            label9.Location = new Point(633, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 23);
            label9.TabIndex = 50;
            label9.Text = "View Bill Details";
            // 
            // dgvBillDetail
            // 
            dgvBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillDetail.BackgroundColor = Color.White;
            dgvBillDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetail.Location = new Point(475, 52);
            dgvBillDetail.Margin = new Padding(4);
            dgvBillDetail.Name = "dgvBillDetail";
            dgvBillDetail.RowHeadersVisible = false;
            dgvBillDetail.RowHeadersWidth = 51;
            dgvBillDetail.RowTemplate.Height = 25;
            dgvBillDetail.Size = new Size(493, 300);
            dgvBillDetail.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 70, 160);
            label1.Location = new Point(133, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 48;
            label1.Text = "Bills Management";
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = Color.White;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(10, 52);
            dgvBill.Margin = new Padding(4);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 25;
            dgvBill.Size = new Size(437, 300);
            dgvBill.TabIndex = 47;
            dgvBill.CellClick += dgvBill_CellClick;
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
            label2.Size = new Size(164, 37);
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
            label3.Size = new Size(146, 20);
            label3.TabIndex = 52;
            label3.Text = "Filter By Date: From";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 535);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 543);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 54;
            label4.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(465, 535);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 26);
            dateTimePicker2.TabIndex = 55;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 70, 160);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(695, 527);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 36);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 386);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 57;
            label5.Text = "Total Price:";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(310, 386);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(0, 20);
            lbTotalPrice.TabIndex = 58;
            // 
            // lbTotalProfit
            // 
            lbTotalProfit.AutoSize = true;
            lbTotalProfit.Location = new Point(610, 386);
            lbTotalProfit.Name = "lbTotalProfit";
            lbTotalProfit.Size = new Size(0, 20);
            lbTotalProfit.TabIndex = 62;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(475, 386);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 61;
            label11.Text = "Profit :";
            // 
            // ManageBillsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(lbTotalProfit);
            Controls.Add(label11);
            Controls.Add(lbTotalPrice);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(dgvBillDetail);
            Controls.Add(label1);
            Controls.Add(dgvBill);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageBillsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANAGE BILLS";
            Load += ManageBillsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dgvBillDetail;
        private Label label1;
        private DataGridView dgvBill;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Button btnSearch;
        private Label label5;
        private Label lbTotalPrice;
        private Label lbTotalProfit;
        private Label label11;
    }
}