using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public bool AddProduct(Product product) => _productRepository.AddProduct(product);

        public List<Product> GetAll(string search = "") => _productRepository.GetAll(search);

        public bool UpdateProduct(Product product) => _productRepository.UpdateProduct(product);

    }
}
