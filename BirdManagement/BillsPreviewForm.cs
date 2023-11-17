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
    public partial class BillsPreviewForm : Form
    {
        IAccountService _accountService;
        IBillService _billService;
        IBillDetailService _billDetailService;
        IDetailService _detailService;
        List<Bill> _listBill;
        List<BillDescription> _listBillDetail;
        List<AccountDetail> _listAccountDetail;
        private int id;
        private int role;
        public BillsPreviewForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _accountService = new AccountService();
            _billService = new BillService();
            _billDetailService = new BillDetailService();
            _detailService = new DetailService();
            _listBill = _billService.GetAllBill();
            _listBillDetail = _billDetailService.GetAll();
            _listAccountDetail = _detailService.GetAll();
            role = (int)_accountService.GetAlll().SingleOrDefault(x => x.Id == id).Role;
        }

        protected void LoadData()
        {
            if (role == 2)
            {
                dgvBill.DataSource = _listBill.Where(x => x.CustomerId == id).OrderByDescending(x => x.DateCheckOut).Select(x => new
                {
                    x.Id,
                    Customer = x.Customer.Name,
                    Cashier = _listAccountDetail.SingleOrDefault(a => a.Id == x.StaffId)?.Name ?? "Online Shopping",
                    x.DateCheckOut,
                    x.Total
                }).OrderByDescending(x => x.DateCheckOut).ToList();
                float sumPrice = 0;
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    float price = float.Parse(row.Cells["Total"].Value.ToString());
                    sumPrice += price;
                }
                float sumProfit = 0;
                lbTotalPrice.Text = $"{sumPrice} VND";
            }
            if(role == 3)
            {
                dgvBill.DataSource = _listBill.Where(x => x.StaffId == id).OrderByDescending(x => x.DateCheckOut).Select(x => new
                {
                    x.Id,
                    Customer = x.Customer.Name,
                    Cashier = _listAccountDetail.SingleOrDefault(a => a.Id == x.StaffId)?.Name ?? "Online Shopping",
                    x.DateCheckOut,
                    x.Total
                }).OrderByDescending(x => x.DateCheckOut).ToList();
                float sumPrice = 0;
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    float price = float.Parse(row.Cells["Total"].Value.ToString());
                    sumPrice += price;
                }
                float sumProfit = 0;
                lbTotalPrice.Text = $"{sumPrice} VND";
            }
        }

        private void BillsPreviewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (role == 2)
            {
                if (dtpFrom.Value.Date > dtpTo.Value.Date)
                {
                    MessageBox.Show("Please choose Date From smaller than Date To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var listSearch = _listBill.Where(x => x.CustomerId == id && x.DateCheckOut >= dtpFrom.Value.Date && x.DateCheckOut <= dtpTo.Value.Date).ToList();
                dgvBill.DataSource = listSearch.Select(x => new
                {
                    x.Id,
                    Customer = x.Customer.Name,
                    Cashier = _listAccountDetail.SingleOrDefault(p => p.Id == x.StaffId)?.Name ?? "Online Shopping",
                    x.DateCheckOut,
                    x.Total
                }).OrderByDescending(x => x.DateCheckOut).ToList();
                float sumPrice = 0;
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    float price = float.Parse(row.Cells["Total"].Value.ToString());
                    sumPrice += price;
                }
                float sumProfit = 0;
                lbTotalPrice.Text = $"{sumPrice} VND";
                dgvBillDetail.DataSource = new List<BillDescription>();
            }
            if(role == 3)
            {
                if (dtpFrom.Value.Date > dtpTo.Value.Date)
                {
                    MessageBox.Show("Please choose Date From smaller than Date To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var listSearch = _listBill.Where(x => x.StaffId == id && x.DateCheckOut >= dtpFrom.Value.Date && x.DateCheckOut <= dtpTo.Value.Date).ToList();
                dgvBill.DataSource = listSearch.Select(x => new
                {
                    x.Id,
                    Customer = x.Customer.Name,
                    Cashier = _listAccountDetail.SingleOrDefault(p => p.Id == x.StaffId)?.Name ?? "Online Shopping",
                    x.DateCheckOut,
                    x.Total
                }).OrderByDescending(x => x.DateCheckOut).ToList();
                float sumPrice = 0;
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    float price = float.Parse(row.Cells["Total"].Value.ToString());
                    sumPrice += price;
                }
                float sumProfit = 0;
                lbTotalPrice.Text = $"{sumPrice} VND";
                dgvBillDetail.DataSource = new List<BillDescription>();
            }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dgvBill.CurrentRow.Cells["Id"].Value.ToString());
                var listDetail = _listBillDetail.Where(bd => bd.BillId == id).ToList();
                dgvBillDetail.DataSource = listDetail.Select(x => new
                {
                    x.BillId,
                    Product = x.Product?.Name,
                    x.Quantity,
                    x.Price,
                }).ToList();
            }
        }
    }
}
