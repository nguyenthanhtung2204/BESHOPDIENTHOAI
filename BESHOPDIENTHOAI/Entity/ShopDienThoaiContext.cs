using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BESHOPDIENTHOAI.Entity;

public partial class ShopDienThoaiContext : DbContext
{
    public ShopDienThoaiContext()
    {
    }

    public ShopDienThoaiContext(DbContextOptions<ShopDienThoaiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<DetailOder> DetailOders { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<Node> Nodes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-NQMPRA5\\SQLEXPRESS;Initial Catalog=ShopDienThoai;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category1)
                .HasMaxLength(50)
                .HasColumnName("category");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Comment1");

            entity.ToTable("Comment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Star)
                .HasMaxLength(50)
                .HasColumnName("star");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment1_Product");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.IdCoupon);

            entity.ToTable("Coupon");

            entity.Property(e => e.IdCoupon).HasColumnName("id_coupon");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Describe)
                .HasMaxLength(50)
                .HasColumnName("describe");
            entity.Property(e => e.Promotion).HasColumnName("promotion");
        });

        modelBuilder.Entity<DetailOder>(entity =>
        {
            entity.ToTable("Detail_Oder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .HasColumnName("name_product");
            entity.Property(e => e.PriceProduct)
                .HasMaxLength(50)
                .HasColumnName("price_product");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .HasColumnName("size");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.DetailOders)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("FK_Detail_Oder_Order");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.DetailOders)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Detail_Oder_Product");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.ToTable("Favorite");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Favorite_Product");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_Favorite_User");
        });

        modelBuilder.Entity<Node>(entity =>
        {
            entity.ToTable("Node");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Order_1");

            entity.ToTable("Order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(50)
                .HasColumnName("create_time");
            entity.Property(e => e.Freeship).HasColumnName("freeship");
            entity.Property(e => e.IdCoupon).HasColumnName("id_coupon");
            entity.Property(e => e.IdNote).HasColumnName("id_note");
            entity.Property(e => e.IdPayment).HasColumnName("id_payment");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Pay).HasColumnName("pay");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.IdCouponNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdCoupon)
                .HasConstraintName("FK_Order_Coupon");

            entity.HasOne(d => d.IdNoteNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdNote)
                .HasConstraintName("FK_Order_Node");

            entity.HasOne(d => d.IdPaymentNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdPayment)
                .HasConstraintName("FK_Order_Payment");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_Order_User");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PayName)
                .HasMaxLength(50)
                .HasColumnName("pay_name");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Permission1)
                .HasMaxLength(50)
                .HasColumnName("permission");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Describe)
                .HasMaxLength(50)
                .HasColumnName("describe");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IdCatetory).HasColumnName("id_catetory");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .HasColumnName("image");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .HasColumnName("name_product");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.PriceProduct)
                .HasMaxLength(50)
                .HasColumnName("price_product");

            entity.HasOne(d => d.IdCatetoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCatetory)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSale);

            entity.ToTable("Sale");

            entity.Property(e => e.IdSale).HasColumnName("id_sale");
            entity.Property(e => e.Describe).HasColumnName("describe");
            entity.Property(e => e.End)
                .HasColumnType("datetime")
                .HasColumnName("end");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.Promotion).HasColumnName("promotion");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Sale_Product");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.IdPermission).HasColumnName("id_permission");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.IdPermissionNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdPermission)
                .HasConstraintName("FK_User_Permission");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
