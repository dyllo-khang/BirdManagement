using BirdManagement;
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
        private IDetailService _detailservice;
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _detailservice = new DetailService();
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
                if (account.Actice == 1)
                {
                    if (account.Role == 1)
                    {
                        string name = _detailservice.GetAll().SingleOrDefault(d => d.Id == account.Id).Name;
                        MessageBox.Show($"Wellcome to {name}", "Access Granted", MessageBoxButtons.OK);
                        AdministratorForm administratorForm = new AdministratorForm(account.Id);
                        administratorForm.Show();
                        this.Hide();
                    }
                    if (account.Role == 2)
                    {
                        string name = _detailservice.GetAll().SingleOrDefault(d => d.Id == account.Id).Name;
                        MessageBox.Show($"Wellcome to {name}", "Access Granted", MessageBoxButtons.OK);
                        MainForm userForm = new MainForm(account.Id);
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your account has been locked, please contact administrator!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Login failed!! Username or Password is not correct...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}
