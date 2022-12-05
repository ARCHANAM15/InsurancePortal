using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ClaimPolicy.Models
{
    public partial class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext()
        {
        }

        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoginTbl> LoginTbls { get; set; }
        public virtual DbSet<MemberTble> MemberTbles { get; set; }
        public virtual DbSet<PolicyStatusTbl> PolicyStatusTbls { get; set; }
        public virtual DbSet<PolicyTable> PolicyTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CTSDOTNET173;Initial Catalog=InsuranceDb;User ID=sa;Password=pass@word1;Integrated Security=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LoginTbl>(entity =>
            {
                entity.ToTable("LoginTbl");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberTble>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("MemberTble");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PolicyStatusTbl>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("PolicyStatusTbl");

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PolicyTable>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.ToTable("PolicyTable");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PolicyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumAmount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
