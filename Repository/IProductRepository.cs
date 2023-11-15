using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll(string search = "");
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
    }
}
