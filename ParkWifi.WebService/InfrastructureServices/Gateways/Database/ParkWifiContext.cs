using Microsoft.EntityFrameworkCore;
using ParkWifi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWifi.InfrastructureServices.Gateways.Database
{
    public class ParkWifiContext : DbContext
    {
        public DbSet<parkwifi> ParkWifis { get; set; }

        public ParkWifiContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<parkwifi>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Точка доступа №337",
                    status = "действует",
                    ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки",
                    wifiName = "Moscow_WiFi_Free",
                },
                new
                {
                    Id = 2L,
                    Name = "Точка доступа №338",
                    status = "действует",
                    ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки",
                    wifiName = "Moscow_WiFi_Free",

                },
                new
                {
                    Id = 3L,
                    Name = "Точка доступа №339",
                    status = "действует",
                    ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки",
                    wifiName = "Moscow_WiFi_Free",

                },
                new
                {
                    Id = 4L,
                    Name = "Точка доступа №340",
                    status = "действует",
                    ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки",
                    wifiName = "Moscow_WiFi_Free",

                },
                new
                {
                    Id = 5L,
                    Name = "Точка доступа №267",
                    status = "действует",
                    ParkName = "Государственное автономное учреждение культуры города Москвы «Парк культуры и отдыха «Бабушкинский»",
                    wifiName = "Moscow_WiFi_Free",
                }
            );
        }
    }
}
