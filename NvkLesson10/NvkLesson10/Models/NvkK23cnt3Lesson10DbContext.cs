using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NvkLesson10.Models;

public partial class NvkK23cnt3Lesson10DbContext : DbContext
{
    public NvkK23cnt3Lesson10DbContext()
    {
    }

    public NvkK23cnt3Lesson10DbContext(DbContextOptions<NvkK23cnt3Lesson10DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NvkPost> NvkPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IGIO92E;Database=NvkK23CNT3_Lesson10Db;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvkPost>(entity =>
        {
            entity.HasKey(e => e.NvkId);

            entity.ToTable("NvkPost");

            entity.Property(e => e.NvkId)
                .ValueGeneratedNever()
                .HasColumnName("nvkId");
            entity.Property(e => e.NvkContent)
                .HasColumnType("ntext")
                .HasColumnName("nvkContent");
            entity.Property(e => e.NvkImage)
                .HasMaxLength(50)
                .HasColumnName("nvkImage");
            entity.Property(e => e.NvkStatus).HasColumnName("nvkStatus");
            entity.Property(e => e.NvkTitle)
                .HasMaxLength(50)
                .HasColumnName("nvkTitle");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
