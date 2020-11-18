using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Company.Models
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

        public virtual DbSet<CompanyEntity> CompanyEntities { get; set; }
        public virtual DbSet<IpodetailEntity> IpodetailEntities { get; set; }
        public virtual DbSet<SectorEntity> SectorEntities { get; set; }
        public virtual DbSet<StockExchangeEntity> StockExchangeEntities { get; set; }
        public virtual DbSet<StockPriceEntity> StockPriceEntities { get; set; }
        public virtual DbSet<UserEntity> UserEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HP\\MSSQLSERVER01;Database=StockMarketDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("CompanyEntity");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.BoardOfDirectors)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BriefWriteup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ceo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CEO");

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
                    .WithMany(p => p.CompanyEntities)
                    .HasForeignKey(d => d.ListedinStockExchange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Com_SEid");
            });

            modelBuilder.Entity<IpodetailEntity>(entity =>
            {
                entity.ToTable("IPODetailEntity");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

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

                entity.ToTable("SectorEntity");

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

                entity.ToTable("StockExchangeEntity");

                entity.Property(e => e.Seid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SEid");

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
                entity.HasKey(e => new { e.Date, e.Time, e.CompanyStockCode })
                    .HasName("PK_StockPriceEntity_1");

                entity.ToTable("StockPriceEntity");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.CompanyStockCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrentPrice).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("UserEntity");

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
