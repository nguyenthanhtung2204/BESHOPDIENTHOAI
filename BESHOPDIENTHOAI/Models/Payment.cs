using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? PayName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
