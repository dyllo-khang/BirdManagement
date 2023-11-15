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
    public partial class ProductForm : Form
    {
        private IProductService _productService;
        private ITypeService _typeService;
        public List<Product> _products;
        public List<TypeProduct> _types;
        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _typeService = new TypeService();
            _products = _productService.GetAll();
            _types = _typeService.GetAll();
            txtID.Enabled = false;
        }

        private void LoadComboBox()
        {
            cbxType.DataSource = _types;
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dgvProduct.DataSource = _products.Select(x => new
            {
                x.Id,
                x.Name,
                x.Price,
                x.ImportPrice,
                x.Quantity,
                x.TypeId,
                Type = x.Type?.Name,
            }).ToList();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtImPrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            udQuantity.Value = int.Parse(dgvProduct.CurrentRow.Cells[4].Value.ToString());
            int typeID = int.Parse(dgvProduct.CurrentRow.Cells[5].Value.ToString());
            cbxType.SelectedIndex = _types.IndexOf(_types.SingleOrDefault(t => t.Id == typeID));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int typeID = int.Parse(cbxType.SelectedValue.ToString());
            int quantity = int.Parse(udQuantity.Value.ToString());
            float price = float.Parse(txtPrice.Text);
            float importPrice = float.Parse(txtImPrice.Text);
            var product = _productService.GetAll().FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && p.TypeId == typeID);
            if (product != null)
            {
                product.ImportPrice = importPrice;
                product.Price = price;
                product.Quantity += quantity;
                DialogResult result = MessageBox.Show("Do you want to add product?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_productService.UpdateProduct(product))
                    {
                        MessageBox.Show("Add successfully !!!", "Notification", MessageBoxButtons.OK);
                        _products = _productService.GetAll();
                        ProductForm_Load(this, EventArgs.Empty);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Add failed !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else return;
            }
            else
            {
                product = new Product();
                product.Name = name;
                product.Price = price;
                product.ImportPrice = importPrice;
                product.Quantity = quantity;
                product.TypeId = typeID;
                DialogResult result = MessageBox.Show("Do you want to add product?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_productService.AddProduct(product))
                    {
                        MessageBox.Show("Add successfully !!!", "Notification", MessageBoxButtons.OK);
                        _products = _productService.GetAll();
                        ProductForm_Load(this, EventArgs.Empty);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Add failed !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(txtID.Text);
            product.Name = txtName.Text;
            product.Price = float.Parse(txtPrice.Text);
            product.ImportPrice = float.Parse(txtImPrice.Text);
            product.Quantity = int.Parse(udQuantity.Value.ToString());
            product.TypeId = int.Parse(cbxType.SelectedValue.ToString());
            DialogResult result = MessageBox.Show("Are you sure to Update", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_productService.UpdateProduct(product))
                {
                    MessageBox.Show("Update successfully!!!", "Notification", MessageBoxButtons.OK);
                    _products = _productService.GetAll();
                    ProductForm_Load(this, EventArgs.Empty);
                    return;
                }
                else
                {
                    MessageBox.Show("Update failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else return;
        }
    }
}
