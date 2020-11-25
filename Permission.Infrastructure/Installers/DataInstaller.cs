using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission.Database;
using Permission.Infrastructure.Installers.Contracts;

namespace Permission.Infrastructure.Installers
{
    public class DataInstaller: IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = "Data Source=DESKTOP-31A9CQK\\VBMSSQLSERVER;Initial Catalog=Permission;Integrated Security=True";
            services.AddDbContext<PermissionContext>(options => { options.UseSqlServer(connectionString ?? throw new Exception("No se ha encontrado connection string")); });
        }
    }
}