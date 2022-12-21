using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bex.Models
{
    public partial class Modelx : DbContext
    {
        public Modelx()
        {
        }

        public Modelx(DbContextOptions<Modelx> options)
            : base(options)
        {
        }

        public virtual DbSet<AddOrRemoveEmailTrail> AddOrRemoveEmailTrails { get; set; }
        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<AppPostDetail> AppPostDetails { get; set; }
        public virtual DbSet<AppPostDetailOld> AppPostDetailOlds { get; set; }
        public virtual DbSet<AppPostDetailPool> AppPostDetailPools { get; set; }
        public virtual DbSet<AppPostDetailTest> AppPostDetailTests { get; set; }
        public virtual DbSet<AppPostMaster> AppPostMasters { get; set; }
        public virtual DbSet<AppPostMasterPool> AppPostMasterPools { get; set; }
        public virtual DbSet<BracnhesEmailTrailLog> BracnhesEmailTrailLogs { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchesListTextFile> BranchesListTextFiles { get; set; }
        public virtual DbSet<BranchesTemp> BranchesTemps { get; set; }
        public virtual DbSet<BulkBracnhesEmailTrailLog> BulkBracnhesEmailTrailLogs { get; set; }
        public virtual DbSet<BulkBranchFileSummary> BulkBranchFileSummaries { get; set; }
        public virtual DbSet<BulkBtfileSummary> BulkBtfileSummaries { get; set; }
        public virtual DbSet<BulkBthuddleFileSummary> BulkBthuddleFileSummaries { get; set; }
        public virtual DbSet<BulkEmailListSource> BulkEmailListSources { get; set; }
        public virtual DbSet<BulkFileSummary> BulkFileSummaries { get; set; }
        public virtual DbSet<BulkUploadLog> BulkUploadLogs { get; set; }
        public virtual DbSet<Bulkupload> Bulkuploads { get; set; }
        public virtual DbSet<BulkuploadBtmorningHuddle> BulkuploadBtmorningHuddles { get; set; }
        public virtual DbSet<BulkuploadBttrail> BulkuploadBttrails { get; set; }
        public virtual DbSet<BulkuploadBtytd> BulkuploadBtytds { get; set; }
        public virtual DbSet<CategoryType> CategoryTypes { get; set; }
        public virtual DbSet<CheckList> CheckLists { get; set; }
        public virtual DbSet<CheckListCategory> CheckListCategories { get; set; }
        public virtual DbSet<CheckListEmailTemplate> CheckListEmailTemplates { get; set; }
        public virtual DbSet<CheckerListMasterDetail> CheckerListMasterDetails { get; set; }
        public virtual DbSet<EmailListing> EmailListings { get; set; }
        public virtual DbSet<EmailListingDelete> EmailListingDeletes { get; set; }
        public virtual DbSet<MakerCheckerNotificationLog> MakerCheckerNotificationLogs { get; set; }
        public virtual DbSet<MarkingCriterion> MarkingCriteria { get; set; }
        public virtual DbSet<MobileAppRegistration> MobileAppRegistrations { get; set; }
        public virtual DbSet<SubCategoryField> SubCategoryFields { get; set; }
        public virtual DbSet<TblAppUser> TblAppUsers { get; set; }
        public virtual DbSet<TblArea> TblAreas { get; set; }
        public virtual DbSet<TblBranchObservarrionSummary> TblBranchObservarrionSummaries { get; set; }
        public virtual DbSet<TblBusinessRegion> TblBusinessRegions { get; set; }
        public virtual DbSet<TblCategoryAttribute> TblCategoryAttributes { get; set; }
        public virtual DbSet<TblCategorySubAttribute> TblCategorySubAttributes { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblComment> TblComments { get; set; }
        public virtual DbSet<TblCommentSubAttribute> TblCommentSubAttributes { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblDesignation> TblDesignations { get; set; }
        public virtual DbSet<TblEmailLog> TblEmailLogs { get; set; }
        public virtual DbSet<TblEmailSenderConfig> TblEmailSenderConfigs { get; set; }
        public virtual DbSet<TblEmailTemplate> TblEmailTemplates { get; set; }
        public virtual DbSet<TblFileTransferRefrence> TblFileTransferRefrences { get; set; }
        public virtual DbSet<TblMakerCheckerNotification> TblMakerCheckerNotifications { get; set; }
        public virtual DbSet<TblNotification> TblNotifications { get; set; }
        public virtual DbSet<TblNotificationConfig> TblNotificationConfigs { get; set; }
        public virtual DbSet<TblNotificationLog> TblNotificationLogs { get; set; }
        public virtual DbSet<TblNotificationRolewise> TblNotificationRolewises { get; set; }
        public virtual DbSet<TblNotificationUpdateIssueLog> TblNotificationUpdateIssueLogs { get; set; }
        public virtual DbSet<TblPage> TblPages { get; set; }
        public virtual DbSet<TblPriLoungeScore> TblPriLoungeScores { get; set; }
        public virtual DbSet<TblPrivilege> TblPrivileges { get; set; }
        public virtual DbSet<TblRegion> TblRegions { get; set; }
        public virtual DbSet<TblRight> TblRights { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblSubAttEmailCriterion> TblSubAttEmailCriteria { get; set; }
        public virtual DbSet<TblUpdateEntryLog> TblUpdateEntryLogs { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserPasswordHistory> TblUserPasswordHistories { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<VerficationKey> VerficationKeys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.20.38; Initial Catalog=Alfalah_Bex; user id=sa; password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddOrRemoveEmailTrail>(entity =>
            {
                entity.ToTable("addOrRemoveEmailTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsUnicode(false)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.EmailListType).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.Operationtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operationtype");
            });

            modelBuilder.Entity<AppLog>(entity =>
            {
                entity.ToTable("AppLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<AppPostDetail>(entity =>
            {
                entity.ToTable("AppPostDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndoredDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasColumnName("Image_Path");

                entity.Property(e => e.MarkingCriteria).HasMaxLength(150);

                entity.Property(e => e.MarkingCriteriaId).HasColumnName("MarkingCriteriaID");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Rating).IsRequired();

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<AppPostDetailOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppPostDetail_OLD");

                entity.HasIndex(e => e.SubCategoryId, "idx_SubCatId");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath).HasColumnName("Image_Path");

                entity.Property(e => e.MarkingCriteria).HasMaxLength(150);

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Rating).IsRequired();

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<AppPostDetailPool>(entity =>
            {
                entity.ToTable("AppPostDetail_Pool");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndoredDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasColumnName("Image_Path");

                entity.Property(e => e.MarkingCriteria).HasMaxLength(150);

                entity.Property(e => e.MarkingCriteriaId).HasColumnName("MarkingCriteriaID");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Rating).IsRequired();

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<AppPostDetailTest>(entity =>
            {
                entity.ToTable("AppPostDetailTest");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasColumnName("Image_Path");

                entity.Property(e => e.MarkingCriteria).HasMaxLength(150);

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Rating).IsRequired();

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<AppPostMaster>(entity =>
            {
                entity.ToTable("AppPostMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddRecipent)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Directory).HasMaxLength(250);

                entity.Property(e => e.MarkingCriteria).HasMaxLength(50);

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostedOnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppPostMasterPool>(entity =>
            {
                entity.ToTable("AppPostMaster_Pool");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branchId");

                entity.Property(e => e.CheckListInfoMaker)
                    .IsRequired()
                    .HasColumnName("checkListInfoMaker");

                entity.Property(e => e.CheckListinfoChecker).HasColumnName("checkListinfoChecker");

                entity.Property(e => e.CheckerId).HasColumnName("checkerId");

                entity.Property(e => e.CheckerPostId).HasColumnName("checkerPostId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status");
            });

            modelBuilder.Entity<BracnhesEmailTrailLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrArea).HasColumnName("brArea");

                entity.Property(e => e.BrCode).HasColumnName("brCode");

                entity.Property(e => e.BrLatitude).HasColumnName("brLatitude");

                entity.Property(e => e.BrLongitude).HasColumnName("brLongitude");

                entity.Property(e => e.BrName).HasColumnName("brName");

                entity.Property(e => e.BrRegion).HasColumnName("brRegion");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("createdOn");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.AreaId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Atmid)
                    .HasMaxLength(50)
                    .HasColumnName("ATMID");

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.BusinessRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessRegionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OnsiteOffsite)
                    .HasMaxLength(100)
                    .HasColumnName("Onsite_Offsite");

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BranchesListTextFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BranchesListTextFile");

                entity.Property(e => e.Bcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCode");

                entity.Property(e => e.Email)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BranchesTemp>(entity =>
            {
                entity.ToTable("Branches_Temp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.Atmid)
                    .HasMaxLength(50)
                    .HasColumnName("ATMID");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.BusinessRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Region).HasMaxLength(50);
            });

            modelBuilder.Entity<BulkBracnhesEmailTrailLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrArea).HasColumnName("brArea");

                entity.Property(e => e.BrCode).HasColumnName("brCode");

                entity.Property(e => e.BrLatitude).HasColumnName("brLatitude");

                entity.Property(e => e.BrLongitude).HasColumnName("brLongitude");

                entity.Property(e => e.BrName).HasColumnName("brName");

                entity.Property(e => e.BrRegion).HasColumnName("brRegion");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("createdOn");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<BulkBranchFileSummary>(entity =>
            {
                entity.ToTable("BulkBranchFileSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InValidlongitudeLatitude).HasColumnName("inValidlongitudeLatitude");

                entity.Property(e => e.InvalidRegion).HasColumnName("invalidRegion");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");

                entity.Property(e => e.ValidlongitudeLatitude).HasColumnName("validlongitudeLatitude");
            });

            modelBuilder.Entity<BulkBtfileSummary>(entity =>
            {
                entity.ToTable("BulkBTFileSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BulkBthuddleFileSummary>(entity =>
            {
                entity.ToTable("BulkBTHuddleFileSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BulkEmailListSource>(entity =>
            {
                entity.ToTable("BulkEmailListSource");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.ProcessingStatus).HasMaxLength(50);

                entity.Property(e => e.UploadFileName).HasMaxLength(150);
            });

            modelBuilder.Entity<BulkFileSummary>(entity =>
            {
                entity.ToTable("BulkFileSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BulkUploadLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BulkUploadLog");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress).HasMaxLength(1000);

                entity.Property(e => e.EmailListType).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Reason).HasMaxLength(1000);

                entity.Property(e => e.Role)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bulkupload>(entity =>
            {
                entity.ToTable("bulkupload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Checklistname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("checklistname");

                entity.Property(e => e.Subattribute)
                    .IsUnicode(false)
                    .HasColumnName("subattribute");

                entity.Property(e => e.UploadedBy).HasColumnName("uploadedBy");

                entity.Property(e => e.UploadedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadedOn");

                entity.Property(e => e.Ytd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ytd");
            });

            modelBuilder.Entity<BulkuploadBtmorningHuddle>(entity =>
            {
                entity.ToTable("bulkuploadBTMorningHuddle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Checklistname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("checklistname");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.SubAttrId).HasColumnName("subAttrId");

                entity.Property(e => e.UploadedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadedOn");

                entity.Property(e => e.Ytd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ytd");
            });

            modelBuilder.Entity<BulkuploadBttrail>(entity =>
            {
                entity.ToTable("bulkuploadBTtrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Checklistname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("checklistname");

                entity.Property(e => e.Subattribute)
                    .IsUnicode(false)
                    .HasColumnName("subattribute");

                entity.Property(e => e.UploadedBy).HasColumnName("uploadedBy");

                entity.Property(e => e.UploadedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadedOn");

                entity.Property(e => e.Ytd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ytd");
            });

            modelBuilder.Entity<BulkuploadBtytd>(entity =>
            {
                entity.ToTable("bulkuploadBTYtd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Checklistname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("checklistname");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.UploadedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadedOn");

                entity.Property(e => e.Ytd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ytd");
            });

            modelBuilder.Entity<CategoryType>(entity =>
            {
                entity.ToTable("CategoryType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryType1)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CheckList>(entity =>
            {
                entity.ToTable("CheckList");

                entity.Property(e => e.Approvalrequired)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("approvalrequired");

                entity.Property(e => e.CheckListName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckListCategory>(entity =>
            {
                entity.ToTable("CheckListCategory");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListCategories)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CheckList__Check__0A338187");
            });

            modelBuilder.Entity<CheckListEmailTemplate>(entity =>
            {
                entity.ToTable("CheckListEmailTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CheckerListMasterDetail>(entity =>
            {
                entity.ToTable("Checker_ListMasterDetails");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckListInfoMaker)
                    .IsRequired()
                    .HasColumnName("checkListInfoMaker");

                entity.Property(e => e.CheckListinfoChecker).HasColumnName("checkListinfoChecker");

                entity.Property(e => e.CheckerId).HasColumnName("checkerId");

                entity.Property(e => e.CheckerPostId).HasColumnName("checkerPostId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.MakerPostId).HasColumnName("makerPostId");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status");
            });

            modelBuilder.Entity<EmailListing>(entity =>
            {
                entity.ToTable("EmailListing");

                entity.Property(e => e.BranchId).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EmailListType).HasMaxLength(50);

                entity.Property(e => e.ExtraRecipientEmailAddress).HasMaxLength(500);

                entity.Property(e => e.InputterType).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailListingDelete>(entity =>
            {
                entity.ToTable("EmailListing_Delete");

                entity.Property(e => e.BranchId).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EmailListType).HasMaxLength(50);

                entity.Property(e => e.ExtraRecipientEmailAddress).HasMaxLength(500);

                entity.Property(e => e.InputterType).HasMaxLength(50);
            });

            modelBuilder.Entity<MakerCheckerNotificationLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasColumnName("deviceId");

                entity.Property(e => e.NotificationBody)
                    .IsRequired()
                    .HasColumnName("notificationBody");

                entity.Property(e => e.NotificationTitle)
                    .IsRequired()
                    .HasColumnName("notificationTitle");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasColumnName("postId");

                entity.Property(e => e.Request)
                    .IsRequired()
                    .HasColumnName("request");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result");
            });

            modelBuilder.Entity<MarkingCriterion>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<MobileAppRegistration>(entity =>
            {
                entity.ToTable("MobileAppRegistration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Ischeck)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ischeck");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
            });

            modelBuilder.Entity<SubCategoryField>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<TblAppUser>(entity =>
            {
                entity.ToTable("Tbl_AppUser");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("createdOn");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FullName).HasColumnName("fullName");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedOn");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName");

                entity.Property(e => e.UserType).HasColumnName("userType");
            });

            modelBuilder.Entity<TblArea>(entity =>
            {
                entity.ToTable("Tbl_Area");

                entity.Property(e => e.BusinessRegionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBranchObservarrionSummary>(entity =>
            {
                entity.ToTable("Tbl_BranchObservarrionSummary");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmberMarked).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ObservationType).HasMaxLength(50);

                entity.Property(e => e.RedMarked).HasMaxLength(50);

                entity.Property(e => e.Year).HasMaxLength(10);
            });

            modelBuilder.Entity<TblBusinessRegion>(entity =>
            {
                entity.ToTable("Tbl_BusinessRegion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblCategoryAttribute>(entity =>
            {
                entity.ToTable("TblCategory_Attribute");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CkId).HasColumnName("Ck_Id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MarkingCriteria).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Totalscore)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("totalscore");

                entity.HasOne(d => d.Ck)
                    .WithMany(p => p.TblCategoryAttributes)
                    .HasForeignKey(d => d.CkId)
                    .HasConstraintName("FK_TblCategory_Attribute_CategoryType");
            });

            modelBuilder.Entity<TblCategorySubAttribute>(entity =>
            {
                entity.ToTable("TblCategory_SubAttribute");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubAttribute).IsRequired();
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.ToTable("Tbl_City");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblComment>(entity =>
            {
                entity.ToTable("Tbl_Comments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeId).HasColumnName("attributeId");

                entity.Property(e => e.ChecklistId).HasColumnName("checklistId");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SubAttributeid).HasColumnName("subAttributeid");
            });

            modelBuilder.Entity<TblCommentSubAttribute>(entity =>
            {
                entity.ToTable("Tbl_Comment_SubAttribute");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AomMarking).HasMaxLength(50);

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubAttributeId).HasColumnName("SubAttributeID");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartName).HasMaxLength(50);

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.ToTable("Tbl_Designation");

                entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<TblEmailLog>(entity =>
            {
                entity.ToTable("tbl_EmailLogs");

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailSubject).HasMaxLength(100);

                entity.Property(e => e.SendOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.ToEmail).HasMaxLength(200);
            });

            modelBuilder.Entity<TblEmailSenderConfig>(entity =>
            {
                entity.ToTable("Tbl_EmailSenderConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailSubject).HasMaxLength(100);

                entity.Property(e => e.PostId).HasMaxLength(200);

                entity.Property(e => e.ToEmail).HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TblEmailTemplate>(entity =>
            {
                entity.ToTable("tbl_EmailTemplate");

                entity.Property(e => e.ChecklistId).HasColumnName("Checklist_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TemplateName).HasMaxLength(50);

                entity.Property(e => e.TemplateSubject).HasMaxLength(100);

                entity.HasOne(d => d.Checklist)
                    .WithMany(p => p.TblEmailTemplates)
                    .HasForeignKey(d => d.ChecklistId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbl_Email__Check__220B0B18");
            });

            modelBuilder.Entity<TblFileTransferRefrence>(entity =>
            {
                entity.ToTable("Tbl_FileTransferRefrences");

                entity.Property(e => e.CopiedOn).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(1000);

                entity.Property(e => e.DirectoryName).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(1000);
            });

            modelBuilder.Entity<TblMakerCheckerNotification>(entity =>
            {
                entity.ToTable("tbl_MakerCheckerNotification");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branchId");

                entity.Property(e => e.CheckListId).HasColumnName("checkListId");

                entity.Property(e => e.CheckerId).HasColumnName("checkerId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsSent).HasColumnName("isSent");

                entity.Property(e => e.MakerId).HasColumnName("makerId");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.NotificationId).HasColumnName("notificationId");

                entity.Property(e => e.NotificationMessage).HasColumnName("notificationMessage");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TblNotification>(entity =>
            {
                entity.ToTable("Tbl_Notification");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasColumnName("PostID");

                entity.Property(e => e.SentOnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNotificationConfig>(entity =>
            {
                entity.ToTable("tbl_NotificationConfig");

                entity.Property(e => e.NotificationTitle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblNotificationLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Notification_Logs");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.FireBaseResponse)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<TblNotificationRolewise>(entity =>
            {
                entity.ToTable("Tbl_Notification_Rolewise");
            });

            modelBuilder.Entity<TblNotificationUpdateIssueLog>(entity =>
            {
                entity.ToTable("tbl_NotificationUpdateIssueLogs");

                entity.Property(e => e.EndorsedComment).HasMaxLength(250);

                entity.Property(e => e.EndorsedDate).HasColumnType("datetime");

                entity.Property(e => e.PostId).IsRequired();

                entity.Property(e => e.ResolvedComment).HasMaxLength(250);

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPage>(entity =>
            {
                entity.ToTable("TBl_Pages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.MethodName).HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<TblPriLoungeScore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_pri_lounge_score");

                entity.Property(e => e.Checklistid).HasColumnName("checklistid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Posteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("posteddate");

                entity.Property(e => e.Postid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("postid");

                entity.Property(e => e.Score)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("score");

                entity.Property(e => e.TotalScore).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblPrivilege>(entity =>
            {
                entity.ToTable("Tbl_Privileges");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifieOn).HasColumnType("datetime");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.TblPrivileges)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Privileges_TBl_Pages");
            });

            modelBuilder.Entity<TblRegion>(entity =>
            {
                entity.ToTable("Tbl_Region");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CityId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRight>(entity =>
            {
                entity.ToTable("Tbl_Rights");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Rights).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("Tbl_Role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Role).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSubAttEmailCriterion>(entity =>
            {
                entity.ToTable("Tbl_SubAttEmailCriteria");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.HasOne(d => d.SubAtt)
                    .WithMany(p => p.TblSubAttEmailCriteria)
                    .HasForeignKey(d => d.SubAttId)
                    .HasConstraintName("FK_Tbl_SubAttEmailCriteria_TblCategory_SubAttribute");
            });

            modelBuilder.Entity<TblUpdateEntryLog>(entity =>
            {
                entity.ToTable("Tbl_UpdateEntryLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("Tbl_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.IsPortalLogin)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("isPortalLogin");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_User_Tbl_Role");
            });

            modelBuilder.Entity<TblUserPasswordHistory>(entity =>
            {
                entity.ToTable("tbl_UserPasswordHistory");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(350);

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.ToTable("Temp");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VerficationKey>(entity =>
            {
                entity.ToTable("VerficationKey");

                entity.Property(e => e.CreatedByName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.VerificationKey)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.VerificationType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
