using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Payment
{
    public int Id { get; set; }

    public string? PayName { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
