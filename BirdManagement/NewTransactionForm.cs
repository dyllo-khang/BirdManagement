using BusinessObject.Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdManagement
{
    public partial class NewTransactionForm : Form
    {
        IProductService _productService;
        List<Product> _products;
        public NewTransactionForm()
        {
            InitializeComponent();
            txtPrice.Enabled = false;
            _productService = new ProductService();
            _products = _productService.GetAll();
        }

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.DataSource = _products.Select(x => new
            {
                No = x.Id,
                x.Name,
                x.Price,
                x.Quantity,
                Type = x.Type?.Name,
                IInventory = x.Quantity > 0 ? "Stocking" : "Sold Out"
            }).ToList();
        }

        protected void Reset()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            udQuantity.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string seacrch = txtSearch.Text;
            _products = _productService.GetAll(seacrch);
            NewTransactionForm_Load(this, EventArgs.Empty);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            udQuantity.Value = 1;
        }

        List<Product> listAddCart = new List<Product>();
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(txtID.Text);
            product.Id = id;
            product.Name = txtName.Text;
            product.Price = float.Parse(txtPrice.Text);
            product.Quantity = int.Parse(udQuantity.Value.ToString());
            var selelectProduct = _products.SingleOrDefault(sp => sp.Id == product.Id);
            if (selelectProduct.Quantity == 0 || product.Quantity > selelectProduct.Quantity)
            {
                MessageBox.Show("Not enough product!!!Please redirect to Order Product page...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (product.Quantity > 0 && product.Quantity <= selelectProduct?.Quantity)
            {
                var existProduct = listAddCart.SingleOrDefault(p => p.Id == product.Id);
                if (existProduct != null)
                {
                    existProduct.Quantity = product.Quantity;
                }
                else
                {
                    listAddCart.Add(product);
                }
                dgvCart.DataSource = listAddCart.Select(x => new
                {
                    x.Id,
                    x.Price,
                    x.Quantity,
                }).OrderBy(x => x.Id).ToList();
            }
            else
            {
                var existProduct = listAddCart.SingleOrDefault(p => p.Id == product.Id);
                if (existProduct != null)
                {
                    listAddCart.Remove(existProduct);
                }
                dgvCart.DataSource = listAddCart.Select(x => new
                {
                    x.Id,
                    x.Price,
                    x.Quantity,
                }).OrderBy(x => x.Id).ToList();
            }
            float sum = 0;
            foreach (Product item in listAddCart)
            {
                sum += (float)(item.Price * item.Quantity);
            }
            lbSaleTotal.Text = sum.ToString();
            Reset();
        }

        private void udDis_ValueChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(lbSaleTotal.Text);
            if (udDis.Value != 0)
            {
                float saleTotal = float.Parse(lbSaleTotal.Text);
                lbTotal.Text = (saleTotal - (saleTotal * (float)udDis.Value / 100)).ToString();
            }
            else lbTotal.Text = sum.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
