
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission.Infrastructure.Installers.Contracts;

namespace Permission.Infrastructure.Installers
{
    public class MvcInstaller: IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddNewtonsoftJson(); 
        }
    }
}