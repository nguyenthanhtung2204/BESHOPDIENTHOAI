using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Models
{
    public partial class Permission
    {
        public Permission()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Permission1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
