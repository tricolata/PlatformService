using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope()) 
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any()) 
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platforms.AddRange(
                    new Platform() {Name="Dot Net", Publisher="Microsoft", Type="Software Framework", Cost="Free"},
                    new Platform() {Name="SQL Server Express", Publisher="Microsoft", Type="RDMS", Cost="Free"},
                    new Platform() {Name="Kubernetes", Publisher="Cloud Native Computing Foundation", Type="Cluster Management Software", Cost="Free"},
                    new Platform() {Name="RabbitMq", Publisher="Pivotal Software", Type="Message Broker", Cost="Free"},
                    new Platform() {Name="Apache Kafka", Publisher="Pivotal Software", Type="Message Broker", Cost="Free"},
                    new Platform() {Name="Apache Cassandra", Publisher="Apache Software Foundation", Type="NoSQL Database", Cost="Free"}
                );

                context.SaveChanges();
            }
            else Console.WriteLine("--> We already have data");
        }
    }
}