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
            btnSearch = new Button();
            dtpTo = new DateTimePicker();
            label15 = new Label();
            dtpFrom = new DateTimePicker();
            label14 = new Label();
            dgvBillDetail = new DataGridView();
            dgvBill = new DataGridView();
            label17 = new Label();
            label16 = new Label();
            label1 = new Label();
            lbTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 70, 160);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(781, 558);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(459, 558);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(215, 30);
            dtpTo.TabIndex = 12;
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
            // dtpFrom
            // 
            dtpFrom.Location = new Point(202, 558);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(215, 30);
            dtpFrom.TabIndex = 10;
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
            // dgvBillDetail
            // 
            dgvBillDetail.BackgroundColor = Color.White;
            dgvBillDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetail.Location = new Point(556, 66);
            dgvBillDetail.Name = "dgvBillDetail";
            dgvBillDetail.RowHeadersWidth = 51;
            dgvBillDetail.RowTemplate.Height = 29;
            dgvBillDetail.Size = new Size(414, 217);
            dgvBillDetail.TabIndex = 55;
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = Color.White;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(12, 66);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.Size = new Size(522, 217);
            dgvBill.TabIndex = 53;
            dgvBill.CellContentClick += dgvBill_CellClick;
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
            // lbTotalPrice
            // 
            lbTotalPrice.Location = new Point(373, 319);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(161, 21);
            lbTotalPrice.TabIndex = 59;
            lbTotalPrice.Text = "0.00";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BillsPreviewForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 600);
            Controls.Add(lbTotalPrice);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(dgvBillDetail);
            Controls.Add(dgvBill);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(label15);
            Controls.Add(dtpFrom);
            Controls.Add(label14);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BillsPreviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillsPreviewForm";
            Load += BillsPreviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private DateTimePicker dtpTo;
        private Label label15;
        private DateTimePicker dtpFrom;
        private Label label14;
        private DataGridView dgvBillDetail;
        private DataGridView dgvBill;
        private Label label17;
        private Label label16;
        private Label label1;
        private Label lbTotalPrice;
    }
}