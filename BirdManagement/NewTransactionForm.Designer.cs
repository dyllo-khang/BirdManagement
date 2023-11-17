namespace BirdManagement
{
    partial class NewTransactionForm
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
            btnBuy = new Button();
            udDis = new NumericUpDown();
            lbTotal = new Label();
            lbSaleTotal = new Label();
            label11 = new Label();
            label10 = new Label();
            udQuantity = new NumericUpDown();
            label9 = new Label();
            btnAddCart = new Button();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            dgvCart = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            dgvProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)udDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Red;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(849, 396);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(121, 37);
            btnBuy.TabIndex = 47;
            btnBuy.Text = "Buy Now";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // udDis
            // 
            udDis.Location = new Point(677, 310);
            udDis.Margin = new Padding(6, 3, 6, 3);
            udDis.Name = "udDis";
            udDis.Size = new Size(108, 25);
            udDis.TabIndex = 46;
            udDis.ValueChanged += udDis_ValueChanged;
            // 
            // lbTotal
            // 
            lbTotal.Location = new Point(677, 359);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(242, 21);
            lbTotal.TabIndex = 45;
            lbTotal.Text = "0.00 ";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSaleTotal
            // 
            lbSaleTotal.Location = new Point(677, 276);
            lbSaleTotal.Name = "lbSaleTotal";
            lbSaleTotal.Size = new Size(242, 21);
            lbSaleTotal.TabIndex = 44;
            lbSaleTotal.Text = "0.00 ";
            lbSaleTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(556, 359);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 43;
            label11.Text = "Total : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(556, 319);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 42;
            label10.Text = "Discount : ";
            // 
            // udQuantity
            // 
            udQuantity.Location = new Point(114, 478);
            udQuantity.Margin = new Padding(4, 3, 4, 3);
            udQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            udQuantity.Name = "udQuantity";
            udQuantity.Size = new Size(114, 25);
            udQuantity.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(556, 275);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 40;
            label9.Text = "Sales Total : ";
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.FromArgb(192, 192, 0);
            btnAddCart.FlatAppearance.BorderSize = 0;
            btnAddCart.FlatStyle = FlatStyle.Flat;
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(372, 478);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(159, 49);
            btnAddCart.TabIndex = 39;
            btnAddCart.Text = "Add To Cart";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(114, 427);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(417, 25);
            txtPrice.TabIndex = 38;
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 376);
            txtName.Name = "txtName";
            txtName.Size = new Size(417, 25);
            txtName.TabIndex = 37;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(114, 326);
            txtID.Name = "txtID";
            txtID.Size = new Size(417, 25);
            txtID.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 487);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 35;
            label8.Text = "Quantity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 436);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 34;
            label7.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 385);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 33;
            label6.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 335);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 32;
            label5.Text = "ID :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 70, 160);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(439, 276);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(114, 273);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(288, 25);
            txtSearch.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 279);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 29;
            label4.Text = "Search :";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(556, 67);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(414, 188);
            dgvCart.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(742, 27);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 27;
            label3.Text = "Cart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 24;
            label1.Text = "Bird List";
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(9, 67);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(522, 188);
            dgvProduct.TabIndex = 26;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // NewTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 589);
            Controls.Add(btnBuy);
            Controls.Add(udDis);
            Controls.Add(lbTotal);
            Controls.Add(lbSaleTotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(udQuantity);
            Controls.Add(label9);
            Controls.Add(btnAddCart);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(dgvCart);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvProduct);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewTransactionForm";
            Load += NewTransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)udDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)udQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuy;
        private NumericUpDown udDis;
        private Label lbTotal;
        private Label lbSaleTotal;
        private Label label11;
        private Label label10;
        private NumericUpDown udQuantity;
        private Label label9;
        private Button btnAddCart;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label4;
        private DataGridView dgvCart;
        private Label label3;
        private Label label1;
        private DataGridView dgvProduct;
    }
}