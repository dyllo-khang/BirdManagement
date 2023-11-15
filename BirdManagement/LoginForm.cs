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
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        public LoginForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = _accountService.GetAccount(txtUsername.Text, txtPassword.Text);
            if (account != null)
            {
                if (account.Role == 1)
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else if (account.Role == 2)
                {
                    UserForm user = new UserForm(account.Id);
                    user.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your account has been locked, please contact the administrator", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Login failed!! Username or Password is not correct...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
