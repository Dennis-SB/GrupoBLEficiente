using BackEnd.Areas.Identity.Data;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BackEnd.Data;

public class GrupoBLContext : IdentityDbContext<GrupoBLUser>
{
    public GrupoBLContext(DbContextOptions<GrupoBLContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; } = null!;
    public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
    public virtual DbSet<NationalIdType> NationalIdTypes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedRoles(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<Employee>(entity =>
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

        builder.Entity<JobTitle>(entity =>
        {
            entity.HasKey(e => e.IdJobTitle)
                .HasName("PK__JobTitle__A427B021B31D2418");

            entity.Property(e => e.Description).HasMaxLength(255);

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        builder.Entity<NationalIdType>(entity =>
        {
            entity.HasKey(e => e.IdType)
                .HasName("PK__National__9A39EABC1B11A5EC");

            entity.Property(e => e.Description).HasMaxLength(255);

            entity.Property(e => e.Name).HasMaxLength(50);
        });
    }

    private static void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData
            (
            new IdentityRole() { Name = "Administrador", ConcurrencyStamp = "1", NormalizedName = "Administrador" },
            new IdentityRole() { Name = "Soporte", ConcurrencyStamp = "2", NormalizedName = "Soporte" },
            new IdentityRole() { Name = "Ventas", ConcurrencyStamp = "3", NormalizedName = "Ventas" },
            new IdentityRole() { Name = "Administrativo", ConcurrencyStamp = "4", NormalizedName = "Administrativo" }
            );
    }
}
