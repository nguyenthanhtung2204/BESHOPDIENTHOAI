using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public int? IdPermission { get; set; }

    public virtual ICollection<Favorite> Favorites { get; } = new List<Favorite>();

    public virtual Permission? IdPermissionNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
