using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _01_WebAPI.Models
{
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=KaradDB;Integrated Security=True;");

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

}
