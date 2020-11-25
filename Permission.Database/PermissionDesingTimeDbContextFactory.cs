using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Permission.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestPermission.Database
{
    public class PermissionDesingTimeDbContextFactory : IDesignTimeDbContextFactory<PermissionContext>
    {
        public PermissionContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PermissionContext>();
            string connectionString = "Data Source=DESKTOP-31A9CQK\\VBMSSQLSERVER;Initial Catalog=Permission;Integrated Security=True";
            builder.UseSqlServer(connectionString ?? throw new Exception("connection string empty"));

            return new PermissionContext(builder.Options);
        }

       
    }
}
