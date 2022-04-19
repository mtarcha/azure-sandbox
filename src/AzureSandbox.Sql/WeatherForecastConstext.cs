using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSandbox.Sql
{
    internal class WeatherForecastConstext : DbContext
    {
        public WeatherForecastConstext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WeatherForecastEntity> WeatherForecast { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WeatherForecastEntity>().ToTable("WeatherForecast").HasKey(p => p.Id);
            modelBuilder.Entity<WeatherForecastEntity>().Property(p => p.Location).IsRequired();
            modelBuilder.Entity<WeatherForecastEntity>().Property(p => p.Date).IsRequired();
            modelBuilder.Entity<WeatherForecastEntity>().Property(p => p.TemperatureC).IsRequired();
            modelBuilder.Entity<WeatherForecastEntity>().HasIndex(p => new { p.Location, p.Date }).IsUnique();
        }
    }
}
