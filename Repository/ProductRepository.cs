using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public List<Product> GetAll(string search = "") => ProductDAO.Instance.GetAll(search);

        public Product GetProductByID(int? id) => ProductDAO.Instance.GetProductByID(id);

        public bool UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
