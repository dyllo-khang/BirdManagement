using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BillDetailService : IBillDetailService
    {
        private IBillDetailRepository _billDetailRepository;
        public BillDetailService()
        {
            _billDetailRepository = new BillDetailRepository();
        }
        public bool AddBillDetail(BillDescription billDetail) => _billDetailRepository.AddBillDetail(billDetail);
    }
}
