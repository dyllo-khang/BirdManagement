using BirdManagement;
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

namespace Bird_Farm_Shop
{
    public partial class AdministratorForm : Form
    {
        private Form FormChild;
        private int id;
        IDetailService _customerService;
        public AdministratorForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _customerService = new DetailService();
            lbName.Text = _customerService.GetAll().SingleOrDefault(p => p.Id == this.id).Name;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #region panelSlide
        private void OpenForm(Form child)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelMain.Controls.Add(child);
            panelMain.Tag = child;
            child.BringToFront();
            lbTitle.Text = child.Text;
            child.Show();
        }
        private void customizeDesigning()
        {

            panelSubUser.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelSubUser.Visible == true)
                panelSubUser.Visible = false;

        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        public void slide(Button btn)
        {
            panelSlide1.BackColor = Color.White;
            panelSlide1.Height = btn.Height;
            panelSlide1.Top = btn.Top;
        }
        public void slide1(Panel panel) 
        { 
        
        }
        #endregion panelSlide
        private void btnProduct_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnProduct);
            OpenForm(new ProductForm());
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnManageOrders);
            OpenForm(new ManageOrdersForm());
        }

        private void btnManageBills_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnManageBills);
            OpenForm(new ManageBillsForm());
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {

            showSubmenu(panelSubUser);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnLogout);
            if (MessageBox.Show("Logout Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnCreateAcc);
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnUpdateAcc);
            OpenForm(new CreateAccountForm());
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnChangePass);
        }

        private void btnActAccount_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            slide(btnActAccount);
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
