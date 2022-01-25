using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using CleanArch.Api2.Repository;
using CleanArch.Api2.Context;
using CleanArch.Api2.Interfaces;
using CleanArch.Api2.Services;
using CleanArch.Api2.Configurations;

namespace CleanArch.Api2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<UniversityDBContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("CleanArchDBConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();         

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CleanArch.Api2", Version = "v1" });
            });

            //services.AddMediatR(typeof(Startup));
            //services.AddMediatR(typeof(InMemoryBus));
            //services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Application Layer
            services.AddScoped<ISimpleCourseService, SimpleCourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();

            //AutoMapper
            services.RegisterAutoMapper();

            //RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArch.Api2 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private static void RegisterServices(IServiceCollection services)
        {
            //DependencyContainer.RegisterServices(services);
            RegisterServices(services);
        }

    }
}
