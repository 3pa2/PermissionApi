using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission.Contracts.Repositories;
using Permission.Infrastructure.Installers.Contracts;
using Permission.Repositories.Repositories;

namespace Permission.Infrastructure.Installers
{
    public class RepositoryInstaller: IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(typeof(IRepositoryBase<>), typeof(PermissionRepositoryData<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IPermissionTypeRepository, PermissionTypeRepository>();
            services.AddScoped<IPermissionRequestRepository, PermissionRequestRepository>();
        }
    }
}