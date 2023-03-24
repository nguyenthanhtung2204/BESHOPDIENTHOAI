using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Node
    {
        public Node()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
