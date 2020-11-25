using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Permission.Database.EntityConfigurations
{
    public class PermissionTypeEntityConfiguration : IEntityTypeConfiguration<Permission.Business.Entities.Permissions.PermissionType>
    {
        public void Configure(EntityTypeBuilder<Permission.Business.Entities.Permissions.PermissionType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now)
                  .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired(false);
        }
    }
}
