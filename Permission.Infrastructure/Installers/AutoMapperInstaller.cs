using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission.Business.Entities.Mappers;
using Permission.Infrastructure.Installers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Infrastructure.Installers
{
    public class AutoMapperInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PermissionMappingProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
