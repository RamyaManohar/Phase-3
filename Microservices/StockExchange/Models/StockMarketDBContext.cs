using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StockExchange.Models
{
    public partial class StockMarketDBContext : DbContext
    {
        public StockMarketDBContext()
        {
        }

        public StockMarketDBContext(DbContextOptions<StockMarketDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyEntity> CompanyEntity { get; set; }
        public virtual DbSet<IpodetailEntity> IpodetailEntity { get; set; }
        public virtual DbSet<SectorEntity> SectorEntity { get; set; }
        public virtual DbSet<StockExchangeEntity> StockExchangeEntity { get; set; }
        public virtual DbSet<StockPriceEntity> StockPriceEntity { get; set; }
        public virtual DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HP\\MSSQLSERVER01;Database=StockMarketDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.BoardOfDirectors)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BriefWriteup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ceo)
                    .HasColumnName("CEO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStockCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ListedinStockExchange).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Turnover).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.ListedinStockExchangeNavigation)
                    .WithMany(p => p.CompanyEntity)
                    .HasForeignKey(d => d.ListedinStockExchange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Com_SEid");
            });

            modelBuilder.Entity<IpodetailEntity>(entity =>
            {
                entity.ToTable("IPODetailEntity");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDateTime).HasColumnType("datetime");

                entity.Property(e => e.PricePerShare).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SectorEntity>(entity =>
            {
                entity.HasKey(e => e.SectorId)
                    .HasName("PK_SectorData");

                entity.Property(e => e.SectorId).ValueGeneratedNever();

                entity.Property(e => e.Brief)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockExchangeEntity>(entity =>
            {
                entity.HasKey(e => e.Seid)
                    .HasName("PK_StockExchnageEntity");

                entity.Property(e => e.Seid)
                    .HasColumnName("SEid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockPriceEntity>(entity =>
            {
                entity.HasKey(e => new { e.CurrentPrice, e.Date, e.Time });

                entity.Property(e => e.CurrentPrice).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.CompanyStockCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Confirmed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
