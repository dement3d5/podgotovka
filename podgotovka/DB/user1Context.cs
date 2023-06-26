using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using podgotovka.Models;

namespace podgotovka.DB
{
    public partial class user1Context : DbContext
    {
        public user1Context()
        {
        }

        public user1Context(DbContextOptions<user1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Bif> Bifs { get; set; } = null!;
        public virtual DbSet<Pizza> Pizzas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LOCKSMITH; database=user1; user=user1; password=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bif>(entity =>
            {
                entity.ToTable("bif");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lyk)
                    .HasMaxLength(50)
                    .HasColumnName("lyk");

                entity.Property(e => e.Muaso).HasMaxLength(50);

                entity.Property(e => e.Perets)
                    .HasMaxLength(50)
                    .HasColumnName("perets");

                entity.Property(e => e.Solt)
                    .HasMaxLength(50)
                    .HasColumnName("solt");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("pizza");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Perets)
                    .HasMaxLength(50)
                    .HasColumnName("perets");

                entity.Property(e => e.Solt)
                    .HasMaxLength(50)
                    .HasColumnName("solt");

                entity.Property(e => e.Testo)
                    .HasMaxLength(50)
                    .HasColumnName("testo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
