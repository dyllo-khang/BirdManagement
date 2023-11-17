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
        IBillService _billService;
        IBillDetailService _billDetailService;
        List<Product> _products;
        private int id;
        public NewTransactionForm(int id)
        {
            InitializeComponent();
            txtPrice.Enabled = false;
            _productService = new ProductService();
            _billService = new BillService();
            _billDetailService = new BillDetailService();
            _products = _productService.GetAll();
            this.id = id;
        }

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void LoadData()
        {
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.DataSource = _products.Select(x => new
            {
                No = x.Id,
                x.Name,
                x.Price,
                x.Quantity,
                Type = x.Type?.Name,
                Inventory = x.Quantity > 0 ? "Stocking" : "Sold Out"
            }).ToList();
        }

        protected void Reset()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            udQuantity.Value = 1;
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
                return;
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
            foreach (Product item in listAddCart.OrderBy(p => p.Id))
            {
                sum += (float)(item.Price * item.Quantity);
            }
            lbSaleTotal.Text = sum.ToString();
            Reset();
            udDis_ValueChanged(this, e);
        }

        private void udDis_ValueChanged(object sender, EventArgs e)
        {
            float sum = float.Parse(lbSaleTotal.Text);
            if (udDis.Value != 0)
            {
                decimal saleTotal = decimal.Parse(lbSaleTotal.Text);
                lbTotal.Text = (saleTotal - (saleTotal * udDis.Value / 100)).ToString();
            }
            else lbTotal.Text = sum.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to purchase?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool addBillDetail = false;
                decimal discount = udDis.Value;
                Bill bill = new Bill();
                bill.CustomerId = this.id;
                bill.DateCheckOut = DateTime.Now;
                bill.Total = float.Parse(lbTotal.Text);
                bill.Status = 1;
                bill.Checked = 1;
                bill.StaffId = 0;
                bool addBill =  _billService.AddBill(bill);
                foreach(DataGridViewRow row in dgvCart.Rows)
                {
                    BillDescription billDetail = new BillDescription();
                    billDetail.ProductId = int.Parse(row.Cells["Id"].Value.ToString());
                    billDetail.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    billDetail.BillId = bill.Id;
                    var product = _productService.GetProductByID(billDetail.ProductId);
                    if (product != null)
                    {
                        billDetail.ImportPrice = product.ImportPrice;
                        billDetail.Price = discount == 0 ? product.Price : (product.Price - (product.Price * (float)discount / 100));
                    }
                    _billDetailService.AddBillDetail(billDetail);
                    product.Quantity -= billDetail.Quantity;
                    addBillDetail = _productService.UpdateProduct(product);
                    if(!addBillDetail)
                    {
                        break;
                    }
                }
                _products = _productService.GetAll();
                LoadData();
                listAddCart = new List<Product>();
                dgvCart.DataSource = listAddCart;
                Reset();
                if(addBill && addBillDetail)
                {
                    MessageBox.Show("Purchase succesfully! Thank you...", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("An error occurred during processing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string seacrch = txtSearch.Text;
            _products = _productService.GetAll(seacrch);
            LoadData();
        }
    }
}
