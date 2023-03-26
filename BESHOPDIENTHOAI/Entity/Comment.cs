using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Comment
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public string? Star { get; set; }

    public int? IdUser { get; set; }

    public int IdProduct { get; set; }

    public virtual Product IdProductNavigation { get; set; } = null!;
}
