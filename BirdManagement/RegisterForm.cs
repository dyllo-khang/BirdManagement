using Bird_Farm_Shop;
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
    public partial class RegisterForm : Form
    {
        IAccountService _accountService;
        IDetailService _detailService;
        List<Account> _accounts;
        List<AccountDetail> _listAccDetail;
        public RegisterForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _detailService = new DetailService();
            _accounts = _accountService.GetAlll();
            _listAccDetail = _detailService.GetAll();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            var account = _accounts.SingleOrDefault(a => a.Username.Equals(txtUsername.Text));
            if (account != null)
            {
                MessageBox.Show("Username existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account = new Account();
                string resultUsername = ValidateHelper.ValidateUserName(txtUsername.Text);
                if (resultUsername != null)
                {
                    MessageBox.Show(resultUsername, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.Username = txtUsername.Text;
                string resultPassword = ValidateHelper.ValidatePassword(txtPassword.Text);
                if (resultPassword != null)
                {
                    MessageBox.Show(resultPassword, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string password = txtPassword.Text;
                string rePassword = txtRePassword.Text;
                if (!rePassword.Equals(password))
                {
                    MessageBox.Show("Re-type password different password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.Password = password;
                account.Role = 2;
                account.Actice = 1;
                AccountDetail accountDetail = new AccountDetail();
                string resultFullname = ValidateHelper.ValidateFullName(txtFullName.Text);
                if (resultFullname != null)
                {
                    MessageBox.Show(resultFullname, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                accountDetail.Name = txtFullName.Text;
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Address can not be null...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                accountDetail.Address = txtAddress.Text;
                var addEmailExist = _listAccDetail.SingleOrDefault(e => e.Email.Equals(txtEmail.Text));
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
                accountDetail.Email = txtEmail.Text;
                var addPhoneExist = _listAccDetail.SingleOrDefault(e => e.Phone.Equals(txtPhone.Text));
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
                accountDetail.Phone = txtPhone.Text;
                bool addAccount = _accountService.AddAcount(account);
                accountDetail.Id = account.Id;
                bool addAccountDetail = _detailService.AddAccountDetail(accountDetail);
                if (addAccount && addAccountDetail)
                {
                    MessageBox.Show("Register successfully", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Register failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
