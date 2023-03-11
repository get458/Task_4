using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

public partial class Gr601BokvaContext : DbContext
{
    public Gr601BokvaContext()
    {
    }

    public Gr601BokvaContext(DbContextOptions<Gr601BokvaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usertable> Usertables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=10.30.0.137;Port=5432;Database=gr601_bokva;Username=gr601_bokva;Password=784512bf3X");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usertable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("usertable_pkey");

            entity.ToTable("usertable");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Mail).HasColumnName("mail");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
