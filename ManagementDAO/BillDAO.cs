using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        private BillDAO() { }

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
        }

        public List<Bill> GetAllBill()
        {
            using (var context = new BirdManagementContext())
            {
                return context.Bills.ToList();
            }
        }

        public bool AddBill(Bill bill)
        {
            try
            {
                using(var context = new BirdManagementContext())
                {
                    context.Bills.Add(bill);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
