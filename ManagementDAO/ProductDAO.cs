using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get 
            { 
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }

        public List<Product> GetAll(string search = "")
        {
            using(var context = new BirdManagementContext())
            {
                return context.Products.Include(p => p.Type).ToList().Where(p => p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();


            }
        }

        public bool AddProduct(Product product)
        {
            try
            {
                using(var context = new BirdManagementContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                using(var context = new BirdManagementContext())
                {
                    var existedProduct = context.Products.Find(product.Id);
                    if (existedProduct != null)
                    {
                        context.Entry(existedProduct).CurrentValues.SetValues(product);
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
