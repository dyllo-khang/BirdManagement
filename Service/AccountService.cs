using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService() 
        { 
            _accountRepository = new AccountRepository();
        }

        public bool AddAcount(Account account) => _accountRepository.AddAcount(account);

        public Account GetAccount(string username, string passWord) => _accountRepository.GetAccount(username, passWord);

        public List<Account> GetAlll() => _accountRepository.GetAlll();

        public bool UpdateAccount(Account account) => _accountRepository.UpdateAccount(account);
    }
}
