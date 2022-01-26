using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Application.AutoMapper;

namespace CleanArch.Api2.Configurations
{
    public static class AutpMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services) 
        {
            services.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMapping();
        }
    }
}
