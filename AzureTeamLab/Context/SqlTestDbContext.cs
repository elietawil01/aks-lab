using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SqlTestApp.Models;

namespace SqlTestApp.Context;

public partial class SqlTestDbContext : DbContext
{
    public SqlTestDbContext(DbContextOptions<SqlTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Address).HasMaxLength(350);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
