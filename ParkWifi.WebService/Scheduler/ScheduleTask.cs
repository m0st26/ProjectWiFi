using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ParkWifi.InfrastructureServices.Gateways.Database;
using ParkWifi.WebService.InfrastructureServices.Gateways;
using ParkWifi.WebService.Scheduler;
using System.IO;
using ParkWifi.DomainObjects;

namespace ParkWifi.WebService.Scheduler
{
    public class ScheduleTask : ScheduledProcessor
    {

        public ScheduleTask(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
        }

        protected override string Schedule => "*/1 * * * *";

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("https://apidata.mos.ru/v1/datasets/861/rows?api_key=5720beead2a7fc01045f45bdf0d8e3be&$top=1000");
            List<ResultFromServer> resultServer = JsonConvert.DeserializeObject<List<ResultFromServer>>(result);
            var optionsBuilder = new DbContextOptionsBuilder<ParkWifiContext>();
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\"));
            string newnewpath = System.IO.Path.Combine(newPath, "ParkWifi.WebService", "ParkWifi.db");
            optionsBuilder.UseSqlite($"Data Source={newnewpath}");
            var context = new ParkWifiContext(options: optionsBuilder.Options);
            context.Database.ExecuteSqlRaw("DELETE FROM ParkWifi");
            using (context)
            {
                foreach (var item in resultServer)
                {
                    parkwifi parkwifi = new parkwifi();
                    parkwifi.Name = item.Cells.Name;
                    parkwifi.FunctionFlag = item.Cells.FunctionFlag;
                    parkwifi.ParkName = item.Cells.ParkName;
                    parkwifi.wifiName = item.Cells.wifiName;
                    context.Entry(parkwifi).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        
            
            Console.WriteLine("Updated db.");
            return Task.CompletedTask;
        }
    }
}
