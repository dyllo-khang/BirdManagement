using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDescriptions = new HashSet<BillDescription>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public double? ImportPrice { get; set; }
        public int? Quantity { get; set; }
        public int? TypeId { get; set; }

        public virtual TypeProduct? Type { get; set; }
        public virtual ICollection<BillDescription> BillDescriptions { get; set; }
    }
}
