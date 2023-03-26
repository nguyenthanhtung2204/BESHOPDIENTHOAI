using System;
using System.Collections.Generic;

namespace BESHOPDIENTHOAI.Entity;

public partial class Order
{
    public int Id { get; set; }

    public int? IdCoupon { get; set; }

    public string? Address { get; set; }

    public int Total { get; set; }

    public string? Status { get; set; }

    public bool? Pay { get; set; }

    public int? Freeship { get; set; }

    public string? CreateTime { get; set; }

    public int? IdUser { get; set; }

    public int? IdPayment { get; set; }

    public int? IdNote { get; set; }

    public virtual ICollection<DetailOder> DetailOders { get; } = new List<DetailOder>();

    public virtual Coupon? IdCouponNavigation { get; set; }

    public virtual Node? IdNoteNavigation { get; set; }

    public virtual Payment? IdPaymentNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
