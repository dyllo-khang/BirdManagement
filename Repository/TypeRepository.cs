using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TypeRepository : ITypeRepository
    {
        public List<TypeProduct> GetAll() => TypeDAO.Instance.GetAll();
    }
}
