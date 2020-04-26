using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnrealAPI.Models
{
    public partial class UnrealTestContext : DbContext
    {
        public UnrealTestContext(DbContextOptions<UnrealTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Choices> Choices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Choices>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .HasName("PK__Choices__F57BD2D74E816C56");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
