using BackEnd.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data;

public class GrupoBLContext : IdentityDbContext<GrupoBLUser>
{
    public GrupoBLContext(DbContextOptions<GrupoBLContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedRoles(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
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
