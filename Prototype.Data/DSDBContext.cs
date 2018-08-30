using System;
using Prototype.Data.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Prototype.Data
{
    public partial class DSDBContext : DbContext
    {
        public DSDBContext()
        {
        }

        public DSDBContext(DbContextOptions<DSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppCompositeRole> AppCompositeRole { get; set; }
        public virtual DbSet<AppCompositeRoleItem> AppCompositeRoleItem { get; set; }
        public virtual DbSet<AppDocumentNo> AppDocumentNo { get; set; }
        public virtual DbSet<AppLog> AppLog { get; set; }
        public virtual DbSet<AppMenu> AppMenu { get; set; }
        public virtual DbSet<AppSingleRole> AppSingleRole { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<AuthorityCompany> AuthorityCompany { get; set; }
        public virtual DbSet<BoardUser> BoardUser { get; set; }
        public virtual DbSet<Bs> Bs { get; set; }
        public virtual DbSet<Bscompany> Bscompany { get; set; }
        public virtual DbSet<Bspayee> Bspayee { get; set; }
        public virtual DbSet<Bssigner> Bssigner { get; set; }
        public virtual DbSet<Ca> Ca { get; set; }
        public virtual DbSet<Careceive> Careceive { get; set; }
        public virtual DbSet<CompanyBankInfo> CompanyBankInfo { get; set; }
        public virtual DbSet<CompanyManager> CompanyManager { get; set; }
        public virtual DbSet<CompanyManagerItem> CompanyManagerItem { get; set; }
        public virtual DbSet<ConfigureValue> ConfigureValue { get; set; }
        public virtual DbSet<ConnectionLog> ConnectionLog { get; set; }
        public virtual DbSet<CostCenter> CostCenter { get; set; }
        public virtual DbSet<CostCenterManager> CostCenterManager { get; set; }
        public virtual DbSet<CostCenterManagerItem> CostCenterManagerItem { get; set; }
        public virtual DbSet<EmailTask> EmailTask { get; set; }
        public virtual DbSet<EmailTaskContent> EmailTaskContent { get; set; }
        public virtual DbSet<EmailTaskReceiver> EmailTaskReceiver { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<ExecutiveUser> ExecutiveUser { get; set; }
        public virtual DbSet<HolidayCalendar> HolidayCalendar { get; set; }
        public virtual DbSet<HrbusinessPlace> HrbusinessPlace { get; set; }
        public virtual DbSet<Hrcompany> Hrcompany { get; set; }
        public virtual DbSet<Hremployee> Hremployee { get; set; }
        public virtual DbSet<HremployeeMobile> HremployeeMobile { get; set; }
        public virtual DbSet<Hrorg> Hrorg { get; set; }
        public virtual DbSet<HrorgRelation> HrorgRelation { get; set; }
        public virtual DbSet<Hrposition> Hrposition { get; set; }
        public virtual DbSet<Otp> Otp { get; set; }
        public virtual DbSet<Pv> Pv { get; set; }
        public virtual DbSet<PvactivitySap> PvactivitySap { get; set; }
        public virtual DbSet<Pvgroup> Pvgroup { get; set; }
        public virtual DbSet<PvgroupItem> PvgroupItem { get; set; }
        public virtual DbSet<Pvitem> Pvitem { get; set; }
        public virtual DbSet<PvitemSap> PvitemSap { get; set; }
        public virtual DbSet<Pvsap> Pvsap { get; set; }
        public virtual DbSet<RespGroup> RespGroup { get; set; }
        public virtual DbSet<RespGroupAdmin> RespGroupAdmin { get; set; }
        public virtual DbSet<RespGroupComp> RespGroupComp { get; set; }
        public virtual DbSet<RespGroupEmp> RespGroupEmp { get; set; }
        public virtual DbSet<RespGroupOrg> RespGroupOrg { get; set; }
        public virtual DbSet<ReviewManager> ReviewManager { get; set; }
        public virtual DbSet<ReviewManagerItem> ReviewManagerItem { get; set; }
        public virtual DbSet<UserPostal> UserPostal { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<ValueHelp> ValueHelp { get; set; }
        public virtual DbSet<WorkflowActivityLog> WorkflowActivityLog { get; set; }
        public virtual DbSet<WorkflowActivityStep> WorkflowActivityStep { get; set; }
        public virtual DbSet<WorkflowDelegate> WorkflowDelegate { get; set; }
        public virtual DbSet<WorkflowProcess> WorkflowProcess { get; set; }
        public virtual DbSet<WorkflowProcessInstance> WorkflowProcessInstance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppCompositeRole>(entity =>
            {
                entity.ToTable("AppCompositeRole", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.LastModifyBy).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<AppCompositeRoleItem>(entity =>
            {
                entity.ToTable("AppCompositeRoleItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompositeRoleId).HasColumnName("CompositeRoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AppDocumentNo>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.Year, e.Additional01, e.Additional02, e.Additional03 });

                entity.ToTable("AppDocumentNo", "ds");

                entity.Property(e => e.ProcessCode).HasMaxLength(100);

                entity.Property(e => e.Additional01).HasMaxLength(20);

                entity.Property(e => e.Additional02).HasMaxLength(20);

                entity.Property(e => e.Additional03).HasMaxLength(20);

                entity.Property(e => e.DocumentNoPrefix).HasMaxLength(50);
            });

            modelBuilder.Entity<AppLog>(entity =>
            {
                entity.ToTable("AppLog", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogBy).HasMaxLength(200);

                entity.Property(e => e.Method).HasMaxLength(200);
            });

            modelBuilder.Entity<AppMenu>(entity =>
            {
                entity.HasKey(e => e.MenuCode);

                entity.ToTable("AppMenu", "ds");

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.Controller).HasMaxLength(100);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.MenuType).HasMaxLength(20);

                entity.Property(e => e.ParentMenuCode).HasMaxLength(100);

                entity.Property(e => e.ResourceName).HasMaxLength(200);

                entity.Property(e => e.RoleForDisplay).HasMaxLength(100);

                entity.Property(e => e.RoleForManage).HasMaxLength(100);
            });

            modelBuilder.Entity<AppSingleRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("AppSingleRole", "ds");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachBy).HasMaxLength(100);

                entity.Property(e => e.AttachmentGroup).HasMaxLength(100);

                entity.Property(e => e.DataKey).HasMaxLength(100);

                entity.Property(e => e.DocumentType).HasMaxLength(20);

                entity.Property(e => e.FileExtension).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FileUniqueKey).HasMaxLength(100);

                entity.Property(e => e.MimeType).HasMaxLength(200);

                entity.Property(e => e.ProcessCode).HasMaxLength(100);

                entity.Property(e => e.SavedFileName).HasMaxLength(200);
            });

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.ToTable("Authority", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmpNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark1).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Remark2).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Remark3).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Remark4).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Remark5).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<AuthorityCompany>(entity =>
            {
                entity.ToTable("AuthorityCompany", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aduser)
                    .HasColumnName("ADUser")
                    .HasMaxLength(100);

                entity.Property(e => e.Brb).HasColumnName("BRB");

                entity.Property(e => e.Brt).HasColumnName("BRT");

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.Sco).HasColumnName("SCO");
            });

            modelBuilder.Entity<BoardUser>(entity =>
            {
                entity.ToTable("BoardUser", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aduser)
                    .HasColumnName("ADUser")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateBy).HasMaxLength(11);
            });

            modelBuilder.Entity<Bs>(entity =>
            {
                entity.ToTable("BS", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankCode).HasMaxLength(12);

                entity.Property(e => e.Bsdate).HasColumnName("BSDate");

                entity.Property(e => e.Bsno)
                    .HasColumnName("BSNo")
                    .HasMaxLength(16);

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.CreateOrg).HasMaxLength(9);

                entity.Property(e => e.CreatePos).HasMaxLength(9);

                entity.Property(e => e.LastModifyBy).HasMaxLength(11);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<Bscompany>(entity =>
            {
                entity.ToTable("BSCompany", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bsno)
                    .HasColumnName("BSNo")
                    .HasMaxLength(16);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalNoCr).HasColumnName("TotalNoCR");
            });

            modelBuilder.Entity<Bspayee>(entity =>
            {
                entity.ToTable("BSPayee", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.BankAccount).HasMaxLength(40);

                entity.Property(e => e.BscompanyId).HasColumnName("BSCompanyID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.FiDoc).HasMaxLength(20);

                entity.Property(e => e.PayeeName).HasMaxLength(100);

                entity.Property(e => e.PayeeTaxId)
                    .HasColumnName("PayeeTaxID")
                    .HasMaxLength(40);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<Bssigner>(entity =>
            {
                entity.ToTable("BSSigner", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Signer).HasMaxLength(11);
            });

            modelBuilder.Entity<Ca>(entity =>
            {
                entity.ToTable("CA", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.BusinessPlace).HasMaxLength(20);

                entity.Property(e => e.Cadate).HasColumnName("CADate");

                entity.Property(e => e.Cano)
                    .HasColumnName("CANo")
                    .HasMaxLength(15);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.CostCenter).HasMaxLength(10);

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.CreateOrg).HasMaxLength(9);

                entity.Property(e => e.CreatePos).HasMaxLength(9);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.FundSap)
                    .HasColumnName("FundSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.InternalMemoNo).HasMaxLength(50);

                entity.Property(e => e.Iosap)
                    .HasColumnName("IOSAP")
                    .HasMaxLength(25);

                entity.Property(e => e.LastModifyBy).HasMaxLength(11);

                entity.Property(e => e.Objective).HasMaxLength(80);

                entity.Property(e => e.PaymentPlace).HasMaxLength(20);

                entity.Property(e => e.PrepareBy).HasMaxLength(11);

                entity.Property(e => e.ReceiveId)
                    .HasColumnName("ReceiveID")
                    .HasMaxLength(13);

                entity.Property(e => e.ReceiveType).HasMaxLength(2);

                entity.Property(e => e.RequestFor).HasMaxLength(11);

                entity.Property(e => e.RequestOrg).HasMaxLength(9);

                entity.Property(e => e.RequestPos).HasMaxLength(9);

                entity.Property(e => e.ReserveBudget).HasMaxLength(20);

                entity.Property(e => e.Sapmessage).HasColumnName("SAPMessage");

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<Careceive>(entity =>
            {
                entity.ToTable("CAReceive", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amper).HasMaxLength(80);

                entity.Property(e => e.Cano)
                    .HasColumnName("CANo")
                    .HasMaxLength(15);

                entity.Property(e => e.CareceiveDate).HasColumnName("CAReceiveDate");

                entity.Property(e => e.ExpiryDate).HasMaxLength(80);

                entity.Property(e => e.FirstNameEn)
                    .HasColumnName("FirstNameEN")
                    .HasMaxLength(20);

                entity.Property(e => e.FirstNameTh)
                    .HasColumnName("FirstNameTH")
                    .HasMaxLength(80);

                entity.Property(e => e.Jangwat).HasMaxLength(80);

                entity.Property(e => e.LastNameEn)
                    .HasColumnName("LastNameEN")
                    .HasMaxLength(80);

                entity.Property(e => e.LastNameTh)
                    .HasColumnName("LastNameTH")
                    .HasMaxLength(80);

                entity.Property(e => e.MiddleNameEn)
                    .HasColumnName("MiddleNameEN")
                    .HasMaxLength(80);

                entity.Property(e => e.MiddleNameTh)
                    .HasColumnName("MiddleNameTH")
                    .HasMaxLength(80);

                entity.Property(e => e.Moo).HasMaxLength(80);

                entity.Property(e => e.No).HasMaxLength(80);

                entity.Property(e => e.Photo).HasMaxLength(80);

                entity.Property(e => e.Soi).HasMaxLength(80);

                entity.Property(e => e.Tambon).HasMaxLength(80);

                entity.Property(e => e.Tanon).HasMaxLength(80);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("TitleEN")
                    .HasMaxLength(20);

                entity.Property(e => e.TitleTh)
                    .HasColumnName("TitleTH")
                    .HasMaxLength(20);

                entity.Property(e => e.Trok).HasMaxLength(80);
            });

            modelBuilder.Entity<CompanyBankInfo>(entity =>
            {
                entity.ToTable("CompanyBankInfo", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName).HasMaxLength(80);

                entity.Property(e => e.AccountNumber).HasMaxLength(20);

                entity.Property(e => e.AccountType).HasMaxLength(10);

                entity.Property(e => e.BankBranchCode).HasMaxLength(10);

                entity.Property(e => e.BankBranchName).HasMaxLength(80);

                entity.Property(e => e.BankCode).HasMaxLength(10);

                entity.Property(e => e.BankName).HasMaxLength(80);

                entity.Property(e => e.ComCode).HasMaxLength(10);
            });

            modelBuilder.Entity<CompanyManager>(entity =>
            {
                entity.ToTable("CompanyManager", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<CompanyManagerItem>(entity =>
            {
                entity.ToTable("CompanyManagerItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyManagerId).HasColumnName("CompanyManagerID");

                entity.Property(e => e.Manager).HasMaxLength(11);
            });

            modelBuilder.Entity<ConfigureValue>(entity =>
            {
                entity.ToTable("ConfigureValue", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key).HasMaxLength(20);

                entity.Property(e => e.Value).HasMaxLength(40);
            });

            modelBuilder.Entity<ConnectionLog>(entity =>
            {
                entity.ToTable("ConnectionLog", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.BrowserType).HasMaxLength(20);

                entity.Property(e => e.BrowserVersion).HasMaxLength(20);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20);

                entity.Property(e => e.LogType).HasMaxLength(20);

                entity.Property(e => e.MobileManufacturer).HasMaxLength(30);

                entity.Property(e => e.MobileModel).HasMaxLength(30);

                entity.Property(e => e.User).HasMaxLength(100);
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("CostCenter", "ds");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(40);
            });

            modelBuilder.Entity<CostCenterManager>(entity =>
            {
                entity.ToTable("CostCenterManager", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostCenter).HasMaxLength(11);

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<CostCenterManagerItem>(entity =>
            {
                entity.ToTable("CostCenterManagerItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostCenterManagerId).HasColumnName("CostCenterManagerID");

                entity.Property(e => e.Manager).HasMaxLength(11);
            });

            modelBuilder.Entity<EmailTask>(entity =>
            {
                entity.ToTable("EmailTask", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaskBy)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.TaskCode)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<EmailTaskContent>(entity =>
            {
                entity.ToTable("EmailTaskContent", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.EmailTaskId).HasColumnName("EmailTaskID");
            });

            modelBuilder.Entity<EmailTaskReceiver>(entity =>
            {
                entity.ToTable("EmailTaskReceiver", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmailTaskId).HasColumnName("EmailTaskID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailType);

                entity.ToTable("EmailTemplate", "ds");

                entity.Property(e => e.EmailType)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Subject).HasMaxLength(500);
            });

            modelBuilder.Entity<ExecutiveUser>(entity =>
            {
                entity.ToTable("ExecutiveUser", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aduser)
                    .HasColumnName("ADUser")
                    .HasMaxLength(40);

                entity.Property(e => e.CreateBy).HasMaxLength(11);
            });

            modelBuilder.Entity<HolidayCalendar>(entity =>
            {
                entity.ToTable("HolidayCalendar", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LastModifyBy).HasMaxLength(100);
            });

            modelBuilder.Entity<HrbusinessPlace>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPlace, e.ComCode });

                entity.ToTable("HRBusinessPlace", "ds");

                entity.Property(e => e.BusinessPlace).HasMaxLength(20);

                entity.Property(e => e.ComCode).HasMaxLength(20);

                entity.Property(e => e.BusinessPlaceName).HasMaxLength(100);
            });

            modelBuilder.Entity<Hrcompany>(entity =>
            {
                entity.HasKey(e => e.ComCode);

                entity.ToTable("HRCompany", "ds");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(40);

                entity.Property(e => e.LongText).HasMaxLength(40);

                entity.Property(e => e.SapcomCode)
                    .HasColumnName("SAPComCode")
                    .HasMaxLength(10);

                entity.Property(e => e.ShortText).HasMaxLength(10);
            });

            modelBuilder.Entity<Hremployee>(entity =>
            {
                entity.HasKey(e => e.EmpNo);

                entity.ToTable("HREmployee", "ds");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Aduser)
                    .HasColumnName("ADUser")
                    .HasMaxLength(100);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpStatus).HasMaxLength(1);

                entity.Property(e => e.FirstnameEn)
                    .HasColumnName("FirstnameEN")
                    .HasMaxLength(60);

                entity.Property(e => e.FirstnameTh)
                    .HasColumnName("FirstnameTH")
                    .HasMaxLength(60);

                entity.Property(e => e.GradeCode).HasMaxLength(5);

                entity.Property(e => e.GradeText).HasMaxLength(60);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(30);

                entity.Property(e => e.LastnameEn)
                    .HasColumnName("LastnameEN")
                    .HasMaxLength(60);

                entity.Property(e => e.LastnameTh)
                    .HasColumnName("LastnameTH")
                    .HasMaxLength(60);

                entity.Property(e => e.ManagerEmpNo).HasMaxLength(100);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.OfficeTel).HasMaxLength(100);

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasMaxLength(9);

                entity.Property(e => e.PositionId)
                    .HasColumnName("PositionID")
                    .HasMaxLength(9);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("TitleEN")
                    .HasMaxLength(15);

                entity.Property(e => e.TitleTh)
                    .HasColumnName("TitleTH")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<HremployeeMobile>(entity =>
            {
                entity.ToTable("HREmployeeMobile", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.EmpNo).HasMaxLength(100);

                entity.Property(e => e.MobileNo).HasMaxLength(20);
            });

            modelBuilder.Entity<Hrorg>(entity =>
            {
                entity.HasKey(e => e.OrgId);

                entity.ToTable("HROrg", "ds");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.ManagerEmpNo).HasMaxLength(100);

                entity.Property(e => e.OrgLevel).HasMaxLength(11);

                entity.Property(e => e.OrgName).HasMaxLength(100);
            });

            modelBuilder.Entity<HrorgRelation>(entity =>
            {
                entity.HasKey(e => new { e.ParentOrgId, e.ChildOrgId });

                entity.ToTable("HROrgRelation", "ds");

                entity.Property(e => e.ParentOrgId)
                    .HasColumnName("ParentOrgID")
                    .HasMaxLength(8);

                entity.Property(e => e.ChildOrgId)
                    .HasColumnName("ChildOrgID")
                    .HasMaxLength(8);

                entity.Property(e => e.ChildOrgName).HasMaxLength(40);

                entity.Property(e => e.ParentOrgName).HasMaxLength(40);
            });

            modelBuilder.Entity<Hrposition>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("HRPosition", "ds");

                entity.Property(e => e.PosId)
                    .HasColumnName("PosID")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.PosLevel).HasMaxLength(6);

                entity.Property(e => e.PosName).HasMaxLength(40);
            });

            modelBuilder.Entity<Otp>(entity =>
            {
                entity.ToTable("OTP", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpNo).HasMaxLength(11);

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<Pv>(entity =>
            {
                entity.ToTable("PV", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.AttachedFile).HasMaxLength(100);

                entity.Property(e => e.Caamount)
                    .HasColumnName("CAAmount")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Cano)
                    .HasColumnName("CANo")
                    .HasMaxLength(150);

                entity.Property(e => e.ClearCano)
                    .HasColumnName("ClearCANo")
                    .HasMaxLength(12);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.CreateOrg).HasMaxLength(9);

                entity.Property(e => e.CreatePos).HasMaxLength(9);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DocStatus).HasMaxLength(20);

                entity.Property(e => e.ExchangeRate).HasMaxLength(40);

                entity.Property(e => e.LastModifyBy).HasMaxLength(11);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.PayId)
                    .HasColumnName("PayID")
                    .HasMaxLength(11);

                entity.Property(e => e.PayName).HasMaxLength(150);

                entity.Property(e => e.PayOrg).HasMaxLength(8);

                entity.Property(e => e.PrepareByDept).HasMaxLength(30);

                entity.Property(e => e.PvcostCenter)
                    .HasColumnName("PVCostCenter")
                    .HasMaxLength(10);

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Pvtype)
                    .HasColumnName("PVType")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapmessage).HasColumnName("SAPMessage");

                entity.Property(e => e.Section).HasMaxLength(80);

                entity.Property(e => e.Special).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalInvoice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalPay).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalVat)
                    .HasColumnName("TotalVAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht1)
                    .HasColumnName("TotalWHT1")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht2)
                    .HasColumnName("TotalWHT2")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht3)
                    .HasColumnName("TotalWHT3")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht)
                    .HasColumnName("WHT")
                    .HasColumnType("decimal(20, 4)");
            });

            modelBuilder.Entity<PvactivitySap>(entity =>
            {
                entity.ToTable("PVActivitySAP", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasMaxLength(100);

                entity.Property(e => e.ActionName).HasMaxLength(100);

                entity.Property(e => e.ActionType).HasMaxLength(10);

                entity.Property(e => e.Activity).HasMaxLength(100);

                entity.Property(e => e.AllocateUser).HasMaxLength(100);

                entity.Property(e => e.ProcessInstanceId).HasColumnName("ProcessInstanceID");

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Pvsapid).HasColumnName("PVSAPID");

                entity.Property(e => e.Step).HasMaxLength(16);
            });

            modelBuilder.Entity<Pvgroup>(entity =>
            {
                entity.ToTable("PVGroup", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.CreateBy).HasMaxLength(11);

                entity.Property(e => e.CreateOrg).HasMaxLength(11);

                entity.Property(e => e.CreatePos).HasMaxLength(11);

                entity.Property(e => e.OrgName).HasMaxLength(100);

                entity.Property(e => e.PvgroupDate).HasColumnName("PVGroupDate");

                entity.Property(e => e.PvgroupNo)
                    .HasColumnName("PVGroupNo")
                    .HasMaxLength(12);

                entity.Property(e => e.PvgroupType)
                    .HasColumnName("PVGroupType")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PvgroupItem>(entity =>
            {
                entity.ToTable("PVGroupItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.PvgroupNo)
                    .HasColumnName("PVGroupNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<Pvitem>(entity =>
            {
                entity.ToTable("PVItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.At1).HasMaxLength(20);

                entity.Property(e => e.At2).HasMaxLength(20);

                entity.Property(e => e.At3).HasMaxLength(20);

                entity.Property(e => e.DocHt)
                    .HasColumnName("DocHT")
                    .HasMaxLength(80);

                entity.Property(e => e.DocNo).HasMaxLength(16);

                entity.Property(e => e.Invoice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Pay)
                    .HasColumnName("PAY")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.PayeeId)
                    .HasColumnName("PayeeID")
                    .HasMaxLength(11);

                entity.Property(e => e.PayeeName).HasMaxLength(150);

                entity.Property(e => e.Percent1).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Percent2).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Percent3).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Pvid).HasColumnName("PVID");

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Ref).HasMaxLength(20);

                entity.Property(e => e.Rt)
                    .HasColumnName("RT")
                    .HasMaxLength(10);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(20);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(11);

                entity.Property(e => e.VendorName).HasMaxLength(80);

                entity.Property(e => e.Wht1)
                    .HasColumnName("WHT1")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht2)
                    .HasColumnName("WHT2")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht3)
                    .HasColumnName("WHT3")
                    .HasColumnType("decimal(20, 4)");
            });

            modelBuilder.Entity<PvitemSap>(entity =>
            {
                entity.ToTable("PVItemSAP", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.At1).HasMaxLength(20);

                entity.Property(e => e.At2).HasMaxLength(20);

                entity.Property(e => e.At3).HasMaxLength(20);

                entity.Property(e => e.DocHt)
                    .HasColumnName("DocHT")
                    .HasMaxLength(80);

                entity.Property(e => e.DocNo).HasMaxLength(16);

                entity.Property(e => e.Invoice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Pay)
                    .HasColumnName("PAY")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.PayeeId)
                    .HasColumnName("PayeeID")
                    .HasMaxLength(11);

                entity.Property(e => e.PayeeName).HasMaxLength(150);

                entity.Property(e => e.Percent1).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Percent2).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Percent3).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Pvsapid).HasColumnName("PVSAPID");

                entity.Property(e => e.Ref).HasMaxLength(20);

                entity.Property(e => e.Rt)
                    .HasColumnName("RT")
                    .HasMaxLength(10);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(20);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(11);

                entity.Property(e => e.VendorName).HasMaxLength(80);

                entity.Property(e => e.Wht1)
                    .HasColumnName("WHT1")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht2)
                    .HasColumnName("WHT2")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht3)
                    .HasColumnName("WHT3")
                    .HasColumnType("decimal(20, 4)");
            });

            modelBuilder.Entity<Pvsap>(entity =>
            {
                entity.ToTable("PVSAP", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.AttachedFile).HasMaxLength(100);

                entity.Property(e => e.Caamount)
                    .HasColumnName("CAAmount")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Cano)
                    .HasColumnName("CANo")
                    .HasMaxLength(150);

                entity.Property(e => e.ClearCano)
                    .HasColumnName("ClearCANo")
                    .HasMaxLength(12);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.ExchangeRate).HasMaxLength(40);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.PayId)
                    .HasColumnName("PayID")
                    .HasMaxLength(11);

                entity.Property(e => e.PayName).HasMaxLength(150);

                entity.Property(e => e.PayOrg).HasMaxLength(8);

                entity.Property(e => e.PrepareByDept).HasMaxLength(30);

                entity.Property(e => e.PvcostCenter)
                    .HasColumnName("PVCostCenter")
                    .HasMaxLength(10);

                entity.Property(e => e.Pvno)
                    .HasColumnName("PVNo")
                    .HasMaxLength(12);

                entity.Property(e => e.Pvsapid).HasColumnName("PVSAPID");

                entity.Property(e => e.Pvtype)
                    .HasColumnName("PVType")
                    .HasMaxLength(20);

                entity.Property(e => e.Section).HasMaxLength(80);

                entity.Property(e => e.Special).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalInvoice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalPay).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalVat)
                    .HasColumnName("TotalVAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht1)
                    .HasColumnName("TotalWHT1")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht2)
                    .HasColumnName("TotalWHT2")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.TotalWht3)
                    .HasColumnName("TotalWHT3")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Wht)
                    .HasColumnName("WHT")
                    .HasColumnType("decimal(20, 4)");
            });

            modelBuilder.Entity<RespGroup>(entity =>
            {
                entity.ToTable("RespGroup", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupType).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<RespGroupAdmin>(entity =>
            {
                entity.ToTable("RespGroupAdmin", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpNo).HasMaxLength(11);

                entity.Property(e => e.RespGroupId).HasColumnName("RespGroupID");
            });

            modelBuilder.Entity<RespGroupComp>(entity =>
            {
                entity.ToTable("RespGroupComp", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.RespGroupId).HasColumnName("RespGroupID");
            });

            modelBuilder.Entity<RespGroupEmp>(entity =>
            {
                entity.ToTable("RespGroupEmp", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpNo).HasMaxLength(11);

                entity.Property(e => e.RespGroupId).HasColumnName("RespGroupID");
            });

            modelBuilder.Entity<RespGroupOrg>(entity =>
            {
                entity.ToTable("RespGroupOrg", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasMaxLength(8);

                entity.Property(e => e.RespGroupId).HasColumnName("RespGroupID");
            });

            modelBuilder.Entity<ReviewManager>(entity =>
            {
                entity.ToTable("ReviewManager", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Manager).HasMaxLength(11);

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<ReviewManagerItem>(entity =>
            {
                entity.ToTable("ReviewManagerItem", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.ReviewManagerId).HasColumnName("ReviewManagerID");

                entity.Property(e => e.Reviewer).HasMaxLength(11);
            });

            modelBuilder.Entity<UserPostal>(entity =>
            {
                entity.HasKey(e => e.EmpNo);

                entity.ToTable("UserPostal", "ds");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.UserKey)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompositeRoleId).HasColumnName("CompositeRoleID");

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.LastModifyBy).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<ValueHelp>(entity =>
            {
                entity.ToTable("ValueHelp", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.LastModifyBy).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.ValueKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ValueText).HasMaxLength(100);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<WorkflowActivityLog>(entity =>
            {
                entity.HasKey(e => new { e.ProcessInstanceId, e.SerialNo });

                entity.ToTable("WorkflowActivityLog", "ds");

                entity.Property(e => e.ProcessInstanceId).HasColumnName("ProcessInstanceID");

                entity.Property(e => e.SerialNo).HasMaxLength(100);

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.ActionUser).HasMaxLength(100);

                entity.Property(e => e.ActionUserCode).HasMaxLength(11);

                entity.Property(e => e.ActionUserOrg).HasMaxLength(9);

                entity.Property(e => e.ActionUserPosition).HasMaxLength(9);

                entity.Property(e => e.AllocatedUser).HasMaxLength(100);
            });

            modelBuilder.Entity<WorkflowActivityStep>(entity =>
            {
                entity.HasKey(e => new { e.ProcessInstanceId, e.Step, e.ActionUser });

                entity.ToTable("WorkflowActivityStep", "ds");

                entity.Property(e => e.ProcessInstanceId).HasColumnName("ProcessInstanceID");

                entity.Property(e => e.ActionUser).HasMaxLength(40);

                entity.Property(e => e.ActionUserCode).HasMaxLength(11);

                entity.Property(e => e.ActionUserOrg).HasMaxLength(9);

                entity.Property(e => e.ActionUserPosition).HasMaxLength(9);

                entity.Property(e => e.Activity).HasMaxLength(20);

                entity.Property(e => e.FormState).HasMaxLength(20);

                entity.Property(e => e.State).HasMaxLength(20);
            });

            modelBuilder.Entity<WorkflowDelegate>(entity =>
            {
                entity.ToTable("WorkflowDelegate", "ds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromUser).HasMaxLength(100);

                entity.Property(e => e.ToUser).HasMaxLength(100);
            });

            modelBuilder.Entity<WorkflowProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessCode);

                entity.ToTable("WorkflowProcess", "ds");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.Controller).HasMaxLength(100);

                entity.Property(e => e.K2workflowProcess)
                    .HasColumnName("K2WorkflowProcess")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcessName).HasMaxLength(200);
            });

            modelBuilder.Entity<WorkflowProcessInstance>(entity =>
            {
                entity.HasKey(e => e.ProcessInstanceId);

                entity.ToTable("WorkflowProcessInstance", "ds");

                entity.Property(e => e.ProcessInstanceId)
                    .HasColumnName("ProcessInstanceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.ProcessCode).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(20);
            });
        }
    }
}
