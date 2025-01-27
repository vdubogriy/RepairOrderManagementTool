using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ServiceStation.DatabaseModels;
using System;

namespace ServiceStation.API
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CarServiceStation> CarServiceStations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var confugurationBuilder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile($"appsettings.json", true, false).AddEnvironmentVariables();

            var configuration = confugurationBuilder.Build();

            var connStr = configuration["AppSettings:DatabaseConnectionString"];

            optionsBuilder.UseSqlServer(connStr);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
