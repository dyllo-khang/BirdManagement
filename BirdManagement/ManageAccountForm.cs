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
    public partial class ManageAccountForm : Form
    {
        IAccountService _accountService;
        IDetailService _detailService;
        List<Account> _accounts;
        List<AccountDetail> _listAccDetail;
        Account account;
        public ManageAccountForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _detailService = new DetailService();
            _accounts = _accountService.GetAlll();
            _listAccDetail = _detailService.GetAll();
            LoadComboBox();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                AccountPropertiesForm accProperties = new AccountPropertiesForm(account.Id);
                accProperties.DataUpdate += (s, data) =>
                {
                    if (_accountService.UpdateAccount(data))
                    {
                        MessageBox.Show("Update successfully!!!", "Notification", MessageBoxButtons.OK);
                        _accounts = _accountService.GetAlll();
                        LoadData();
                    }
                    else
                        MessageBox.Show("Update failed....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                accProperties.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one row!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void LoadData()
        {
            dgvAccount.DataSource = _accounts.Where(a => a.Role == 2 || a.Role == 3).Select(x => new
            {
                x.AccountDetail.Id,
                x.AccountDetail.Name,
                x.AccountDetail.Address,
                x.AccountDetail.Email,
                x.AccountDetail.Phone,
                Role = x.Role == 2 ? "User" : "Staff",
                Status = x.Actice == 1 ? "Active" : "Blocked"
            }).ToList();
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected void LoadComboBox()
        {
            cbRole.Items.Add("User");
            cbRole.Items.Add("Staff");
            cbRole.SelectedItem = "Staff";
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvAccount.CurrentRow.Cells["Id"].Value.ToString());
            account = _accounts.SingleOrDefault(x => x.Id == id);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var accountExist = _accounts.SingleOrDefault(a => a.Username.Equals(txtUsername.Text));
            if (accountExist != null)
            {
                MessageBox.Show("Username existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                accountExist = new Account();
                string resultUsername = ValidateHelper.ValidateUserName(txtUsername.Text);
                if (resultUsername != null)
                {
                    MessageBox.Show(resultUsername, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                accountExist.Username = txtUsername.Text;
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
                accountExist.Password = password;
                accountExist.Role = cbRole.SelectedItem.Equals("Useer") ? 2 : 3;
                accountExist.Actice = 1;
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
                bool addAccount = _accountService.AddAcount(accountExist);
                accountDetail.Id = accountExist.Id;
                bool addAccountDetail = _detailService.AddAccountDetail(accountDetail);
                if (addAccount && addAccountDetail)
                {
                    MessageBox.Show("Register successfully", "Notification", MessageBoxButtons.OK);
                    _accounts = _accountService.GetAlll();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Register failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
