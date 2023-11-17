using BusinessObject.Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdManagement
{
    public partial class ManageBillsForm : Form
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
        public ManageBillsForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _accountService = new AccountService();
            _billService = new BillService();
            _billDetailService = new BillDetailService();
            _detailService = new DetailService();
            role = (int)_accountService.GetAlll().SingleOrDefault(x => x.Id == id).Role;
            _listBill = _billService.GetAllBill();
            _listBillDetail = _billDetailService.GetAll();
            _listAccountDetail = _detailService.GetAll();
        }

        private void ManageBillsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void LoadData()
        {
            if (role == 1)
            {
                dgvBill.DataSource = _listBill.Select(x => new
                {
                    x.Id,
                    Customer = x.Customer.Name,
                    Cashier = _listAccountDetail.SingleOrDefault(a => a.Id == x.StaffId)?.Name ?? "Online Shopping",
                    x.DateCheckOut,
                    x.Total
                }).ToList();
                float sumPrice = 0;
                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    float price = float.Parse(row.Cells["Total"].Value.ToString());
                    sumPrice += price;
                }
                float sumProfit = 0;
                lbTotalPrice.Text = $"{sumPrice} VND";
                foreach (BillDescription billDetail in _listBillDetail)
                {
                    sumProfit = sumProfit + (float)((float)(billDetail.Price - billDetail.ImportPrice) * billDetail.Quantity);
                }
                lbTotalProfit.Text = $"{sumProfit} VND";
            }
            if (role == 3)
            {

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
                    x.ImportPrice,
                    Profit = (x.Price - x.ImportPrice) * x.Quantity
                }).ToList();
            }
        }
    }
}
