using Microsoft.EntityFrameworkCore;
using Permission.Business.Entities.Employees;
using Permission.Business.Entities.Permissions;
using Permission.Database.EntityConfigurations;


namespace Permission.Database
{
    public class PermissionContext : DbContext
    {
        public PermissionContext(DbContextOptions<PermissionContext> options):base(options) { }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PermissionTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionEntityConfiguration());
        }

        #region Tables

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Business.Entities.Permissions.Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        #endregion

    }
}
