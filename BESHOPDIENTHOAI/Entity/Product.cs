using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Product
{
    public int Id { get; set; }

    public string? NameProduct { get; set; }

    public string? PriceProduct { get; set; }

    public string? Image { get; set; }

    public string? Describe { get; set; }

    public string? Gender { get; set; }

    public int? Number { get; set; }

    public int? IdCatetory { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<DetailOder> DetailOders { get; } = new List<DetailOder>();

    public virtual ICollection<Favorite> Favorites { get; } = new List<Favorite>();

    public virtual Category? IdCatetoryNavigation { get; set; }

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();
}
