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
    public partial class BillsPreviewForm : Form
    {
        private int id;
        IAccountService _accountService;
        IBillService _billService;
        IBillDetailService _billDetailService;
        IDetailService _detailService;
        List<Bill> _listBill;
        List<BillDescription> _listBillDetail;
        List<AccountDetail> _listAccountDetail;
        public BillsPreviewForm(int id)
        {
            InitializeComponent();
            this.id = id;
            _accountService = new AccountService();
            _billService = new BillService();
            _billDetailService = new BillDetailService();
            _detailService = new DetailService();
        }
    }
}
