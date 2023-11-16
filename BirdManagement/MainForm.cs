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
    public partial class MainForm : Form
    {
        private Form FormChild;
        public MainForm()
        {
            InitializeComponent();
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
            child.Show();
        }

        public void slide(Button btn)
        {
            panelSlide1.BackColor = Color.White;
            panelSlide1.Height = btn.Height;
            panelSlide1.Top = btn.Top;
        }
        #endregion panelSlide

        private void btnNTran_Click(object sender, EventArgs e)
        {
            slide(btnNTran);
            OpenForm(new NewTransactionForm());
        }

        private void btnOProduct_Click(object sender, EventArgs e)
        {
            slide(btnOProduct);
            OpenForm(new OrderProductForm());
        }

        private void btnBPreview_Click(object sender, EventArgs e)
        {
            slide(btnBPreview);
            OpenForm(new BillsPreviewForm());
        }

        private void btnOPreview_Click(object sender, EventArgs e)
        {
            slide(btnOPreview);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            slide(btnChangePassword);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss tt dd/MM/yyyy");
        }
    }
}
