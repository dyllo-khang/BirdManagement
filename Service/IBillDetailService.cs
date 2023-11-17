using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IBillDetailService
    {
        bool AddBillDetail(BillDescription billDetail);
        List<BillDescription> GetAll();
    }
}
