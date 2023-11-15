using BirdManagement;
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
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnManageBills_Click(object sender, EventArgs e)
        {

        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }
    }
}
