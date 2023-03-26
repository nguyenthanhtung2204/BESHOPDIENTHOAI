using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Permission
{
    public int Id { get; set; }

    public string? Permission1 { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
