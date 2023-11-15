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
                return context.Products.Where(p => p.Name.Equals(search, StringComparison.OrdinalIgnoreCase)).Include(p => p.TypeId).ToList();
            }
        }
    }
}
