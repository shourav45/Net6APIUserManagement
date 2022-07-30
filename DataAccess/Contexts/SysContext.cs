using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Models;

namespace DataAccess.Contexts
{
    public partial class SysContext : DbContext
    {
        public SysContext()
        {
        }

        public SysContext(DbContextOptions<SysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<BankingInfo> BankingInfos { get; set; } = null!;
        public virtual DbSet<CertificationInfo> CertificationInfos { get; set; } = null!;
        public virtual DbSet<ContactInfo> ContactInfos { get; set; } = null!;
        public virtual DbSet<EducationalInfo> EducationalInfos { get; set; } = null!;
        public virtual DbSet<EmployementInfo> EmployementInfos { get; set; } = null!;
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<NoteInfo> NoteInfos { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
        public virtual DbSet<UserAccount> UserAccounts { get; set; } = null!;
        public virtual DbSet<UserAccountCredentialLog> UserAccountCredentialLogs { get; set; } = null!;
        public virtual DbSet<UserBrowsingLog> UserBrowsingLogs { get; set; } = null!;
        public virtual DbSet<UserOtp> UserOtps { get; set; } = null!;
        public virtual DbSet<UserPermission> UserPermissions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Visual Studio 2008\\Frameworks\\BoilerPlateDotNet6\\DataAccess\\DBFiles\\DB_SYS.mdf;Integrated Security=True;Initial Catalog=DB_SYS;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnOperation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PrimaryKeyId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PrimaryKeyID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankingInfo>(entity =>
            {
                entity.ToTable("BankingInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertificationInfo>(entity =>
            {
                entity.ToTable("CertificationInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationOrganisation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationOrganisationUrl).IsUnicode(false);

                entity.Property(e => e.CertifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("ContactInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.DrivingLicenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookUrl).IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InstagramUrl).IsUnicode(false);

                entity.Property(e => e.LinedinUrl).IsUnicode(false);

                entity.Property(e => e.MailAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName).HasMaxLength(200);

                entity.Property(e => e.MobileNo1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo5)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo6)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NationalIDNo");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationalInfo>(entity =>
            {
                entity.ToTable("EducationalInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteUrl).IsUnicode(false);

                entity.Property(e => e.PassingDate).HasColumnType("date");

                entity.Property(e => e.ResultScale).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.ResultScore).HasColumnType("decimal(2, 2)");
            });

            modelBuilder.Entity<EmployementInfo>(entity =>
            {
                entity.ToTable("EmployementInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress).IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl).IsUnicode(false);

                entity.Property(e => e.DateOfJoin).HasColumnType("date");

                entity.Property(e => e.DateOfSeparation).HasColumnType("date");

                entity.Property(e => e.EmploymentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDepartment)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.JoiningDesignation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastDepartment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastDesignation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemunerationCurrency)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.ToTable("ExceptionLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionMessage).IsUnicode(false);

                entity.Property(e => e.InnerException).IsUnicode(false);

                entity.Property(e => e.IsSolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.NameSpace)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OccuredOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SolvedById).HasColumnName("SolvedByID");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MenuUrl).IsUnicode(false);

                entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");
            });

            modelBuilder.Entity<NoteInfo>(entity =>
            {
                entity.ToTable("NoteInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NoteTitle).HasMaxLength(500);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PermissionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlternativeMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BirthCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DrivingLicenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LivingCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NationalIDNo");

                entity.Property(e => e.PassportExpireDate).HasColumnType("date");

                entity.Property(e => e.PassportIssueDate).HasColumnType("date");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TincertificateNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINCertificateNo");

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.ToTable("UserAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserPassword).IsUnicode(false);
            });

            modelBuilder.Entity<UserAccountCredentialLog>(entity =>
            {
                entity.ToTable("UserAccountCredentialLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            });

            modelBuilder.Entity<UserBrowsingLog>(entity =>
            {
                entity.ToTable("UserBrowsingLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastVisitOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            });

            modelBuilder.Entity<UserOtp>(entity =>
            {
                entity.ToTable("UserOTP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpireOn).HasColumnType("datetime");

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasMaxLength(6)
                    .HasColumnName("OTP")
                    .IsFixedLength();

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SentOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("UserPermission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.UpdatedById).HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
