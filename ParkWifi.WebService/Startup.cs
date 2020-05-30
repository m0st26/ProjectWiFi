using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParkWifi.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using ParkWifi.ApplicationServices.Ports.Gateways.Database;
using ParkWifi.ApplicationServices.Repositories;
using ParkWifi.DomainObjects.Ports;

namespace ParkWifi.WebService
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
            services.AddDbContext<ParkWifiContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "ParkWifi.db")}")
            );

            services.AddScoped<IParkWifiDatabaseGateway, ParkWifiEFSqliteGateway>();

            services.AddScoped<DbParkWifiRepository>();
            services.AddScoped<IReadOnlyParkWifiRepository>(x => x.GetRequiredService<DbParkWifiRepository>());
            services.AddScoped<IParkWifiRepository>(x => x.GetRequiredService<DbParkWifiRepository>());


            services.AddScoped<IGetParkWifiListUseCase, GetParkWifiListUseCase>();

            
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