using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDropDow.Areas.Identity.Data;

namespace StudentDropDow.Areas.Identity.Data;

public class StudentDropDowContext : IdentityDbContext<StudentUserLogin>
{
    public StudentDropDowContext(DbContextOptions<StudentDropDowContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
//public DbSet<StudentDropDow.Models.Cascade.Employee> Employee { get; set; } = default!;

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<StudentUserLogin>
{
    public void Configure(EntityTypeBuilder<StudentUserLogin> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
    }
}
