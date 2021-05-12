using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AR30Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Announce> Announces { get; set; }
        public virtual DbSet<Issuer> Issuers { get; set; }
        public virtual DbSet<PhoneExt> PhoneExts { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Prefix> Prefixes { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
            : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Announce>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_tbAnnounces");
            });

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_tbPrefixes");

                entity.Property(e => e.CPrefixL).IsFixedLength();

                entity.Property(e => e.CPrefixS).IsFixedLength();
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.CDt).HasDefaultValueSql("(getdate())");
            });
        }

    }
}
