using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BillDetailRepository : IBillDetailRepository
    {
        public bool AddBillDetail(BillDescription billDetail) => BillDetailDAO.Instance.AddBillDetail(billDetail);

        public List<BillDescription> GetAll() => BillDetailDAO.Instance.GetAll();
    }
}
