using BusinessObject.Models;
using Repository;
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
    public partial class AccountPropertiesForm : Form
    {
        public event EventHandler<Account> DataUpdate;
        private int id;
        IDetailService _detailService;
        IAccountService _accountService;
        List<Account> _accounts;
        public AccountPropertiesForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _detailService = new DetailService();
            _accountService = new AccountService();
            _accounts = _accountService.GetAlll();
            txtFullname.Text = _detailService.GetAll().SingleOrDefault(p => p.Id == this.id).Name;
            txtFullname.Enabled = false;
            LoadCbRole();
            LoadCbStatus();
        }

        protected void LoadCbRole()
        {
            cbRole.Items.Add("User");
            cbRole.Items.Add("Staff");
            cbRole.SelectedItem = "Staff";
        }

        protected void LoadCbStatus()
        {
            cbActive.Items.Add("Active");
            cbActive.Items.Add("Disable");
            cbActive.SelectedItem = "Active";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var account = _accounts.SingleOrDefault(a => a.Id == this.id);
            account.Role = cbRole.SelectedItem.Equals("Staff") ? 3 : 2;
            account.Actice = cbActive.SelectedItem.Equals("Active") ? 1 : 0;
            DataUpdate.Invoke(this, account);
            this.Close();
        }
    }
}
