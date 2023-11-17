using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BillRepository : IBillRepository
    {
        public bool AddBill(Bill bill) => BillDAO.Instance.AddBill(bill);

        public List<Bill> GetAllBill() => BillDAO.Instance.GetAllBill();
    }
}
