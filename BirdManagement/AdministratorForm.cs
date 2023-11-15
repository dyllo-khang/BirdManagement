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
    public partial class Administrator_For_ : Form
    {
        public Administrator_For_()
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

        public void slide(Button button)
        {
            panel4.BackColor = Color.White;
            panel4.Height = button.Height;
            panel4.Top = button.Top;
        }

        

        private void btnProduct_Click(object sender, EventArgs e)
        {
            slide(btnProduct);
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            slide(btnManageOrders);
        }

        private void btnManageBills_Click(object sender, EventArgs e)
        {
            slide(btnManageBills);
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            slide(btnUserSetting);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }
    }
}
