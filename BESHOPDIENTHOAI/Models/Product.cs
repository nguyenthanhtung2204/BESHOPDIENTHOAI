using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            DetailOders = new HashSet<DetailOder>();
            Favorites = new HashSet<Favorite>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string? NameProduct { get; set; }
        public string? PriceProduct { get; set; }
        public string? Image { get; set; }
        public string? Describe { get; set; }
        public string? Gender { get; set; }
        public int? Number { get; set; }
        public int? IdCatetory { get; set; }

        public virtual Category? IdCatetoryNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<DetailOder> DetailOders { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
