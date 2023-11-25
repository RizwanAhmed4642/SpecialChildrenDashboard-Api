using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SpecialChildrenDashboard_Api.Entities;

#nullable disable

namespace SpecialChildrenDashboard_Api.Context
{
    public partial class SpecialChildrenContext : DbContext
    {
        public SpecialChildrenContext()
        {
        }

        public SpecialChildrenContext(DbContextOptions<SpecialChildrenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllRecord> AllRecords { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<ApplicationScreen> ApplicationScreens { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Cadre> Cadres { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DashboardCounter> DashboardCounters { get; set; }
        public virtual DbSet<DashboardDetailCount> DashboardDetailCounts { get; set; }
        public virtual DbSet<DentalTransaction> DentalTransactions { get; set; }
        public virtual DbSet<DermatologistDoc4> DermatologistDoc4s { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DiseaseCategory> DiseaseCategories { get; set; }
        public virtual DbSet<ENTDoc3> ENTDoc3s { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventCategory> EventCategories { get; set; }
        public virtual DbSet<FollowupDisease> FollowupDiseases { get; set; }
        public virtual DbSet<HealthFacilitiesCategory> HealthFacilitiesCategories { get; set; }
        public virtual DbSet<HealthFacility> HealthFacilities { get; set; }
        public virtual DbSet<HospitalType> HospitalTypes { get; set; }
        public virtual DbSet<Immunization> Immunizations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MissingTokenCounter> MissingTokenCounters { get; set; }
        public virtual DbSet<OphthalmologistDoc2> OphthalmologistDoc2s { get; set; }
        public virtual DbSet<PatientFollowUp> PatientFollowUps { get; set; }
        public virtual DbSet<PatientRegistration> PatientRegistrations { get; set; }
        public virtual DbSet<PediatricianDoc1> PediatricianDoc1s { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PhysicalParameter> PhysicalParameters { get; set; }
        public virtual DbSet<PhysiotherapistDoc7> PhysiotherapistDoc7s { get; set; }
        public virtual DbSet<PsychologistDoc5> PsychologistDoc5s { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<ScreeningType> ScreeningTypes { get; set; }
        public virtual DbSet<Serological> Serologicals { get; set; }
        public virtual DbSet<SpeechTherapistDoc6> SpeechTherapistDoc6s { get; set; }
        public virtual DbSet<V_DentalDiseasesReport> V_DentalDiseasesReports { get; set; }
        public virtual DbSet<V_ENTDiseasesReport> V_ENTDiseasesReports { get; set; }
        public virtual DbSet<V_MentalDiseasesReport> V_MentalDiseasesReports { get; set; }
        public virtual DbSet<V_OphthalmologistDiseasesReport> V_OphthalmologistDiseasesReports { get; set; }
        public virtual DbSet<V_OphthalmologistDivicesReport> V_OphthalmologistDivicesReports { get; set; }
        public virtual DbSet<V_PhysicalDevicesReport> V_PhysicalDevicesReports { get; set; }
        public virtual DbSet<V_PhysicalDiseasesReport> V_PhysicalDiseasesReports { get; set; }
        public virtual DbSet<V_SpeechDiseasesReport> V_SpeechDiseasesReports { get; set; }
        public virtual DbSet<V_TodayRegisterAndScreening> V_TodayRegisterAndScreenings { get; set; }
        public virtual DbSet<View_Lahore_chauburji_10_March_18_Screenings_SC> View_Lahore_chauburji_10_March_18_Screenings_SCs { get; set; }
        public virtual DbSet<View_MissingTokenCount> View_MissingTokenCounts { get; set; }
        public virtual DbSet<View_MoreThan_18_March_18_Screenings_SC> View_MoreThan_18_March_18_Screenings_SCs { get; set; }
        public virtual DbSet<View_NewStudentRegistration> View_NewStudentRegistrations { get; set; }
        public virtual DbSet<View_SpecialChild_TehsilUserList> View_SpecialChild_TehsilUserLists { get; set; }
        public virtual DbSet<View_StudentRegistration> View_StudentRegistrations { get; set; }
        public virtual DbSet<View_sheikhupura_10_March_18_Screenings_SC> View_sheikhupura_10_March_18_Screenings_SCs { get; set; }
        public virtual DbSet<WebSetting> WebSettings { get; set; }
        public virtual DbSet<__MigrationHistory> __MigrationHistories { get; set; }
        public virtual DbSet<dsg_temp> dsg_temps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Initial Catalog=ISA_SC;user id=bilal;password=asa@121;Data Source=172.16.0.6");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AllRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllRecords");

                entity.Property(e => e.CreatedByUsername).HasMaxLength(256);

                entity.Property(e => e.PatientRegistrations_Regdate).HasColumnType("datetime");

                entity.Property(e => e.PatientRegistrations_UniqueId).HasMaxLength(500);

                entity.Property(e => e.Sr__No_).HasColumnName("Sr. No.");
            });

            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.MaintainenceModeDuration).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VersionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplicationScreen>(entity =>
            {
                entity.HasIndex(e => e.CatgeoryId, "IX_CatgeoryId");

                entity.Property(e => e.CatgeoryId).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Catgeory)
                    .WithMany(p => p.ApplicationScreens)
                    .HasForeignKey(d => d.CatgeoryId)
                    .HasConstraintName("FK_dbo.ApplicationScreens_dbo.Categories_CatgeoryId");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Cadre>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DashboardCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DashboardCounter");
            });

            modelBuilder.Entity<DashboardDetailCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DashboardDetailCount");
            });

            modelBuilder.Entity<DentalTransaction>(entity =>
            {
                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XIV_DentalTransactions_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XI_DentalTransactions_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "XXIII_DentalTransactions_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XXII_DentalTransactions_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_DentalTransactions_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.DentalTransactions)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.DentalTransactions_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<DermatologistDoc4>(entity =>
            {
                entity.ToTable("DermatologistDoc4");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XVIII_DermatologistDoc4_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "XXV_DermatologistDoc4_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "X_DermatologistDoc4_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.DermatologistDoc4s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.DermatologistDoc4_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasIndex(e => e.CadreId, "IX_CadreId");

                entity.HasIndex(e => e.DesignationId, "IX_DesignationId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Cadre)
                    .WithMany(p => p.Designations)
                    .HasForeignKey(d => d.CadreId)
                    .HasConstraintName("FK_dbo.Designations_dbo.Cadres_CadreId");

                entity.HasOne(d => d.DesignationNavigation)
                    .WithMany(p => p.InverseDesignationNavigation)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_dbo.Designations_dbo.Designations_DesignationId");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasIndex(e => e.DiseaseCategoryId, "IX_DiseaseCategoryId");

                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.DiseaseCategory)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.DiseaseCategoryId)
                    .HasConstraintName("FK_dbo.Diseases_dbo.DiseaseCategories_DiseaseCategoryId");
            });

            modelBuilder.Entity<DiseaseCategory>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ENTDoc3>(entity =>
            {
                entity.ToTable("ENTDoc3");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XI_ENTDoc3_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XI_ENTDoc3_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "XX_ENTDoc3_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "X_ENTDoc3_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.ENTDoc3s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.ENTDoc3_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_CategoryId");

                entity.HasIndex(e => e.EventCategoryId, "IX_EventCategoryId");

                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.EventCategoryId).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Events_dbo.Categories_CategoryId");

                entity.HasOne(d => d.EventCategory)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventCategoryId)
                    .HasConstraintName("FK_dbo.Events_dbo.EventCategories_EventCategoryId");
            });

            modelBuilder.Entity<EventCategory>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FollowupDisease>(entity =>
            {
                entity.HasIndex(e => e.DiseaseId, "IX_DiseaseId");

                entity.HasIndex(e => e.PatientFollowUpId, "IX_PatientFollowUpId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.FollowupDiseases)
                    .HasForeignKey(d => d.DiseaseId)
                    .HasConstraintName("FK_dbo.FollowupDiseases_dbo.Diseases_DiseaseId");

                entity.HasOne(d => d.PatientFollowUp)
                    .WithMany(p => p.FollowupDiseases)
                    .HasForeignKey(d => d.PatientFollowUpId)
                    .HasConstraintName("FK_dbo.FollowupDiseases_dbo.PatientFollowUps_PatientFollowUpId");
            });

            modelBuilder.Entity<HealthFacilitiesCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HealthFacilitiesCategories");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<HealthFacility>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HealthFacilities");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Created_Date).HasColumnType("datetime");

                entity.Property(e => e.DistrictName).IsRequired();

                entity.Property(e => e.DivisionName).IsRequired();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.HFCategoryName).IsRequired();

                entity.Property(e => e.HFMISCode).IsRequired();

                entity.Property(e => e.HFTypeName).IsRequired();

                entity.Property(e => e.Mauza).HasMaxLength(50);

                entity.Property(e => e.NA).HasMaxLength(30);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PP).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.ProgramName).HasMaxLength(250);

                entity.Property(e => e.ProjectName).HasMaxLength(250);

                entity.Property(e => e.ProjectSName).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TehsilName).IsRequired();

                entity.Property(e => e.UcName).HasMaxLength(50);

                entity.Property(e => e.UcNo).HasMaxLength(10);

                entity.Property(e => e.Users_Id).HasMaxLength(128);
            });

            modelBuilder.Entity<HospitalType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HospitalTypes");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Immunization>(entity =>
            {
                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "X_Immunizations_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.Immunizations)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.Immunizations_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Locations");

                entity.Property(e => e.LVL)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NAME).IsRequired();

                entity.Property(e => e.PKCODE).IsRequired();
            });

            modelBuilder.Entity<MissingTokenCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MissingTokenCounter");

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OphthalmologistDoc2>(entity =>
            {
                entity.ToTable("OphthalmologistDoc2");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.ScreeningTypeId, "XI_OphthalmologistDoc2_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_OphthalmologistDoc2_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.OphthalmologistDoc2s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.OphthalmologistDoc2_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<PatientFollowUp>(entity =>
            {
                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CheckupDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.PatientFollowUps)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.PatientFollowUps_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<PatientRegistration>(entity =>
            {
                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.ScreeningTypeId, "XIII_PatientRegistrations_ScreeningTypeId");

                entity.HasIndex(e => e.Regdate, "XII_PatientRegistrations_Regdate");

                entity.HasIndex(e => e.ScreeningTypeId, "XII_PatientRegistrations_ScreeningTypeId");

                entity.HasIndex(e => e.ScreeningTypeId, "XIV_PatientRegistrations_ScreeningTypeId");

                entity.HasIndex(e => e.Regdate, "XI_PatientRegistrations_Regdate");

                entity.HasIndex(e => e.ScreeningTypeId, "XI_PatientRegistrations_ScreeningTypeId");

                entity.HasIndex(e => new { e.ScreeningTypeId, e.CreatedOn }, "XI_PatientRegistrations_ScreeningTypeId_CreatedOn");

                entity.HasIndex(e => new { e.ScreeningTypeId, e.Regdate }, "XI_PatientRegistrations_ScreeningTypeId_Regdate");

                entity.HasIndex(e => e.ScreeningTypeId, "XV_PatientRegistrations_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_PatientRegistrations_CreatedOn");

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasMaxLength(128);

                entity.Property(e => e.Regdate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PatientRegistrations_dbo.Categories_CategoryId");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_dbo.PatientRegistrations_dbo.Designations_DesignationId");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_dbo.PatientRegistrations_dbo.Events_EventId");
            });

            modelBuilder.Entity<PediatricianDoc1>(entity =>
            {
                entity.ToTable("PediatricianDoc1");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XV_PediatricianDoc1_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "XXII_PediatricianDoc1_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "X_PediatricianDoc1_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.PediatricianDoc1s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.PediatricianDoc1_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.PermissionName).HasMaxLength(200);
            });

            modelBuilder.Entity<PhysicalParameter>(entity =>
            {
                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XII_PhysicalParameters_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "XIX_PhysicalParameters_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XI_PhysicalParameters_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_PhysicalParameters_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.PhysicalParameters)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.PhysicalParameters_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<PhysiotherapistDoc7>(entity =>
            {
                entity.ToTable("PhysiotherapistDoc7");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XVI_PhysiotherapistDoc7_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "X_PhysiotherapistDoc7_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.PhysiotherapistDoc7s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.PhysiotherapistDoc7_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<PsychologistDoc5>(entity =>
            {
                entity.ToTable("PsychologistDoc5");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XIII_PsychologistDoc5_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XI_PsychologistDoc5_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "XXI_PsychologistDoc5_CreatedOn");

                entity.HasIndex(e => e.ScreeningTypeId, "XXI_PsychologistDoc5_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_PsychologistDoc5_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.PsychologistDoc5s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.PsychologistDoc5_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Serological>(entity =>
            {
                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedOn, "XVII_Serologicals_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "XXIV_Serologicals_CreatedOn");

                entity.HasIndex(e => e.CreatedOn, "X_Serologicals_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.Serologicals)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.Serologicals_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<SpeechTherapistDoc6>(entity =>
            {
                entity.ToTable("SpeechTherapistDoc6");

                entity.HasIndex(e => e.PatientRegistrationId, "IX_PatientRegistrationId");

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => e.ScreeningTypeId, "XI_SpeechTherapistDoc6_ScreeningTypeId");

                entity.HasIndex(e => e.CreatedOn, "X_SpeechTherapistDoc6_CreatedOn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.PatientRegistration)
                    .WithMany(p => p.SpeechTherapistDoc6s)
                    .HasForeignKey(d => d.PatientRegistrationId)
                    .HasConstraintName("FK_dbo.SpeechTherapistDoc6_dbo.PatientRegistrations_PatientRegistrationId");
            });

            modelBuilder.Entity<V_DentalDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DentalDiseasesReport");
            });

            modelBuilder.Entity<V_ENTDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ENTDiseasesReport");
            });

            modelBuilder.Entity<V_MentalDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_MentalDiseasesReport");
            });

            modelBuilder.Entity<V_OphthalmologistDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_OphthalmologistDiseasesReport");
            });

            modelBuilder.Entity<V_OphthalmologistDivicesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_OphthalmologistDivicesReport");

                entity.Property(e => e.Total_Binocular).HasColumnName("Total Binocular");

                entity.Property(e => e.Total_Digital_CCTV).HasColumnName("Total Digital CCTV");

                entity.Property(e => e.Total_Envision___Smart_Readable_Glasses).HasColumnName("Total Envision / Smart Readable Glasses");

                entity.Property(e => e.Total_Filters_Glasses_for_Low_Vision).HasColumnName("Total Filters Glasses for Low Vision");

                entity.Property(e => e.Total_Magnifying_Glasses).HasColumnName("Total Magnifying Glasses");

                entity.Property(e => e.Total_Monocular).HasColumnName("Total Monocular");

                entity.Property(e => e.Total_Reading_stand).HasColumnName("Total Reading stand");

                entity.Property(e => e.Total_Spectacles_Adviced).HasColumnName("Total Spectacles Adviced");

                entity.Property(e => e.Total_Stand_Magnifiers).HasColumnName("Total Stand Magnifiers");

                entity.Property(e => e.Total_Table_Lamps).HasColumnName("Total Table Lamps");

                entity.Property(e => e.Total_Tablets).HasColumnName("Total Tablets");

                entity.Property(e => e.Total_Typoscope).HasColumnName("Total Typoscope");

                entity.Property(e => e.Total_Whitecane_for_Blind).HasColumnName("Total Whitecane for Blind");
            });

            modelBuilder.Entity<V_PhysicalDevicesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PhysicalDevicesReport");

                entity.Property(e => e.Total_CP_Chair).HasColumnName("Total CP Chair");

                entity.Property(e => e.Total_Support_Stick___Crutches).HasColumnName("Total Support Stick / Crutches");

                entity.Property(e => e.Total_Walkers).HasColumnName("Total Walkers");

                entity.Property(e => e.Total_Wheelchair_Electric).HasColumnName("Total Wheelchair-Electric");

                entity.Property(e => e.Total_Wheelchair_Manual).HasColumnName("Total Wheelchair-Manual");
            });

            modelBuilder.Entity<V_PhysicalDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PhysicalDiseasesReport");
            });

            modelBuilder.Entity<V_SpeechDiseasesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SpeechDiseasesReport");
            });

            modelBuilder.Entity<V_TodayRegisterAndScreening>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TodayRegisterAndScreening");

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View_Lahore_chauburji_10_March_18_Screenings_SC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Lahore_chauburji_10_March_18_Screenings_SC");

                entity.Property(e => e.PatientRegistrations_Regdate).HasColumnType("datetime");

                entity.Property(e => e.PatientRegistrations_UniqueId).HasMaxLength(500);

                entity.Property(e => e.Sr__No_).HasColumnName("Sr. No.");
            });

            modelBuilder.Entity<View_MissingTokenCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MissingTokenCount");
            });

            modelBuilder.Entity<View_MoreThan_18_March_18_Screenings_SC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MoreThan_18_March_18_Screenings_SC");

                entity.Property(e => e.PatientRegistrations_Regdate).HasColumnType("datetime");

                entity.Property(e => e.PatientRegistrations_UniqueId).HasMaxLength(500);

                entity.Property(e => e.Sr__No_).HasColumnName("Sr. No.");
            });

            modelBuilder.Entity<View_NewStudentRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_NewStudentRegistration");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Regdate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);
            });

            modelBuilder.Entity<View_SpecialChild_TehsilUserList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SpecialChild_TehsilUserList");

                entity.Property(e => e.District).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<View_StudentRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_StudentRegistration");

                entity.Property(e => e.Regdate).HasColumnType("datetime");

                entity.Property(e => e.UniqueId).HasMaxLength(500);
            });

            modelBuilder.Entity<View_sheikhupura_10_March_18_Screenings_SC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_sheikhupura_10_March_18_Screenings_SC");

                entity.Property(e => e.PatientRegistrations_Regdate).HasColumnType("datetime");

                entity.Property(e => e.PatientRegistrations_UniqueId).HasMaxLength(500);

                entity.Property(e => e.Sr__No_).HasColumnName("Sr. No.");
            });

            modelBuilder.Entity<WebSetting>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.MaintainenceModeEnded).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VersionDated).HasColumnType("datetime");
            });

            modelBuilder.Entity<__MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<dsg_temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dsg_temp");

                entity.Property(e => e.cadre_name).HasMaxLength(100);

                entity.Property(e => e.dsg_name).HasMaxLength(100);

                entity.Property(e => e.occopation_name).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
