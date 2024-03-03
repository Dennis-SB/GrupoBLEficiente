using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Entities
{
    public partial class GrupoBLEficienteContext : DbContext
    {
        public GrupoBLEficienteContext()
        {
        }

        public GrupoBLEficienteContext(DbContextOptions<GrupoBLEficienteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccruedVacation> AccruedVacations { get; set; } = null!;
        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<Commission> Commissions { get; set; } = null!;
        public virtual DbSet<Deduction> Deductions { get; set; } = null!;
        public virtual DbSet<DeductionType> DeductionTypes { get; set; } = null!;
        public virtual DbSet<DeductionsPaySheet> DeductionsPaySheets { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ErrorsLog> ErrorsLogs { get; set; } = null!;
        public virtual DbSet<EventsLog> EventsLogs { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<NationalIdType> NationalIdTypes { get; set; } = null!;
        public virtual DbSet<OncallPay> OncallPays { get; set; } = null!;
        public virtual DbSet<OverTime> OverTimes { get; set; } = null!;
        public virtual DbSet<PayPeriod> PayPeriods { get; set; } = null!;
        public virtual DbSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<UsedVacation> UsedVacations { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=GrupoBLEficiente;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccruedVacation>(entity =>
            {
                entity.HasKey(e => e.IdAccruedVacation)
                    .HasName("PK__AccruedV__937784772A5759C1");

                entity.Property(e => e.AccruedVacation1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AccruedVacation");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.AccruedVacations)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__AccruedVa__IdEmp__59063A47");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.IdAttendance)
                    .HasName("PK__Attendan__DEB0138C6F7B1FAF");

                entity.ToTable("Attendance");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__Attendanc__IdEmp__5535A963");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__Attendanc__IdPay__5629CD9C");
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.HasKey(e => e.IdCommision)
                    .HasName("PK__Commissi__659C7B7029A18D31");

                entity.Property(e => e.Commisions).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Commissions)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__Commissio__IdEmp__6383C8BA");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.Commissions)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__Commissio__IdPay__6477ECF3");
            });

            modelBuilder.Entity<Deduction>(entity =>
            {
                entity.HasKey(e => e.IdDeduction)
                    .HasName("PK__Deductio__DC3D189D588EE734");

                entity.Property(e => e.DeductionPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndRange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartRange).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdDeductionTypeNavigation)
                    .WithMany(p => p.Deductions)
                    .HasForeignKey(d => d.IdDeductionType)
                    .HasConstraintName("FK__Deduction__IdDed__4E88ABD4");
            });

            modelBuilder.Entity<DeductionType>(entity =>
            {
                entity.HasKey(e => e.IdDeductionType)
                    .HasName("PK__Deductio__1168EB98ABCFAE07");

                entity.ToTable("DeductionType");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DeductionsPaySheet>(entity =>
            {
                entity.HasKey(e => e.IdDeductionsPaySheet)
                    .HasName("PK__Deductio__4F8D5D55591BDE3A");

                entity.ToTable("DeductionsPaySheet");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDeductionNavigation)
                    .WithMany(p => p.DeductionsPaySheets)
                    .HasForeignKey(d => d.IdDeduction)
                    .HasConstraintName("FK__Deduction__IdDed__6FE99F9F");

                entity.HasOne(d => d.IdPaySheetNavigation)
                    .WithMany(p => p.DeductionsPaySheets)
                    .HasForeignKey(d => d.IdPaySheet)
                    .HasConstraintName("FK__Deduction__IdPay__70DDC3D8");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__51C8DD7AB78B16FA");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MonthlyGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NationalId).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdJobTitleNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdJobTitle)
                    .HasConstraintName("FK__Employees__IdJob__3E52440B");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("FK__Employees__IdTyp__3D5E1FD2");
            });

            modelBuilder.Entity<ErrorsLog>(entity =>
            {
                entity.HasKey(e => e.IdError)
                    .HasName("PK__ErrorsLo__C8A4CFD9ECB1B1DA");

                entity.ToTable("ErrorsLog");

                entity.Property(e => e.ErrorDate).HasColumnType("date");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ErrorsLogs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__ErrorsLog__IdUse__46E78A0C");
            });

            modelBuilder.Entity<EventsLog>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PK__EventsLo__E0B2AF39443C895F");

                entity.ToTable("EventsLog");

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.EventsLogs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__EventsLog__IdUse__49C3F6B7");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.HasKey(e => e.IdJobTitle)
                    .HasName("PK__JobTitle__A427B021B31D2418");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<NationalIdType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__National__9A39EABC1B11A5EC");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<OncallPay>(entity =>
            {
                entity.HasKey(e => e.IdOncallPay)
                    .HasName("PK__OncallPa__ED0AC97476EBCAAD");

                entity.ToTable("OncallPay");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.OncallPaySum).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.OncallPays)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__OncallPay__IdEmp__5FB337D6");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.OncallPays)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__OncallPay__IdPay__60A75C0F");
            });

            modelBuilder.Entity<OverTime>(entity =>
            {
                entity.HasKey(e => e.IdOverTime)
                    .HasName("PK__OverTime__5BDB8841BE694626");

                entity.ToTable("OverTime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Othours)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTHours");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.OverTimes)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__OverTime__IdEmpl__5165187F");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.OverTimes)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__OverTime__IdPayP__52593CB8");
            });

            modelBuilder.Entity<PayPeriod>(entity =>
            {
                entity.HasKey(e => e.IdPayPeriod)
                    .HasName("PK__PayPerio__AEAB6AF962F778BF");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PeriodEnd).HasColumnType("date");

                entity.Property(e => e.PeriodStart).HasColumnType("date");
            });

            modelBuilder.Entity<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>(entity =>
            {
                entity.HasKey(e => e.IdPaySheet)
                    .HasName("PK__PayPerio__F08BFDCF2B85B55E");

                entity.ToTable("PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOT");

                entity.Property(e => e.ByweeklyGrossPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.NetPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPay).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdAttendanceNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdAttendance)
                    .HasConstraintName("FK__PayPeriod__IdAtt__6C190EBB");

                entity.HasOne(d => d.IdCommisionNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdCommision)
                    .HasConstraintName("FK__PayPeriod__IdCom__6B24EA82");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__PayPeriod__IdEmp__68487DD7");

                entity.HasOne(d => d.IdOncallPayNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdOncallPay)
                    .HasConstraintName("FK__PayPeriod__IdOnc__6A30C649");

                entity.HasOne(d => d.IdOverTimeNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdOverTime)
                    .HasConstraintName("FK__PayPeriod__IdOve__6D0D32F4");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__PayPeriod__IdPay__6754599E");

                entity.HasOne(d => d.IdUsedVacactionsNavigation)
                    .WithMany(p => p.PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts)
                    .HasForeignKey(d => d.IdUsedVacactions)
                    .HasConstraintName("FK__PayPeriod__IdUse__693CA210");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__2A49584CB1481F5D");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UsedVacation>(entity =>
            {
                entity.HasKey(e => e.IdUsedVacation)
                    .HasName("PK__UsedVaca__7E425E56E3459FB1");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.VacationsPay).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.UsedVacations)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__UsedVacat__IdEmp__5CD6CB2B");

                entity.HasOne(d => d.IdPayPeriodNavigation)
                    .WithMany(p => p.UsedVacations)
                    .HasForeignKey(d => d.IdPayPeriod)
                    .HasConstraintName("FK__UsedVacat__IdPay__5BE2A6F2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Users__B7C926380E6B0ED7");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK__Users__IdEmploye__440B1D61");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Users__IdRol__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
