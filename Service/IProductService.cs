using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService
    {
        List<Product> GetAll(string search = "");
        Product GetProductByID(int? id);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
    }
}
