using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Coupon
{
    public int IdCoupon { get; set; }

    public string? Code { get; set; }

    public int? Count { get; set; }

    public int? Promotion { get; set; }

    public string? Describe { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
