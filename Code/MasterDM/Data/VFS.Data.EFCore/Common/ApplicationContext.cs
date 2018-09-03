using Microsoft.EntityFrameworkCore;
using VFS.Common.Models.Masters;
using VFS.Common.Models.AdminMasters;

namespace VFS.Data.EFCore.Common
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }

        #region MASTERS
        public DbSet<Country> Country { get; set; }
        public virtual DbSet<Mission> Mission { get; set; }
        public virtual DbSet<CountryOfOperation> CountryOfOperation { get; set; }
        public virtual DbSet<Jurisdiction> Jurisdiction { get; set; }
        public virtual DbSet<JurisdictionMap> JurisdictionMap { get; set; }
        public virtual DbSet<UnitOps> UnitOps { get; set; }
        public virtual DbSet<CountryMap> CountryMap { get; set; }        
        public virtual DbSet<NationalityMap> NationalityMap { get; set; }
        #endregion

        #region ADMIN MASTERS
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<UIMaster> UIMaster { get; set; }
        public virtual DbSet<UIRoleMap> UIRoleMap { get; set; }             
        public virtual DbSet<UserRoleMap> UserRoleMap { get; set; }
        public virtual DbSet<UserContext> UserContext { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MASTERS
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.DialCode).HasMaxLength(100);

                entity.Property(e => e.Isocode2)
                    .HasColumnName("ISOCode2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Isocode3)
                    .HasColumnName("ISOCode3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MStUser_Country");
            });

            modelBuilder.Entity<CountryOfOperation>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryOfOperation)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_CountryOpsId");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.CountryOfOperation)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mission_MissionId");
            });

            modelBuilder.Entity<Jurisdiction>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<JurisdictionMap>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDateUtc)
                    .HasColumnName("CreatedDateUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModifiedDateUtc)
                    .HasColumnName("ModifiedDateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryOps)
                    .WithMany(p => p.jurisdictionmap)
                    .HasForeignKey(d => d.CountryOpsId)
                    .HasConstraintName("FK_CountryOfOperation_JurisdictionMap");

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.JurisdictionMap)
                    .HasForeignKey(d => d.JurisdictionId)
                    .HasConstraintName("FK_Jurisdiction_JurisdictionMapId");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CountryMap>(entity =>
            {
                entity.ToTable("MSTCountryMap");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryMap)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_MSTCountryMap_Country");

                entity.HasOne(d => d.CountryOps)
                    .WithMany(p => p.CountryMap)
                    .HasForeignKey(d => d.CountryOpsId)
                    .HasConstraintName("FK_MSTCountryMap_CountryOfOperation");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.CountryMap)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSTCountryMap_Mission");

                entity.HasOne(d => d.UnitOps)
                    .WithMany(p => p.CountryMap)
                    .HasForeignKey(d => d.UnitOpsId)
                    .HasConstraintName("FK_MSTCountryMap_UnitOps");
            });

            modelBuilder.Entity<UnitOps>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.UnitOps)
                    .HasForeignKey(d => d.JurisdictionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Juris_JurisdictId");
            });            

            modelBuilder.Entity<NationalityMap>(entity =>
            {
                entity.ToTable("MSTNationalityMap");

                entity.HasOne(d => d.CountryOps)
                    .WithMany(p => p.NationalityMap)
                    .HasForeignKey(d => d.CountryOpsId)
                    .HasConstraintName("FK_CountryOfOperation_MSTNationalityMap");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.NationalityMap)
                    .HasForeignKey(d => d.MissionId)
                    .HasConstraintName("FK_Mission_MSTNationalityMap");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.NationalityMap)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_MSTNationalityMap");

                entity.HasOne(d => d.UnitOps)
                    .WithMany(p => p.NationalityMap)
                    .HasForeignKey(d => d.UnitOpsId)
                    .HasConstraintName("FK_UnitOps_MSTNationalityMap");
            });
            #endregion

            #region ADMIN MASTERS
            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.ToTable("MStUser");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.ToTable("MSTRole");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UIMaster>(entity =>
            {
                entity.ToTable("MSTUI");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UIRoleMap>(entity =>
            {
                entity.ToTable("MSTRoleUIMap");

                entity.Property(e => e.Uiid).HasColumnName("UIId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UIRoleMap)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSTUI_RoleId");

                //entity.HasOne(d => d.Ui)
                //    .WithMany(p => p.UIRoleMap)
                //    .HasForeignKey(d => d.Uiid)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_MSTUI_UIId");
            });

            modelBuilder.Entity<UserRoleMap>(entity =>
            {
                entity.ToTable("MSTUserRoleMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSTRole_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSTUser_UserId");
            });
            #endregion
        }
    }
}

