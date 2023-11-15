using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class TypeDAO
    {
        private static TypeDAO instance;
        private TypeDAO() { }
        public static TypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TypeDAO();
                }
                return instance;
            }
        }
        public List<TypeProduct> GetAll()
        {
            using(var context = new BirdManagementContext())
            {
                return context.TypeProducts.ToList();
            }
        }
    }
}
