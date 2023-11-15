using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? Role { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
