using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenVanKhanh_2310900047.Models;

public partial class NguyenVanKhanh2310900047Context : DbContext
{
    public NguyenVanKhanh2310900047Context()
    {
    }

    public NguyenVanKhanh2310900047Context(DbContextOptions<NguyenVanKhanh2310900047Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvkEmployee> NvkEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=DESKTOP-IGIO92E;Database=NguyenVanKhanh_2310900047;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvkEmployee>(entity =>
        {
            entity.HasKey(e => e.NvkEmpId).HasName("PK__NvkEmplo__5363FEE0A34808DF");

            entity.ToTable("NvkEmployee");

            entity.Property(e => e.NvkEmpId).ValueGeneratedNever();
            entity.Property(e => e.NvkEmpLevel).HasMaxLength(50);
            entity.Property(e => e.NvkEmpName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
