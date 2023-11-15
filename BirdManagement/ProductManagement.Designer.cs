namespace BirdManagement
{
    partial class ProductManagement
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
            dgvProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 12);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 82;
            dgvProduct.RowTemplate.Height = 41;
            dgvProduct.Size = new Size(994, 539);
            dgvProduct.TabIndex = 0;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 782);
            Controls.Add(dgvProduct);
            Name = "ProductManagement";
            Text = "PRODUCTS";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
    }
}