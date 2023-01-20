using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Unidad4.Models;

public partial class MvcContext : DbContext
{
    public MvcContext()
    {
    }

    public MvcContext(DbContextOptions<MvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //   => optionsBuilder.UseSqlServer("Server=DESKTOP-3GBRQLA;Database=MVC;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240C91A429D5");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnName("idCategoria");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("date")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Identificador).HasColumnName("identificador");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__07F4A132849B8AE0");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("idProducto");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("date")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCategoria)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("idCategoria");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
