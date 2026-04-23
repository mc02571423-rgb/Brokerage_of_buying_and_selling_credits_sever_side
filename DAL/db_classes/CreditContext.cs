using Microsoft.EntityFrameworkCore;

namespace DAL.db_classes;

public partial class CreditContext : DbContext
{
    public CreditContext()
    {
    }

    public CreditContext(DbContextOptions<CreditContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriesTbl> CategoriesTbls { get; set; }

    public virtual DbSet<StoresTbl> StoresTbls { get; set; }

    public virtual DbSet<UsersTbl> UsersTbls { get; set; }

    public virtual DbSet<ZikuyTbl> ZikuyTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=credit;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriesTbl>(entity =>
        {
            entity.HasKey(e => e.CategoryCode).HasName("PK__Categori__371BA954ECA8F20E");

            entity.ToTable("Categories_tbl");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CategoryName).HasMaxLength(20);
        });

        modelBuilder.Entity<StoresTbl>(entity =>
        {
            entity.HasKey(e => e.StoreCode).HasName("PK__stores_t__02A384F9908F787D");

            entity.ToTable("stores_tbl");

            entity.Property(e => e.StoreCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.StoreAdress).HasMaxLength(20);
            entity.Property(e => e.StoreImage).HasMaxLength(40);
            entity.Property(e => e.StoreLogo).HasMaxLength(40);
            entity.Property(e => e.StoreName).HasMaxLength(20);

            entity.HasOne(d => d.CategoryCodeNavigation).WithMany(p => p.StoresTbls)
                .HasForeignKey(d => d.CategoryCode)
                .HasConstraintName("FK__stores_tb__Categ__398D8EEE");
        });

        modelBuilder.Entity<UsersTbl>(entity =>
        {
            entity.HasKey(e => e.Tz).HasName("PK__Users_tb__3214E45117C20C3C");

            entity.ToTable("Users_tbl");

            entity.Property(e => e.Tz)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.BankNum)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheshbonNum)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SnifNum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(20);
            entity.Property(e => e.UserSisma).HasMaxLength(20);
        });

        modelBuilder.Entity<ZikuyTbl>(entity =>
        {
            entity.HasKey(e => e.CreditCode).HasName("PK__Zikuy_tb__69177F790764D4A6");

            entity.ToTable("Zikuy_tbl");

            entity.Property(e => e.CreditCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OwnerTz)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Picture).HasMaxLength(40);
            entity.Property(e => e.StoreCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UseBefore).HasColumnType("date");

            entity.HasOne(d => d.StoreCodeNavigation).WithMany(p => p.ZikuyTbls)
                .HasForeignKey(d => d.StoreCode)
                .HasConstraintName("FK__Zikuy_tbl__Store__4AB81AF0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
