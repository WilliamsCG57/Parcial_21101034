using System;
using System.Collections.Generic;
using Competency.DOMAIN.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Competency.DOMAIN.Infrastructure.Data;

public partial class Parcial20240221101034Context : DbContext
{
    public Parcial20240221101034Context()
    {
    }

    public Parcial20240221101034Context(DbContextOptions<Parcial20240221101034Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Competency.DOMAIN.Core.Entities.Competency> Competency { get; set; }

    public virtual DbSet<JobOffer> JobOffer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302433;Database=Parcial20240221101034;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Competency.DOMAIN.Core.Entities.Competency>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Level).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<JobOffer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
