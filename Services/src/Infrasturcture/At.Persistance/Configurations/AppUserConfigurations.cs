using At.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace At.Persistance.Configurations
{
    public sealed class AppUserConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.SurName).HasMaxLength(200);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(20);
            builder.HasIndex(x => x.UserName).IsUnique(true);
            builder.Property(x=>x.UserName).HasMaxLength(200);
            builder.Property(x=>x.UserName).IsRequired(true);
            builder.Property(x => x.AppRoleId).IsRequired(true);
            builder.HasMany(x => x.Tasks).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
            builder.HasMany(x => x.Notifications).WithOne(x => x.Users).HasForeignKey(x => x.AppUserId);
        
        
        }
    }
}
