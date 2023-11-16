namespace BirdManagement
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dgvProduct = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtImPrice = new TextBox();
            udQuantity = new NumericUpDown();
            cbxType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnImport = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 611);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 56);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1960, -25);
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
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 64);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 82;
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(984, 270);
            dgvProduct.TabIndex = 3;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 21);
            label1.Name = "label1";
            label1.Size = new Size(416, 50);
            label1.TabIndex = 4;
            label1.Text = "Bird Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 360);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 5;
            label3.Text = "ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 416);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 6;
            label4.Text = "Bird Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 468);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 7;
            label5.Text = "Quantity :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 360);
            label6.Name = "label6";
            label6.Size = new Size(175, 37);
            label6.TabIndex = 8;
            label6.Text = "Saleprice  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 416);
            label7.Name = "label7";
            label7.Size = new Size(187, 37);
            label7.TabIndex = 9;
            label7.Text = "Input Price :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 468);
            label8.Name = "label8";
            label8.Size = new Size(180, 37);
            label8.TabIndex = 10;
            label8.Text = "Category  :";
            // 
            // txtID
            // 
            txtID.Location = new Point(124, 354);
            txtID.Name = "txtID";
            txtID.Size = new Size(332, 44);
            txtID.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 410);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 44);
            txtName.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(590, 354);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(340, 44);
            txtPrice.TabIndex = 13;
            // 
            // txtImPrice
            // 
            txtImPrice.Location = new Point(590, 410);
            txtImPrice.Name = "txtImPrice";
            txtImPrice.Size = new Size(340, 44);
            txtImPrice.TabIndex = 14;
            // 
            // udQuantity
            // 
            udQuantity.Location = new Point(124, 462);
            udQuantity.Margin = new Padding(13, 16, 13, 16);
            udQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            udQuantity.Name = "udQuantity";
            udQuantity.Size = new Size(118, 44);
            udQuantity.TabIndex = 15;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(590, 460);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(340, 45);
            cbxType.TabIndex = 16;
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
            btnAdd.Click += btnAdd_Click;
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
            btnUpdate.Click += btnUpdate_Click;
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
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(18F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 667);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbxType);
            Controls.Add(udQuantity);
            Controls.Add(txtImPrice);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRODUCTS";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)udQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dgvProduct;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtImPrice;
        private NumericUpDown udQuantity;
        private ComboBox cbxType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnImport;
        private Button btnExport;
    }
}