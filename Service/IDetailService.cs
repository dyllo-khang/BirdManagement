﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDetailService
    {
        List<AccountDetail> GetAll();
        bool AddAccountDetail(AccountDetail accountDetail);
        bool UpdateAccoutDetail(AccountDetail accountDetail);
    }
}
