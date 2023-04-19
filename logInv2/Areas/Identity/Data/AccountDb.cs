using logInv2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace logInv2.Areas.Identity.Data;

public class AccountDb : IdentityDbContext<userlgn>
{
    public AccountDb(DbContextOptions<AccountDb> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<userlgn>
{
    public void Configure(EntityTypeBuilder<userlgn> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.lastName).HasMaxLength(255);
    }
}