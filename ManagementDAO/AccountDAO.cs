using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }

        public Account GetAccount(string userName, string passWord)
        {
            using(var context = new BirdManagementContext())
            {
                return context.Accounts.FirstOrDefault(p => p.Username.Equals(userName) && p.Password.Equals(passWord));
            }
        }

        public List<Account> GetAlll() 
        {
            using(var context = new BirdManagementContext())
            {
                return context.Accounts.Include(a => a.AccountDetail).ToList();
            }
        }

        public bool AddAcount(Account account)
        {
            try
            {
                using(var context = new BirdManagementContext())
                {
                    context.Accounts.Add(account);
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
