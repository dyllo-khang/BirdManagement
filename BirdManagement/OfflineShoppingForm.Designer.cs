namespace BirdManagement
{
    partial class OfflineShoppingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineShoppingForm));
            udQuantity = new NumericUpDown();
            btnAddCart = new Button();
            txtPrice = new TextBox();
            txtNameCus = new TextBox();
            txtPhone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvProduct = new DataGridView();
            txtName = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            udDis = new NumericUpDown();
            lbTotal = new Label();
            lbSaleTotal = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dgvCart = new DataGridView();
            label4 = new Label();
            btnSearchCus = new Button();
            btnBuy = new Button();
            pictureBox3 = new PictureBox();
            label14 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)udQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // udQuantity
            // 
            udQuantity.Location = new Point(656, 208);
            udQuantity.Margin = new Padding(4, 3, 4, 3);
            udQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            udQuantity.Name = "udQuantity";
            udQuantity.Size = new Size(114, 30);
            udQuantity.TabIndex = 55;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.FromArgb(192, 192, 0);
            btnAddCart.FlatAppearance.BorderSize = 0;
            btnAddCart.FlatStyle = FlatStyle.Flat;
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(815, 197);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(159, 40);
            btnAddCart.TabIndex = 54;
            btnAddCart.Text = "Add To Cart";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(656, 157);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(318, 30);
            txtPrice.TabIndex = 53;
            // 
            // txtNameCus
            // 
            txtNameCus.Location = new Point(95, 408);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new Size(310, 30);
            txtNameCus.TabIndex = 52;
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(95, 359);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(310, 30);
            txtPhone.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(551, 217);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 50;
            label8.Text = "Quantity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 166);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 49;
            label7.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 417);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 48;
            label6.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 368);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 47;
            label5.Text = "Phone :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 70, 160);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(442, 276);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(12, 277);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(393, 30);
            txtSearch.TabIndex = 45;
            txtSearch.Text = "Search here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 14);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 42;
            label1.Text = "Bird List";
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(9, 54);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(525, 212);
            dgvProduct.TabIndex = 43;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(656, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 30);
            txtName.TabIndex = 60;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(656, 54);
            txtID.Name = "txtID";
            txtID.Size = new Size(315, 30);
            txtID.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 114);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 58;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 57;
            label3.Text = "Id :";
            // 
            // udDis
            // 
            udDis.Location = new Point(690, 471);
            udDis.Margin = new Padding(6, 3, 6, 3);
            udDis.Name = "udDis";
            udDis.Size = new Size(78, 30);
            udDis.TabIndex = 68;
            udDis.ValueChanged += udDis_ValueChanged;
            // 
            // lbTotal
            // 
            lbTotal.Location = new Point(690, 511);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(178, 30);
            lbTotal.TabIndex = 67;
            lbTotal.Text = "0.00 ";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSaleTotal
            // 
            lbSaleTotal.Location = new Point(690, 431);
            lbSaleTotal.Name = "lbSaleTotal";
            lbSaleTotal.Size = new Size(178, 30);
            lbSaleTotal.TabIndex = 66;
            lbSaleTotal.Text = "0.00 ";
            lbSaleTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(551, 520);
            label11.Name = "label11";
            label11.Size = new Size(67, 21);
            label11.TabIndex = 65;
            label11.Text = "Total : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(551, 480);
            label10.Name = "label10";
            label10.Size = new Size(132, 21);
            label10.TabIndex = 64;
            label10.Text = "Discount (%) : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 440);
            label9.Name = "label9";
            label9.Size = new Size(115, 21);
            label9.TabIndex = 63;
            label9.Text = "Sales Total : ";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(551, 282);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(419, 143);
            dgvCart.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(733, 252);
            label4.Name = "label4";
            label4.Size = new Size(66, 27);
            label4.TabIndex = 61;
            label4.Text = "Cart";
            // 
            // btnSearchCus
            // 
            btnSearchCus.BackColor = Color.FromArgb(0, 70, 160);
            btnSearchCus.FlatAppearance.BorderSize = 0;
            btnSearchCus.FlatStyle = FlatStyle.Flat;
            btnSearchCus.ForeColor = Color.White;
            btnSearchCus.Location = new Point(431, 386);
            btnSearchCus.Name = "btnSearchCus";
            btnSearchCus.Size = new Size(92, 29);
            btnSearchCus.TabIndex = 70;
            btnSearchCus.Text = "Search";
            btnSearchCus.UseVisualStyleBackColor = false;
            btnSearchCus.Click += btnSearchCus_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Red;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(901, 431);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(69, 52);
            btnBuy.TabIndex = 71;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 70, 160);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(901, 489);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 72;
            pictureBox3.TabStop = false;
            // 
            // label14
            // 
            label14.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Image = (Image)resources.GetObject("label14.Image");
            label14.ImageAlign = ContentAlignment.MiddleLeft;
            label14.Location = new Point(4, 20);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(196, 37);
            label14.TabIndex = 14;
            label14.Text = "Offline Shopping";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 607);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 75);
            panel1.TabIndex = 74;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3997, -117);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(156, 60);
            button4.TabIndex = 16;
            button4.Text = "Logout";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // OfflineShoppingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 682);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(btnBuy);
            Controls.Add(btnSearchCus);
            Controls.Add(udDis);
            Controls.Add(lbTotal);
            Controls.Add(lbSaleTotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgvCart);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(udQuantity);
            Controls.Add(btnAddCart);
            Controls.Add(txtPrice);
            Controls.Add(txtNameCus);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvProduct);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "OfflineShoppingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OFFLINE SHOPPING";
            Load += OfflineShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)udQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)udDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown udQuantity;
        private Button btnAddCart;
        private TextBox txtPrice;
        private TextBox txtNameCus;
        private TextBox txtPhone;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvProduct;
        private TextBox txtName;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private NumericUpDown udDis;
        private Label lbTotal;
        private Label lbSaleTotal;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dgvCart;
        private Label label4;
        private Button btnSearchCus;
        private Button btnBuy;
        private PictureBox pictureBox3;
        private Label label14;
        private Panel panel1;
        private Button button4;
    }
}