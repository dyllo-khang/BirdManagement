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
    }
}
