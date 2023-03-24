using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class DetailOder
    {
        public int Id { get; set; }
        public string? PriceProduct { get; set; }
        public string? NameProduct { get; set; }
        public int? Count { get; set; }
        public string? Size { get; set; }
        public int? IdOrder { get; set; }
        public int? IdProduct { get; set; }

        public virtual Order? IdOrderNavigation { get; set; }
        public virtual Product? IdProductNavigation { get; set; }
    }
}
