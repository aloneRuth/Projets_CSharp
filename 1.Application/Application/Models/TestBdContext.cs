using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Application.Models;

public partial class TestBdContext : DbContext
{
    public TestBdContext()
    {
        
    }

    public TestBdContext(DbContextOptions<TestBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utilisateur_pkey");

            entity.ToTable("utilisateur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Info)
                .HasColumnType("jsonb")
                .HasColumnName("info");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
