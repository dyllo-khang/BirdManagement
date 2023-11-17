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
    public partial class ChangePasswordForm : Form
    {
        private int id;
        IDetailService _detailService;
        IAccountService _accountService;
        List<Account> _accounts;
        public ChangePasswordForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _detailService = new DetailService();
            _accountService = new AccountService();
            lbName.Text = _detailService.GetAll().SingleOrDefault(p => p.Id == this.id).Name;
            _accounts = _accountService.GetAlll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var account = _accounts.SingleOrDefault(a => a.Id == this.id);
            if (account != null)
            {
                if (!account.Password.Equals(txtCurPass.Text))
                {
                    MessageBox.Show("Current password not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string resultNewPassword = ValidateHelper.ValidatePassword(txtNPass.Text);
                if (resultNewPassword != null)
                {
                    MessageBox.Show(resultNewPassword, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string newPass = txtNPass.Text;
                string rePass = txtRePass2.Text;
                if (!rePass.Equals(newPass))
                {
                    MessageBox.Show("Re-type new password different new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.Password = newPass;
                if (_accountService.UpdateAccount(account))
                {
                    MessageBox.Show("Change password successfully!!!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Change password failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
