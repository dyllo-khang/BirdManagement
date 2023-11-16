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
        private IDetailRepository _customerRepository;
        public DetailService()
        {
            _customerRepository = new DetailRepository();
        }
        public List<AccountDetail> GetAll() => _customerRepository.GetAll();
            }
}
