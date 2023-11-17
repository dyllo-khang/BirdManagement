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
        public ChangePasswordForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _detailService = new DetailService();
            lbName.Text = _detailService.GetAll().SingleOrDefault(p => p.Id == this.id).Name;
        }
    }
}
