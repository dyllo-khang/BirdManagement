using BusinessObject;
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
    public partial class UpdateInfoForm : Form
    {
        private int id;
        IAccountService _accountService;
        IDetailService _detailService;
        List<Account> _accounts;
        List<AccountDetail> _listAccDetail;
        public UpdateInfoForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _accountService = new AccountService();
            _detailService = new DetailService();
            _accounts = _accountService.GetAlll();
            _listAccDetail = _detailService.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var detailAccout = _listAccDetail.SingleOrDefault(p => p.Id == id);
            string resultFullname = ValidateHelper.ValidateFullName(txtName.Text);
            if (resultFullname != null)
            {
                MessageBox.Show(resultFullname, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            detailAccout.Name = txtName.Text;
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address can not be null...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            detailAccout.Address = txtAddress.Text;
            var addPhoneExist = _listAccDetail.SingleOrDefault(e => e.Phone.Equals(txtPhone.Text) && e.Id != id);
            if (addPhoneExist != null)
            {
                MessageBox.Show("Phone is registed by other", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string resultPhone = ValidateHelper.ValidatePhone(txtPhone.Text);
            if (resultPhone != null)
            {
                MessageBox.Show(resultPhone, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            detailAccout.Phone = txtPhone.Text;
            var addEmailExist = _listAccDetail.SingleOrDefault(e => e.Email.Equals(txtEmail.Text) && e.Id != id);
            if (addEmailExist != null)
            {
                MessageBox.Show("Email is registed by other", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string resultEmail = ValidateHelper.ValidateEmail(txtEmail.Text);
            if (resultEmail != null)
            {
                MessageBox.Show(resultEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            detailAccout.Email = txtEmail.Text;
            if(_detailService.UpdateAccoutDetail(detailAccout))
            {
                MessageBox.Show("Update successfully", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
