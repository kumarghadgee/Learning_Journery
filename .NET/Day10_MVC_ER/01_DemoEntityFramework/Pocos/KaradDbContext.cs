using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _01_DemoEntityFramework.Pocos;

public partial class KaradDbContext : DbContext
{
    public KaradDbContext()
    {
    }

    public KaradDbContext(DbContextOptions<KaradDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }
    public virtual DbSet<SPGetEmployeeResultHolder> SPGetEmployeeResultHolders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=KaradDB;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.No);

            entity.ToTable("Emp");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
public class SPGetEmployeeResultHolder
{
    public int No { get; set; }
    public string Name { get; set; }
}
