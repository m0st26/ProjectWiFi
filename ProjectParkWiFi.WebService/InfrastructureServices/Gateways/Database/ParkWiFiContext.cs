using Microsoft.EntityFrameworkCore;
using ParkWiFi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWiFi.InfrastructureServices.Gateways.Database
{
    public class ParkWiFiContext : DbContext
    {
        public DbSet<DomainObjects.ParkWiFi> ParkWiFis { get; set; }


        public ParkWiFiContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DomainObjects.ParkWiFi>().HasData(
              new DomainObjects.ParkWiFi()
              {
                  Id = 1L,
                  Name = "Точка доступа №337",
                  status = "действует",
                  ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки",
                  wifiName = "Moscow_WiFi_Free",
              }
           );

            //FillTestData(modelBuilder);
        }
        //private void FillTestData(ModelBuilder modelBuilder)
        //{
           

        //    modelBuilder.Entity<ManageOrg>().HasData(
        //       new ManageOrg()
        //       {
        //           Id = 1L,
        //           Name = "Товарищество собственников жилья «Рождественский бульвар дом 5-7 » 7702560790 2015",
        //           Year = 2015,
        //           Prescriptions = "1",
        //           Contraventions = 3,
        //           Protocols = 0,
        //           Events = 0
        //       }
        //    );
        //}
    }
}
