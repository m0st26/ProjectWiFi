using Microsoft.EntityFrameworkCore;
using ParkWifi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using ParkWifi.ApplicationServices.Synchronization;

namespace ParkWifi.InfrastructureServices.Gateways.Database
{
    public class ParkWifiContext : DbContext
    {
        public DbSet<DomainObjects.parkwifi> ParkWifi { get; set; }

        public ParkWifiContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {
            var v = new UseCaseParkWifi();

            modelBuilder.Entity<parkwifi>().HasData(v.parkwifis);
        }
    }
}
