using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Probnik.Models;

namespace Probnik.Context;

public partial class KlimBaseContext : DbContext
{
    public KlimBaseContext()
    {
    }

    public KlimBaseContext(DbContextOptions<KlimBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Manufacture> Manufactures { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=89.110.53.87; Database=klim_base; Username=klim; Port=5522; Password=nissan");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manufacture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufactures_pk");

            entity.ToTable("manufactures", "Probnik");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ManufacturName)
                .HasColumnType("character varying")
                .HasColumnName("manufactur_name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pk");

            entity.ToTable("products", "Probnik");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Images)
                .HasColumnType("character varying")
                .HasColumnName("images");
            entity.Property(e => e.ManufacturesId).HasColumnName("manufactures_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductDescription)
                .HasColumnType("character varying")
                .HasColumnName("product_description");
            entity.Property(e => e.ProductName)
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.Sale).HasColumnName("sale");

            entity.HasOne(d => d.Manufactures).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufacturesId)
                .HasConstraintName("products_manufactures_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
