using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Node
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
