using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class DetailDAO
    {
        private static DetailDAO instance;
        private DetailDAO() { }
        public static DetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetailDAO();
                }
                return instance;
            }
        }

        public List<AccountDetail> GetAll()
        {
            using(var context = new BirdManagementContext())
            {
                return context.AccountDetails.ToList();
            }
        }

        public bool AddAccountDetail(AccountDetail accountDetail)
        {
            try
            {
                using(var context = new BirdManagementContext())
                {
                    context.AccountDetails.Add(accountDetail);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAccoutDetail(AccountDetail accountDetail)
        {
            try
            {
                using( var context = new BirdManagementContext())
                {
                    var existingAccount = context.AccountDetails.Find(accountDetail.Id);
                    if (existingAccount != null)
                    {
                        context.Entry(existingAccount).CurrentValues.SetValues(accountDetail);
                        context.SaveChanges();
                    }
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
