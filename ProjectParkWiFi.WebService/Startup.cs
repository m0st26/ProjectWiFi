using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParkWiFi.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using ParkWiFi.ApplicationServices.GetParkWiFiListUseCase;
using ParkWiFi.ApplicationServices.Ports.Gateways.Database;
using ParkWiFi.ApplicationServices.Repositories;
using ParkWiFi.DomainObjects.Ports;

namespace ParkWiFi.WebService
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
            services.AddDbContext<ParkWiFiContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "ParkWiFi.db")}")
            );

            services.AddScoped<IParkWiFiDatabaseGateway, ParkWiFiEFSqliteGateway>();

            services.AddScoped<DbParkWiFiRepository>();
            services.AddScoped<IReadOnlyParkWiFiRepository>(x => x.GetRequiredService<DbParkWiFiRepository>());
            services.AddScoped<IParkWiFiRepository>(x => x.GetRequiredService<DbParkWiFiRepository>());
            services.AddScoped<IGetParkWiFiListUseCase, GetParkWiFiListUseCase>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
