using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Sale
    {
        public int IdSale { get; set; }
        public int? Promotion { get; set; }
        public int? Describe { get; set; }
        public bool? Status { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
