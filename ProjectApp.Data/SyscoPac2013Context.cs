using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectApp.Data
{
    public partial class SyscoPac2013Context : DbContext
    {
        public virtual DbSet<AccessRequest> AccessRequest { get; set; }
        public virtual DbSet<AccessRequestStatus> AccessRequestStatus { get; set; }
        public virtual DbSet<ActiveTask> ActiveTask { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ArchivedActiveTask> ArchivedActiveTask { get; set; }
        public virtual DbSet<ArchivedArtwork> ArchivedArtwork { get; set; }
        public virtual DbSet<ArchivedPersonRole> ArchivedPersonRole { get; set; }
        public virtual DbSet<ArchivedSupportingFile> ArchivedSupportingFile { get; set; }
        public virtual DbSet<Artwork> Artwork { get; set; }
        public virtual DbSet<ArtworkThumbnail> ArtworkThumbnail { get; set; }
        public virtual DbSet<Bscc> Bscc { get; set; }
        public virtual DbSet<CallLog> CallLog { get; set; }
        public virtual DbSet<CodingStandards> CodingStandards { get; set; }
        public virtual DbSet<CompletedQuestion> CompletedQuestion { get; set; }
        public virtual DbSet<CompletedTask> CompletedTask { get; set; }
        public virtual DbSet<CyclicRoleAssignment> CyclicRoleAssignment { get; set; }
        public virtual DbSet<CyclicTaskAssignment> CyclicTaskAssignment { get; set; }
        public virtual DbSet<DdlLog> DdlLog { get; set; }
        public virtual DbSet<DefaultSetting> DefaultSetting { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<EmailQueue> EmailQueue { get; set; }
        public virtual DbSet<EmailRecipientRoles> EmailRecipientRoles { get; set; }
        public virtual DbSet<EmailStatus> EmailStatus { get; set; }
        public virtual DbSet<EmailType> EmailType { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<InvoiceStatus> InvoiceStatus { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageNote> PackageNote { get; set; }
        public virtual DbSet<PackageRevision> PackageRevision { get; set; }
        public virtual DbSet<PackageStatus> PackageStatus { get; set; }
        public virtual DbSet<PackageStatusLog1> PackageStatusLog1 { get; set; }
        public virtual DbSet<PackageSuspensionLog> PackageSuspensionLog { get; set; }
        public virtual DbSet<PackageType> PackageType { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonEmailBlock> PersonEmailBlock { get; set; }
        public virtual DbSet<PersonEmailLog> PersonEmailLog { get; set; }
        public virtual DbSet<PersonMetrics> PersonMetrics { get; set; }
        public virtual DbSet<PersonRole> PersonRole { get; set; }
        public virtual DbSet<PersonSearchData> PersonSearchData { get; set; }
        public virtual DbSet<PersonStatus> PersonStatus { get; set; }
        public virtual DbSet<PersonType> PersonType { get; set; }
        public virtual DbSet<PersonTypeOptionalEmail> PersonTypeOptionalEmail { get; set; }
        public virtual DbSet<Prepress> Prepress { get; set; }
        public virtual DbSet<PrepressSupplier> PrepressSupplier { get; set; }
        public virtual DbSet<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectDeleteLog> ProjectDeleteLog { get; set; }
        public virtual DbSet<ProjectNote> ProjectNote { get; set; }
        public virtual DbSet<ProjectRoleDefault> ProjectRoleDefault { get; set; }
        public virtual DbSet<ProjectSearchData> ProjectSearchData { get; set; }
        public virtual DbSet<ProjectStatus> ProjectStatus { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<QaSuspension> QaSuspension { get; set; }
        public virtual DbSet<QaSuspensionState> QaSuspensionState { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionDisplayGroup> QuestionDisplayGroup { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<ReviewSummary> ReviewSummary { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleCandidates> RoleCandidates { get; set; }
        public virtual DbSet<RoleType> RoleType { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierInvoice> SupplierInvoice { get; set; }
        public virtual DbSet<SupplierOperation> SupplierOperation { get; set; }
        public virtual DbSet<SupplierStatus> SupplierStatus { get; set; }
        public virtual DbSet<SupplierStatusLog> SupplierStatusLog { get; set; }
        public virtual DbSet<SupplierSuvc> SupplierSuvc { get; set; }
        public virtual DbSet<SupplierType> SupplierType { get; set; }
        public virtual DbSet<SupportingFile> SupportingFile { get; set; }
        public virtual DbSet<TableAbbreviation> TableAbbreviation { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<ThumbnailType> ThumbnailType { get; set; }
        public virtual DbSet<WorkFlow> WorkFlow { get; set; }

        // Unable to generate entity type for table 'dbo.person_settings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._package_status_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.contact_import'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server = SDG-CQ01\SDGDBSQL01;Database= SyscoPac2013;Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessRequest>(entity =>
            {
                entity.ToTable("access_request");

                entity.HasIndex(e => e.RArsId)
                    .HasName("IX_access_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnName("address_line1")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.ArsDate)
                    .HasColumnName("ars_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RArsId)
                    .HasColumnName("r_ars_id")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasColumnName("state_province")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SubmissionId)
                    .IsRequired()
                    .HasColumnName("submission_id")
                    .HasColumnType("varchar(32)");

                entity.HasOne(d => d.RArs)
                    .WithMany(p => p.AccessRequest)
                    .HasForeignKey(d => d.RArsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_access_request_access_request_status");
            });

            modelBuilder.Entity<AccessRequestStatus>(entity =>
            {
                entity.ToTable("access_request_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ActiveTask>(entity =>
            {
                entity.ToTable("active_task");

                entity.HasIndex(e => new { e.RPerId, e.RPrjId })
                    .HasName("IX_active_task_person");

                entity.HasIndex(e => new { e.RPrjId, e.RPkgId, e.RPerId, e.RRolId, e.RTskId })
                    .HasName("IX_active_task");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Overdue)
                    .HasColumnName("overdue")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId)
                    .HasColumnName("r_rev_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.Property(e => e.Warn)
                    .HasColumnName("warn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.ActiveTask)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_package_task_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.ActiveTask)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_task_package_group");

                entity.HasOne(d => d.RRev)
                    .WithMany(p => p.ActiveTask)
                    .HasForeignKey(d => d.RRevId)
                    .HasConstraintName("fk_active_task_package_revision");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.ActiveTask)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_task_role");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.ActiveTask)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_task_task");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("activity_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LogText)
                    .HasColumnName("log_text")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.RActId).HasColumnName("r_act_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.ReferenceId1).HasColumnName("reference_id1");

                entity.Property(e => e.ReferenceId10).HasColumnName("reference_id10");

                entity.Property(e => e.ReferenceId2).HasColumnName("reference_id2");

                entity.Property(e => e.ReferenceId3).HasColumnName("reference_id3");

                entity.Property(e => e.ReferenceId4).HasColumnName("reference_id4");

                entity.Property(e => e.ReferenceId5).HasColumnName("reference_id5");

                entity.Property(e => e.ReferenceId6).HasColumnName("reference_id6");

                entity.Property(e => e.ReferenceId7).HasColumnName("reference_id7");

                entity.Property(e => e.ReferenceId8).HasColumnName("reference_id8");

                entity.Property(e => e.ReferenceId9).HasColumnName("reference_id9");

                entity.HasOne(d => d.RAct)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.RActId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_activity_log_activity_type");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_activity_log_person");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.ToTable("activity_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ReferenceIdColumns)
                    .HasColumnName("reference_id_columns")
                    .HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line1")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'United States'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OldContactId).HasColumnName("old_contact_id");

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.StateProvince)
                    .HasColumnName("state_province")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ArchivedActiveTask>(entity =>
            {
                entity.ToTable("archived_active_task");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Overdue)
                    .HasColumnName("overdue")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.Property(e => e.Warn)
                    .HasColumnName("warn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ArchivedArtwork>(entity =>
            {
                entity.ToTable("archived_artwork");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.EngagedDate)
                    .HasColumnName("engaged_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InternalFileName)
                    .IsRequired()
                    .HasColumnName("internal_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsEngaged).HasColumnName("is_engaged");

                entity.Property(e => e.RBscId).HasColumnName("r_bsc_id");

                entity.Property(e => e.RPerIdCreated).HasColumnName("r_per_id_created");

                entity.Property(e => e.RPreId).HasColumnName("r_pre_id");

                entity.Property(e => e.RPtyId).HasColumnName("r_pty_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.Supc)
                    .HasColumnName("supc")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ArchivedPersonRole>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Archived })
                    .HasName("PK_archived_person_role");

                entity.ToTable("archived_person_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");
            });

            modelBuilder.Entity<ArchivedSupportingFile>(entity =>
            {
                entity.ToTable("archived_supporting_file");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InternalFileName)
                    .IsRequired()
                    .HasColumnName("internal_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RArtId).HasColumnName("r_art_id");
            });

            modelBuilder.Entity<Artwork>(entity =>
            {
                entity.ToTable("artwork");

                entity.HasIndex(e => new { e.IsEngaged, e.RSupId })
                    .HasName("IX_supplier_upload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.EngagedDate)
                    .HasColumnName("engaged_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InternalFileName)
                    .IsRequired()
                    .HasColumnName("internal_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsEngaged)
                    .HasColumnName("is_engaged")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RBscId).HasColumnName("r_bsc_id");

                entity.Property(e => e.RPerIdCreated).HasColumnName("r_per_id_created");

                entity.Property(e => e.RPreId).HasColumnName("r_pre_id");

                entity.Property(e => e.RPtyId).HasColumnName("r_pty_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.Supc)
                    .HasColumnName("supc")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RBsc)
                    .WithMany(p => p.Artwork)
                    .HasForeignKey(d => d.RBscId)
                    .HasConstraintName("FK_supplier_upload_bscc");

                entity.HasOne(d => d.RPerIdCreatedNavigation)
                    .WithMany(p => p.Artwork)
                    .HasForeignKey(d => d.RPerIdCreated)
                    .HasConstraintName("FK_artwork_person");

                entity.HasOne(d => d.RPre)
                    .WithMany(p => p.Artwork)
                    .HasForeignKey(d => d.RPreId)
                    .HasConstraintName("FK_artwork_prepress");

                entity.HasOne(d => d.RPty)
                    .WithMany(p => p.Artwork)
                    .HasForeignKey(d => d.RPtyId)
                    .HasConstraintName("FK_supplier_upload_package_type");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.Artwork)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_supplier_upload_supplier");
            });

            modelBuilder.Entity<ArtworkThumbnail>(entity =>
            {
                entity.ToTable("artwork_thumbnail");

                entity.HasIndex(e => new { e.RArtId, e.RTmbId, e.PageNumber })
                    .HasName("IX_artwork_thumbnail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PageNumber).HasColumnName("page_number");

                entity.Property(e => e.RArtId).HasColumnName("r_art_id");

                entity.Property(e => e.RTmbId).HasColumnName("r_tmb_id");

                entity.HasOne(d => d.RArt)
                    .WithMany(p => p.ArtworkThumbnail)
                    .HasForeignKey(d => d.RArtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_artwork_thumbnail_artwork");

                entity.HasOne(d => d.RTmb)
                    .WithMany(p => p.ArtworkThumbnail)
                    .HasForeignKey(d => d.RTmbId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_artwork_thumbnail_thumbnail_type");
            });

            modelBuilder.Entity<Bscc>(entity =>
            {
                entity.ToTable("bscc");

                entity.HasIndex(e => e.OldUserGroupId)
                    .HasName("IX_tmp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCanada)
                    .HasColumnName("is_canada")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.OldUserGroupId).HasColumnName("old_user_group_id");
            });

            modelBuilder.Entity<CallLog>(entity =>
            {
                entity.ToTable("call_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Call)
                    .IsRequired()
                    .HasColumnName("call")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<CodingStandards>(entity =>
            {
                entity.ToTable("coding_standards");

                entity.HasIndex(e => new { e.Supc, e.Id })
                    .HasName("IX_coding_standards");

                entity.HasIndex(e => new { e.TrueVendor, e.Id })
                    .HasName("IX_coding_standards_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CatchWeightIndicator)
                    .HasColumnName("catch_weight_indicator")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Container)
                    .HasColumnName("container")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Cube)
                    .HasColumnName("cube")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Cubiscan)
                    .HasColumnName("cubiscan")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExternalUpc)
                    .HasColumnName("external_upc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("gross_weight")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HazardCode)
                    .HasColumnName("hazard_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Hi)
                    .HasColumnName("hi")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IntermediateCategory)
                    .HasColumnName("intermediate_category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InternalUpc)
                    .HasColumnName("internal_upc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.KosherItem)
                    .HasColumnName("kosher_item")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MajorCategory)
                    .HasColumnName("major_category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MasterCase)
                    .HasColumnName("master_case")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MinimumSplit)
                    .HasColumnName("minimum_split")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MinorCategory)
                    .HasColumnName("minor_category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NetWeight)
                    .HasColumnName("net_weight")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NonHazardous)
                    .HasColumnName("non_hazardous")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Pack)
                    .HasColumnName("pack")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Portion)
                    .HasColumnName("portion")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PortionSize)
                    .HasColumnName("portion_size")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShipSplitOnly)
                    .HasColumnName("ship_split_only")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SourceVendor)
                    .HasColumnName("source_vendor")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StockType)
                    .HasColumnName("stock_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Storage)
                    .HasColumnName("storage")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Supc)
                    .IsRequired()
                    .HasColumnName("supc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TareWeight)
                    .HasColumnName("tare_weight")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Ti)
                    .HasColumnName("ti")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TrueVendor)
                    .HasColumnName("true_vendor")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UnitsPerCase)
                    .HasColumnName("units_per_case")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CompletedQuestion>(entity =>
            {
                entity.ToTable("completed_question");

                entity.HasIndex(e => new { e.RCtkId, e.RPerId, e.RQstId, e.RAtkId })
                    .HasName("IX_completed_question");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RAtkId).HasColumnName("r_atk_id");

                entity.Property(e => e.RCtkId).HasColumnName("r_ctk_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RQstId).HasColumnName("r_qst_id");

                entity.Property(e => e.ReportingAnswer)
                    .HasColumnName("reporting_answer")
                    .HasColumnType("varchar(4000)");
            });

            modelBuilder.Entity<CompletedTask>(entity =>
            {
                entity.ToTable("completed_task");

                entity.HasIndex(e => new { e.RPerId, e.RPkgId, e.RPrjId, e.RRolId, e.RRevId, e.RTskId })
                    .HasName("IX_completed_task");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Overdue)
                    .HasColumnName("overdue")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPerOnBehalfOf).HasColumnName("r_per_on_behalf_of");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId)
                    .HasColumnName("r_rev_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.Property(e => e.Warn)
                    .HasColumnName("warn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_completed_task_person");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_completed_task_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_completed_task_project");

                entity.HasOne(d => d.RRev)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RRevId)
                    .HasConstraintName("fk_completed_task_package_revision");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_completed_task_role");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.CompletedTask)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_completed_task_task");
            });

            modelBuilder.Entity<CyclicRoleAssignment>(entity =>
            {
                entity.HasKey(e => new { e.RPerId, e.RRolId })
                    .HasName("PK_cyclic_role_assignment");

                entity.ToTable("cyclic_role_assignment");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.Assigned)
                    .HasColumnName("assigned")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.CyclicRoleAssignment)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cyclic_role_assignment_person");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.CyclicRoleAssignment)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cyclic_role_assignment_role");
            });

            modelBuilder.Entity<CyclicTaskAssignment>(entity =>
            {
                entity.ToTable("cyclic_task_assignment");

                entity.HasIndex(e => new { e.RPkgId, e.RPrjId, e.RTskId, e.NextActive })
                    .HasName("IX_cyclic_task_assignment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NextActive)
                    .HasColumnName("next_active")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.CyclicTaskAssignment)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_cyclic_task_assignment_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.CyclicTaskAssignment)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cyclic_task_assignment_project");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.CyclicTaskAssignment)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cyclic_task_assignment_task");
            });

            modelBuilder.Entity<DdlLog>(entity =>
            {
                entity.ToTable("ddl_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasColumnName("event_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasColumnName("login_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasColumnName("object_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("object_type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<DefaultSetting>(entity =>
            {
                entity.ToTable("default_setting");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Setting)
                    .HasColumnName("setting")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.ToTable("dictionary");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<EmailQueue>(entity =>
            {
                entity.ToTable("email_queue");

                entity.HasIndex(e => new { e.REmlId, e.RPerId, e.RPrjId, e.RPkgId, e.REmsId })
                    .HasName("IX_email_queue");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.EmsDate)
                    .HasColumnName("ems_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RArqId).HasColumnName("r_arq_id");

                entity.Property(e => e.REmlId).HasColumnName("r_eml_id");

                entity.Property(e => e.REmsId).HasColumnName("r_ems_id");

                entity.Property(e => e.RPamId).HasColumnName("r_pam_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RSusId).HasColumnName("r_sus_id");

                entity.HasOne(d => d.RArq)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RArqId)
                    .HasConstraintName("FK_email_queue_access_request");

                entity.HasOne(d => d.REml)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.REmlId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_email_queue_email_type");

                entity.HasOne(d => d.REms)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.REmsId)
                    .HasConstraintName("FK_email_queue_email_status");

                entity.HasOne(d => d.RPam)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RPamId)
                    .HasConstraintName("FK_email_queue_process_automation");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_email_queue_person");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_email_queue_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RPrjId)
                    .HasConstraintName("FK_email_queue_project");

                entity.HasOne(d => d.RRev)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RRevId)
                    .HasConstraintName("fk_email_queue_package_revision");

                entity.HasOne(d => d.RSus)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.RSusId)
                    .HasConstraintName("FK_email_queue_qa_suspension");
            });

            modelBuilder.Entity<EmailRecipientRoles>(entity =>
            {
                entity.HasKey(e => new { e.REmlId, e.RRolId })
                    .HasName("PK_email_recpient_roles");

                entity.ToTable("email_recipient_roles");

                entity.Property(e => e.REmlId).HasColumnName("r_eml_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");
            });

            modelBuilder.Entity<EmailStatus>(entity =>
            {
                entity.ToTable("email_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.ToTable("email_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.HasPdr)
                    .HasColumnName("has_pdr")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HtmlFooter)
                    .HasColumnName("html_footer")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.HtmlTemplate)
                    .IsRequired()
                    .HasColumnName("html_template")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.TextFooter)
                    .HasColumnName("text_footer")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TextTemplate)
                    .IsRequired()
                    .HasColumnName("text_template")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("error_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additional_info")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Caller)
                    .HasColumnName("caller")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Line).HasColumnName("line");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(4000)");
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.ToTable("invoice_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("package");

                entity.HasIndex(e => e.RPrjId)
                    .HasName("IX_package_project");

                entity.HasIndex(e => e.RPtyId)
                    .HasName("IX_package_type");

                entity.HasIndex(e => new { e.RRevLatestId, e.Id })
                    .HasName("IX_package_latest_revision");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountReviewers)
                    .HasColumnName("amount_reviewers")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.HasApprChanges)
                    .HasColumnName("has_appr_changes")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasRework)
                    .HasColumnName("has_rework")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastPdrDate)
                    .HasColumnName("last_pdr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldPackageId).HasColumnName("old_package_id");

                entity.Property(e => e.OldProjectId).HasColumnName("old_project_id");

                entity.Property(e => e.PdrFileName)
                    .HasColumnName("pdr_file_name")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.PercentComplete)
                    .HasColumnName("percent_complete")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PksDate)
                    .HasColumnName("pks_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RArtLatestId).HasColumnName("r_art_latest_id");

                entity.Property(e => e.RPksId)
                    .HasColumnName("r_pks_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RPtyId).HasColumnName("r_pty_id");

                entity.Property(e => e.RRevLatestId).HasColumnName("r_rev_latest_id");

                entity.Property(e => e.RSusId).HasColumnName("r_sus_id");

                entity.Property(e => e.RTsaId)
                    .HasColumnName("r_tsa_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Supc)
                    .IsRequired()
                    .HasColumnName("supc")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RArtLatest)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RArtLatestId)
                    .HasConstraintName("FK_package_artwork");

                entity.HasOne(d => d.RPks)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RPksId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_package_status");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_package_group");

                entity.HasOne(d => d.RPty)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RPtyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_package_type");

                entity.HasOne(d => d.RSus)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RSusId)
                    .HasConstraintName("FK_package_qa_suspension");

                entity.HasOne(d => d.RTsa)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.RTsaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_task_status");
            });

            modelBuilder.Entity<PackageNote>(entity =>
            {
                entity.ToTable("package_note");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPrivate).HasColumnName("is_private");

                entity.Property(e => e.Modified)
                    .HasColumnName("modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPerModifiedId).HasColumnName("r_per_modified_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.PackageNoteRPer)
                    .HasForeignKey(d => d.RPerId)
                    .HasConstraintName("FK_package_note_person");

                entity.HasOne(d => d.RPerModified)
                    .WithMany(p => p.PackageNoteRPerModified)
                    .HasForeignKey(d => d.RPerModifiedId)
                    .HasConstraintName("FK_package_note_person1");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.PackageNote)
                    .HasForeignKey(d => d.RPkgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_note_package");
            });

            modelBuilder.Entity<PackageRevision>(entity =>
            {
                entity.ToTable("package_revision");

                entity.HasIndex(e => new { e.RPkgId, e.RArtId, e.RPksCausedId })
                    .HasName("IX_package_revision");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.RArtId).HasColumnName("r_art_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPksCausedId)
                    .HasColumnName("r_pks_caused_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RPksClosedId).HasColumnName("r_pks_closed_id");

                entity.Property(e => e.Revision).HasColumnName("revision");

                entity.HasOne(d => d.RArt)
                    .WithMany(p => p.PackageRevision)
                    .HasForeignKey(d => d.RArtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_revision_artwork");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.PackageRevision)
                    .HasForeignKey(d => d.RPkgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_revision_package");

                entity.HasOne(d => d.RPksCaused)
                    .WithMany(p => p.PackageRevisionRPksCaused)
                    .HasForeignKey(d => d.RPksCausedId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_revision_package_status");

                entity.HasOne(d => d.RPksClosed)
                    .WithMany(p => p.PackageRevisionRPksClosed)
                    .HasForeignKey(d => d.RPksClosedId)
                    .HasConstraintName("FK_package_revision_package_status1");
            });

            modelBuilder.Entity<PackageStatus>(entity =>
            {
                entity.ToTable("package_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<PackageStatusLog1>(entity =>
            {
                entity.ToTable("package_status_log");

                entity.HasIndex(e => new { e.RPkgId, e.RPksId })
                    .HasName("IX_package_status_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPksId).HasColumnName("r_pks_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.PackageStatusLog1)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_package_status_log_package");
            });

            modelBuilder.Entity<PackageSuspensionLog>(entity =>
            {
                entity.ToTable("package_suspension_log");

                entity.HasIndex(e => new { e.RPkgId, e.RQasId, e.RPerCreatedId, e.Completed })
                    .HasName("IX_package_suspension_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPerCompletedId).HasColumnName("r_per_completed_id");

                entity.Property(e => e.RPerCreatedId).HasColumnName("r_per_created_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RQasId).HasColumnName("r_qas_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RSusId).HasColumnName("r_sus_id");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.PackageSuspensionLog)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_package_suspension_log_package");
            });

            modelBuilder.Entity<PackageType>(entity =>
            {
                entity.ToTable("package_type");

                entity.HasIndex(e => e.OldPackageType)
                    .HasName("IX_package_type_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.OldPackageType)
                    .HasColumnName("old_package_type")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.HasIndex(e => e.RPreId)
                    .HasName("IX_person_2");

                entity.HasIndex(e => new { e.Email, e.Password, e.RPtaId })
                    .HasName("IX_person");

                entity.HasIndex(e => new { e.RPstId, e.RPemId, e.RSupId, e.RAdrId })
                    .HasName("IX_person_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.EulaAccepted)
                    .HasColumnName("eula_accepted")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("last_activity")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastTaskEmail)
                    .HasColumnName("last_task_email")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.RAdrId).HasColumnName("r_adr_id");

                entity.Property(e => e.RPemId)
                    .HasColumnName("r_pem_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RPreId).HasColumnName("r_pre_id");

                entity.Property(e => e.RPstId)
                    .HasColumnName("r_pst_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RPtaId)
                    .HasColumnName("r_pta_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.RAdr)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RAdrId)
                    .HasConstraintName("FK_person_address");

                entity.HasOne(d => d.RPem)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RPemId)
                    .HasConstraintName("FK_person_permission");

                entity.HasOne(d => d.RPre)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RPreId)
                    .HasConstraintName("FK_person_prepress");

                entity.HasOne(d => d.RPst)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RPstId)
                    .HasConstraintName("FK_person_person_type");

                entity.HasOne(d => d.RPta)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RPtaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_person_status");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RSupId)
                    .HasConstraintName("FK_person_supplier");
            });

            modelBuilder.Entity<PersonEmailBlock>(entity =>
            {
                entity.HasKey(e => new { e.RPerId, e.REmlId })
                    .HasName("PK_person_email_opt_out");

                entity.ToTable("person_email_block");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.REmlId).HasColumnName("r_eml_id");

                entity.HasOne(d => d.REml)
                    .WithMany(p => p.PersonEmailBlock)
                    .HasForeignKey(d => d.REmlId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_email_opt_out_email_type");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.PersonEmailBlock)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_email_opt_out_person");
            });

            modelBuilder.Entity<PersonEmailLog>(entity =>
            {
                entity.HasKey(e => new { e.RPerId, e.REmlId, e.Sent })
                    .HasName("PK_person_email_log");

                entity.ToTable("person_email_log");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.REmlId).HasColumnName("r_eml_id");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.REml)
                    .WithMany(p => p.PersonEmailLog)
                    .HasForeignKey(d => d.REmlId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_email_log_email_type");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.PersonEmailLog)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_email_log_person");
            });

            modelBuilder.Entity<PersonMetrics>(entity =>
            {
                entity.ToTable("person_metrics");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtworkAvgPend).HasColumnName("artwork_avg_pend");

                entity.Property(e => e.ArtworkPending).HasColumnName("artwork_pending");

                entity.Property(e => e.ArtworkTotal).HasColumnName("artwork_total");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenTasks).HasColumnName("open_tasks");

                entity.Property(e => e.PackageAssignedClosed).HasColumnName("package_assigned_closed");

                entity.Property(e => e.PackageAssignedOpen).HasColumnName("package_assigned_open");

                entity.Property(e => e.PackageAvgPctTarget)
                    .HasColumnName("package_avg_pct_target")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PackageAvgSuspension).HasColumnName("package_avg_suspension");

                entity.Property(e => e.PackageAvgTurnTime).HasColumnName("package_avg_turn_time");

                entity.Property(e => e.PackageCurrentSuspended).HasColumnName("package_current_suspended");

                entity.Property(e => e.PackageTotalSupsended).HasColumnName("package_total_supsended");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.TaskAvgTurnTime).HasColumnName("task_avg_turn_time");

                entity.Property(e => e.TaskAvgVsThreshold)
                    .HasColumnName("task_avg_vs_threshold")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskClosedCount).HasColumnName("task_closed_count");

                entity.Property(e => e.TaskLongestOpen).HasColumnName("task_longest_open");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.PersonMetrics)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_metrics_person");
            });

            modelBuilder.Entity<PersonRole>(entity =>
            {
                entity.ToTable("person_role");

                entity.HasIndex(e => new { e.RPerId, e.RRolId, e.RPkgId, e.RRevId })
                    .HasName("IX_person_role_package");

                entity.HasIndex(e => new { e.RPrjId, e.RRolId, e.RPerId, e.RPkgId })
                    .HasName("IX_person_role_project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_role_person");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_person_role_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_role_package_group");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_role_role");
            });

            modelBuilder.Entity<PersonSearchData>(entity =>
            {
                entity.HasKey(e => e.RPerId)
                    .HasName("PK_person_search_data");

                entity.ToTable("person_search_data");

                entity.Property(e => e.RPerId)
                    .HasColumnName("r_per_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SearchText)
                    .IsRequired()
                    .HasColumnName("search_text")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.RPer)
                    .WithOne(p => p.PersonSearchData)
                    .HasForeignKey<PersonSearchData>(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_search_data_person");
            });

            modelBuilder.Entity<PersonStatus>(entity =>
            {
                entity.ToTable("person_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PersonType>(entity =>
            {
                entity.ToTable("person_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailFooterHtml)
                    .HasColumnName("email_footer_html")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.EmailFooterText)
                    .HasColumnName("email_footer_text")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PersonTypeOptionalEmail>(entity =>
            {
                entity.HasKey(e => new { e.RPstId, e.REmlId })
                    .HasName("PK_person_type_optional_email");

                entity.ToTable("person_type_optional_email");

                entity.Property(e => e.RPstId).HasColumnName("r_pst_id");

                entity.Property(e => e.REmlId).HasColumnName("r_eml_id");
            });

            modelBuilder.Entity<Prepress>(entity =>
            {
                entity.ToTable("prepress");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<PrepressSupplier>(entity =>
            {
                entity.HasKey(e => new { e.RPreId, e.RSupId })
                    .HasName("PK_prepress_supplier");

                entity.ToTable("prepress_supplier");

                entity.Property(e => e.RPreId).HasColumnName("r_pre_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.HasOne(d => d.RPre)
                    .WithMany(p => p.PrepressSupplier)
                    .HasForeignKey(d => d.RPreId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_prepress_supplier_prepress");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.PrepressSupplier)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_prepress_supplier_supplier");
            });

            modelBuilder.Entity<ProcessAutomation>(entity =>
            {
                entity.ToTable("process_automation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Consumed)
                    .HasColumnName("consumed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RQstId).HasColumnName("r_qst_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.ProcessAutomation)
                    .HasForeignKey(d => d.RPkgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_process_automation_package");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.ProcessAutomation)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_process_automation_project");

                entity.HasOne(d => d.RQst)
                    .WithMany(p => p.ProcessAutomation)
                    .HasForeignKey(d => d.RQstId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_process_automation_question");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.ProcessAutomation)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_process_automation_supplier");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.ProcessAutomation)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_process_automation_task");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.HasIndex(e => e.RPreId)
                    .HasName("IX_project_prepress");

                entity.HasIndex(e => new { e.IsRush, e.HasApprChanges, e.HasSusPackages })
                    .HasName("IX_project_1");

                entity.HasIndex(e => new { e.IsRush, e.RStaId, e.RBscId, e.RSupId })
                    .HasName("IX_project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.HasApprChanges)
                    .HasColumnName("has_appr_changes")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasSusPackages)
                    .HasColumnName("has_sus_packages")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsCanada).HasColumnName("is_canada");

                entity.Property(e => e.IsRush)
                    .HasColumnName("is_rush")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastPdrDate)
                    .HasColumnName("last_pdr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MetaData)
                    .HasColumnName("meta_data")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.NumberPackages)
                    .HasColumnName("number_packages")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdaFileName)
                    .HasColumnName("pda_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PdrFileName)
                    .HasColumnName("pdr_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PercentComplete)
                    .HasColumnName("percent_complete")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RBscId).HasColumnName("r_bsc_id");

                entity.Property(e => e.RPgtId).HasColumnName("r_pgt_id");

                entity.Property(e => e.RPreId).HasColumnName("r_pre_id");

                entity.Property(e => e.RStaId)
                    .HasColumnName("r_sta_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.RTsaAggregateId)
                    .HasColumnName("r_tsa_aggregate_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RTsaId)
                    .HasColumnName("r_tsa_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.StaDate)
                    .HasColumnName("sta_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SubmissionId)
                    .IsRequired()
                    .HasColumnName("submission_id")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Suvc)
                    .IsRequired()
                    .HasColumnName("suvc")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RBsc)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.RBscId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_group_bscc");

                entity.HasOne(d => d.RPgt)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.RPgtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_group_package_group_type");

                entity.HasOne(d => d.RPre)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.RPreId)
                    .HasConstraintName("FK_project_prepress");

                entity.HasOne(d => d.RSta)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.RStaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_project_project_status");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_group_supplier");

                entity.HasOne(d => d.RTsaAggregate)
                    .WithMany(p => p.ProjectRTsaAggregate)
                    .HasForeignKey(d => d.RTsaAggregateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_project_task_status1");

                entity.HasOne(d => d.RTsa)
                    .WithMany(p => p.ProjectRTsa)
                    .HasForeignKey(d => d.RTsaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_project_task_status");
            });

            modelBuilder.Entity<ProjectDeleteLog>(entity =>
            {
                entity.ToTable("project_delete_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldPackageId).HasColumnName("old_package_id");

                entity.Property(e => e.OldProjectId).HasColumnName("old_project_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.ProjectDeleteLog)
                    .HasForeignKey(d => d.RPerId)
                    .HasConstraintName("FK_project_delete_log_person");
            });

            modelBuilder.Entity<ProjectNote>(entity =>
            {
                entity.ToTable("project_note");

                entity.HasIndex(e => new { e.RPerId, e.RPrjId })
                    .HasName("IX_project_note");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsPrivate).HasColumnName("is_private");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OldProjectId).HasColumnName("old_project_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.ProjectNote)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_group_note_person");

                entity.HasOne(d => d.RPrj)
                    .WithMany(p => p.ProjectNote)
                    .HasForeignKey(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_package_group_note_package_group");
            });

            modelBuilder.Entity<ProjectRoleDefault>(entity =>
            {
                entity.HasKey(e => new { e.RPrjId, e.RRolId, e.RPerId })
                    .HasName("PK_project_role_default");

                entity.ToTable("project_role_default");

                entity.Property(e => e.RPrjId).HasColumnName("r_prj_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.ProjectRoleDefault)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_project_role_default_person");
            });

            modelBuilder.Entity<ProjectSearchData>(entity =>
            {
                entity.HasKey(e => e.RPrjId)
                    .HasName("PK_project_search_data");

                entity.ToTable("project_search_data");

                entity.Property(e => e.RPrjId)
                    .HasColumnName("r_prj_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SearchComments)
                    .HasColumnName("search_comments")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SearchText)
                    .IsRequired()
                    .HasColumnName("search_text")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.RPrj)
                    .WithOne(p => p.ProjectSearchData)
                    .HasForeignKey<ProjectSearchData>(d => d.RPrjId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_project_search_data_project");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.ToTable("project_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.ToTable("project_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<QaSuspension>(entity =>
            {
                entity.ToTable("qa_suspension");

                entity.HasIndex(e => e.NeedsReview)
                    .HasName("IX_qa_suspension");

                entity.HasIndex(e => new { e.RQasId, e.Closed })
                    .HasName("IX_qa_suspension_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstimatedCancel)
                    .HasColumnName("estimated_cancel")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastStatusDate)
                    .HasColumnName("last_status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NeedsReview)
                    .HasColumnName("needs_review")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NextReminder)
                    .HasColumnName("next_reminder")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NumReminders).HasColumnName("num_reminders");

                entity.Property(e => e.RCreatedPerId).HasColumnName("r_created_per_id");

                entity.Property(e => e.RPqmPerId).HasColumnName("r_pqm_per_id");

                entity.Property(e => e.RQasId).HasColumnName("r_qas_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.ReminderPauseDays).HasColumnName("reminder_pause_days");

                entity.Property(e => e.RemindersAdded)
                    .HasColumnName("reminders_added")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Supc)
                    .HasColumnName("supc")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RCreatedPer)
                    .WithMany(p => p.QaSuspensionRCreatedPer)
                    .HasForeignKey(d => d.RCreatedPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_qa_suspension_person1");

                entity.HasOne(d => d.RPqmPer)
                    .WithMany(p => p.QaSuspensionRPqmPer)
                    .HasForeignKey(d => d.RPqmPerId)
                    .HasConstraintName("FK_qa_suspension_person");

                entity.HasOne(d => d.RQas)
                    .WithMany(p => p.QaSuspension)
                    .HasForeignKey(d => d.RQasId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_qa_suspension_qa_suspension_state");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.QaSuspension)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_qa_suspension_supplier");
            });

            modelBuilder.Entity<QaSuspensionState>(entity =>
            {
                entity.ToTable("qa_suspension_state");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumReminders).HasColumnName("num_reminders");

                entity.Property(e => e.ReminderPauseDays).HasColumnName("reminder_pause_days");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("question");

                entity.HasIndex(e => new { e.RQdgId, e.RTskId })
                    .HasName("IX_question");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataFetchAction)
                    .HasColumnName("data_fetch_action")
                    .HasMaxLength(500);

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.IsRequired)
                    .HasColumnName("is_required")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsUiRequired)
                    .HasColumnName("is_ui_required")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostCompleteAction)
                    .HasColumnName("post_complete_action")
                    .HasMaxLength(500);

                entity.Property(e => e.Prompt)
                    .HasColumnName("prompt")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.RQdgId).HasColumnName("r_qdg_id");

                entity.Property(e => e.RQtyId).HasColumnName("r_qty_id");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.Property(e => e.ReportingDisplay)
                    .HasColumnName("reporting_display")
                    .HasMaxLength(500);

                entity.HasOne(d => d.RQdg)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.RQdgId)
                    .HasConstraintName("FK_question_question_display_group");

                entity.HasOne(d => d.RQty)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.RQtyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_question_question_type");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_task_activity");
            });

            modelBuilder.Entity<QuestionDisplayGroup>(entity =>
            {
                entity.ToTable("question_display_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasColumnName("heading")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("question_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ReviewSummary>(entity =>
            {
                entity.HasKey(e => new { e.RPkgId, e.RRevId })
                    .HasName("PK_review_summary");

                entity.ToTable("review_summary");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("summary")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.ReviewSummary)
                    .HasForeignKey(d => d.RPkgId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_review_summary_package");

                entity.HasOne(d => d.RRev)
                    .WithMany(p => p.ReviewSummary)
                    .HasForeignKey(d => d.RRevId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_review_summary_package_revision");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.HasIndex(e => new { e.OldRoleLabel, e.Id })
                    .HasName("IX_tmp");

                entity.HasIndex(e => new { e.RRtyId, e.AcrossRevision })
                    .HasName("IX_role_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcrossRevision)
                    .HasColumnName("across_revision")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasCandidates).HasColumnName("has_candidates");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OldRoleLabel)
                    .HasColumnName("old_role_label")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RRtyId)
                    .HasColumnName("r_rty_id")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.RRty)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.RRtyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_role_role_type");
            });

            modelBuilder.Entity<RoleCandidates>(entity =>
            {
                entity.HasKey(e => new { e.RPerId, e.RRolId })
                    .HasName("PK_person_role_group");

                entity.ToTable("role_candidates");

                entity.HasIndex(e => e.RSupId)
                    .HasName("IX_role_candidates");

                entity.Property(e => e.RPerId).HasColumnName("r_per_id");

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.HasOne(d => d.RPer)
                    .WithMany(p => p.RoleCandidates)
                    .HasForeignKey(d => d.RPerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_role_group_person");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.RoleCandidates)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_person_role_group_role");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.RoleCandidates)
                    .HasForeignKey(d => d.RSupId)
                    .HasConstraintName("FK_role_candidates_supplier");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.ToTable("role_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.HasIndex(e => e.QaDbFeePaidDate)
                    .HasName("IX_supplier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.OldUserGroupId).HasColumnName("old_user_group_id");

                entity.Property(e => e.Oldid).HasColumnName("oldid");

                entity.Property(e => e.QaDbFeePaidDate)
                    .HasColumnName("qa_db_fee_paid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RAdrId).HasColumnName("r_adr_id");

                entity.Property(e => e.RPerContactId).HasColumnName("r_per_contact_id");

                entity.Property(e => e.RSbaId).HasColumnName("r_sba_id");

                entity.Property(e => e.RStsId).HasColumnName("r_sts_id");

                entity.Property(e => e.RStyId).HasColumnName("r_sty_id");

                entity.Property(e => e.RSupParentId).HasColumnName("r_sup_parent_id");

                entity.Property(e => e.SyscoOwned).HasColumnName("sysco_owned");

                entity.HasOne(d => d.RAdr)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RAdrId)
                    .HasConstraintName("FK_supplier_address");

                entity.HasOne(d => d.RPerContact)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RPerContactId)
                    .HasConstraintName("FK_supplier_person");

                entity.HasOne(d => d.RSba)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RSbaId)
                    .HasConstraintName("FK_supplier_supplier_operation");

                entity.HasOne(d => d.RSts)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RStsId)
                    .HasConstraintName("FK_suppplier_supplier_status");

                entity.HasOne(d => d.RSty)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RStyId)
                    .HasConstraintName("FK_supplier_supplier_type");

                entity.HasOne(d => d.RSupParent)
                    .WithMany(p => p.InverseRSupParent)
                    .HasForeignKey(d => d.RSupParentId)
                    .HasConstraintName("fk_supplier_supplier");
            });

            modelBuilder.Entity<SupplierInvoice>(entity =>
            {
                entity.ToTable("supplier_invoice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adjustment)
                    .HasColumnName("adjustment")
                    .HasColumnType("money");

                entity.Property(e => e.CheckFileName)
                    .HasColumnName("check_file_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("invoice_amount")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("payment_amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RInvStatusId).HasColumnName("r_inv_status_id");

                entity.Property(e => e.RPerCreatedId).HasColumnName("r_per_created_id");

                entity.Property(e => e.RPerUpdatedId).HasColumnName("r_per_updated_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.SecondNotice)
                    .HasColumnName("second_notice")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThirdNotice)
                    .HasColumnName("third_notice")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RInvStatus)
                    .WithMany(p => p.SupplierInvoice)
                    .HasForeignKey(d => d.RInvStatusId)
                    .HasConstraintName("FK_supplier_invoice_invoice_status");

                entity.HasOne(d => d.RPerCreated)
                    .WithMany(p => p.SupplierInvoiceRPerCreated)
                    .HasForeignKey(d => d.RPerCreatedId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_supplier_invoice_person");

                entity.HasOne(d => d.RPerUpdated)
                    .WithMany(p => p.SupplierInvoiceRPerUpdated)
                    .HasForeignKey(d => d.RPerUpdatedId)
                    .HasConstraintName("FK_supplier_invoice_person1");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.SupplierInvoice)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_supplier_invoice_supplier");
            });

            modelBuilder.Entity<SupplierOperation>(entity =>
            {
                entity.ToTable("supplier_operation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<SupplierStatus>(entity =>
            {
                entity.ToTable("supplier_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SupplierStatusLog>(entity =>
            {
                entity.ToTable("supplier_status_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.RPkgId).HasColumnName("r_pkg_id");

                entity.Property(e => e.RRevId).HasColumnName("r_rev_id");

                entity.Property(e => e.RStsId).HasColumnName("r_sts_id");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.HasOne(d => d.RPkg)
                    .WithMany(p => p.SupplierStatusLog)
                    .HasForeignKey(d => d.RPkgId)
                    .HasConstraintName("FK_supplier_status_log_package");

                entity.HasOne(d => d.RRev)
                    .WithMany(p => p.SupplierStatusLog)
                    .HasForeignKey(d => d.RRevId)
                    .HasConstraintName("FK_supplier_status_log_package_revision");

                entity.HasOne(d => d.RSts)
                    .WithMany(p => p.SupplierStatusLog)
                    .HasForeignKey(d => d.RStsId)
                    .HasConstraintName("FK_supplier_status_log_supplier_status");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.SupplierStatusLog)
                    .HasForeignKey(d => d.RSupId)
                    .HasConstraintName("FK_supplier_status_log_supplier");
            });

            modelBuilder.Entity<SupplierSuvc>(entity =>
            {
                entity.HasKey(e => new { e.RSupId, e.Suvc })
                    .HasName("PK_supplier_suvc");

                entity.ToTable("supplier_suvc");

                entity.Property(e => e.RSupId).HasColumnName("r_sup_id");

                entity.Property(e => e.Suvc)
                    .HasColumnName("suvc")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RSup)
                    .WithMany(p => p.SupplierSuvc)
                    .HasForeignKey(d => d.RSupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_supplier_suvc_supplier");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.ToTable("supplier_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<SupportingFile>(entity =>
            {
                entity.ToTable("supporting_file");

                entity.HasIndex(e => e.RArtId)
                    .HasName("IX_supporting_file");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InternalFileName)
                    .IsRequired()
                    .HasColumnName("internal_file_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RArtId).HasColumnName("r_art_id");

                entity.HasOne(d => d.RArt)
                    .WithMany(p => p.SupportingFile)
                    .HasForeignKey(d => d.RArtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_supporting_file_artwork");
            });

            modelBuilder.Entity<TableAbbreviation>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.Abbreviation })
                    .HasName("PK_table_abbreviation");

                entity.ToTable("table_abbreviation");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Abbreviation)
                    .HasColumnName("abbreviation")
                    .HasColumnType("varchar(4)");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("task");

                entity.HasIndex(e => new { e.RRolId, e.RTtyId })
                    .HasName("IX_task");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DaysToComplete)
                    .HasColumnName("days_to_complete")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DaysToWarn)
                    .HasColumnName("days_to_warn")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.PostCompleteAction)
                    .HasColumnName("post_complete_action")
                    .HasMaxLength(500);

                entity.Property(e => e.RRolId).HasColumnName("r_rol_id");

                entity.Property(e => e.RTtyId)
                    .HasColumnName("r_tty_id")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.RushDaysToComplete)
                    .HasColumnName("rush_days_to_complete")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RushDaysToWarn)
                    .HasColumnName("rush_days_to_warn")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.RRol)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.RRolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_task_role1");

                entity.HasOne(d => d.RTty)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.RTtyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_task_task_type");
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.ToTable("task_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.ToTable("task_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsSystem)
                    .HasColumnName("is_system")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ThumbnailType>(entity =>
            {
                entity.ToTable("thumbnail_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<WorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.RTskId, e.ProcessKey, e.RTskParentId })
                    .HasName("PK_workflow");

                entity.ToTable("work_flow");

                entity.Property(e => e.RTskId).HasColumnName("r_tsk_id");

                entity.Property(e => e.ProcessKey)
                    .HasColumnName("process_key")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RTskParentId).HasColumnName("r_tsk_parent_id");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("varchar(4000)");

                entity.HasOne(d => d.RTsk)
                    .WithMany(p => p.WorkFlowRTsk)
                    .HasForeignKey(d => d.RTskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_workflow_task");

                entity.HasOne(d => d.RTskParent)
                    .WithMany(p => p.WorkFlowRTskParent)
                    .HasForeignKey(d => d.RTskParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_workflow_task1");
            });
        }
    }
}