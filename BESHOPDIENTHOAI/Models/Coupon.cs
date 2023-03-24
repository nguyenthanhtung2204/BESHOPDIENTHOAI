using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            Orders = new HashSet<Order>();
        }

        public int IdCoupon { get; set; }
        public string? Code { get; set; }
        public int? Count { get; set; }
        public int? Promotion { get; set; }
        public string? Describe { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
