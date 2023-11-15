using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class BillDescription
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? ImportPrice { get; set; }
        public double? Price { get; set; }

        public virtual Bill Bill { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
