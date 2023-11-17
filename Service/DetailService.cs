using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DetailService : IDetailService
    {
        private IDetailRepository detailRepository;
        public DetailService()
        {
            detailRepository = new DetailRepository();
        }

        public bool AddAccountDetail(AccountDetail accountDetail) => detailRepository.AddAccountDetail(accountDetail);

        public List<AccountDetail> GetAll() => detailRepository.GetAll();
    }
}
