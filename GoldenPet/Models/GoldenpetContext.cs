using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GoldenPet.Models;

public partial class GoldenpetContext : DbContext
{
    public GoldenpetContext()
    {
    }

    public GoldenpetContext(DbContextOptions<GoldenpetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbMenu> TbMenus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=goldenpet;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=FalseData Source=MSI\\SQLEXPRESS;Initial Catalog=goldenpet;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_Menu__3213E83F1A16C5A2");

            entity.ToTable("tb_Menu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datebegin)
                .HasColumnType("smalldatetime")
                .HasColumnName("datebegin");
            entity.Property(e => e.Hide).HasColumnName("hide");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.Meta).HasColumnName("meta");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
