using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BT_DB_First.Models;

public partial class QlsinhVienContext : DbContext
{
    public QlsinhVienContext()
    {
    }

    public QlsinhVienContext(DbContextOptions<QlsinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=VAN;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC070C14F193");

            entity.ToTable("SinhVien");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Ten).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
