using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pr_4.Models;

public partial class SubsystemPartnersContext : DbContext
{
    public SubsystemPartnersContext()
    {
    }

    public SubsystemPartnersContext(DbContextOptions<SubsystemPartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TypeOfProduct> TypeOfProducts { get; set; }

    public virtual DbSet<TypePartner> TypePartners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Subsystem partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_pkey");

            entity.Property(e => e.Inn).HasColumnName("INN");

            entity.HasOne(d => d.IdTypePartnerNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypePartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idtypePartner");
        });

        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("Partners_Products");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_IdPartner");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_IdProduct");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.MinCostForPartner).HasColumnType("money");

            entity.HasOne(d => d.IdTypeOfProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_IdTypeOfProduct");
        });

        modelBuilder.Entity<TypeOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfProducts_pkey");

            entity.Property(e => e.TypeOfProduct1).HasColumnName("TypeOfProduct");
        });

        modelBuilder.Entity<TypePartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypePartners_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
