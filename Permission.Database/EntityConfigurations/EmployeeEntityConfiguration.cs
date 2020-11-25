using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permission.Business.Entities.Employees;
using System;

namespace Permission.Database.EntityConfigurations
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                     .HasDefaultValue(DateTime.Now)
                    .IsRequired();       

            builder.Property(x => x.UpdatedAt)
                  .IsRequired(false);
        }
    }
}
