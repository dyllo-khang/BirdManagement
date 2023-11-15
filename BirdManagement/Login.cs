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

namespace Bird_Farm_Shop
{
    public partial class Login : Form
    {
        private IAccountService _accountService;
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = _accountService.GetAccount(txtUsername.Text, txtPassword.Text);
            if (account != null)
            {
                if (account.Role == 1)
                {
                    AdministratorForm administratorForm = new AdministratorForm();
                    administratorForm.Show();
                    this.Hide();
                }
                if (account.Role == 2)
                {

                }
            }
        }
    }
}
