using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lab1Test.EF
{
    public partial class Lab1Context : DbContext
    {
        public Lab1Context()
        {
        }

        public Lab1Context(DbContextOptions<Lab1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Roster> Rosters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Lab1;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roster>(entity =>
            {
                entity.HasKey(e => e.Playerid);

                entity.ToTable("roster");

                entity.Property(e => e.Birthcity)
                    .HasMaxLength(50)
                    .HasColumnName("birthcity");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.Birthstate)
                    .HasMaxLength(2)
                    .HasColumnName("birthstate");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Jersey).HasColumnName("jersey");

                entity.Property(e => e.Playerid)
                    .HasMaxLength(255)
                    .HasColumnName("playerid");

                entity.Property(e => e.Position)
                    .HasMaxLength(2)
                    .HasColumnName("position");

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .HasColumnName("sname");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
