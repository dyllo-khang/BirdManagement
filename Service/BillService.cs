using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BillService : IBillService
    {
        private IBillRepository _billRepository;
        public BillService()
        {
            _billRepository = new BillRepository();
        }
        public bool AddBill(Bill bill)  => _billRepository.AddBill(bill);
        public List<Bill> GetAllBill() => _billRepository.GetAllBill();
    }
}
