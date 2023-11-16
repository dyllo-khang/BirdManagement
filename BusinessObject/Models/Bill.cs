using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDescriptions = new HashSet<BillDescription>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public double? Total { get; set; }
        public int? Status { get; set; }
        public int? Checked { get; set; }
        public int? StaffId { get; set; }

        public virtual AccountDetail Customer { get; set; } = null!;
        public virtual ICollection<BillDescription> BillDescriptions { get; set; }
    }
}
