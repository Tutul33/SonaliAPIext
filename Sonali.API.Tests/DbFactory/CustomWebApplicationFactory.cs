using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Infrustructure.Data.Models;
using System.Linq;

namespace Sonali.API.Tests.DbFactory
{
    public class CustomWebApplicationFactory<TStartup>
        : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remove real DbContext
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));
                if (descriptor != null)
                    services.Remove(descriptor);

                // Add in-memory DbContext
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseInMemoryDatabase("IntegrationTestDb");
                });

                // Build the service provider
                var sp = services.BuildServiceProvider();

                // Seed test data
                using (var scope = sp.CreateScope())
                {
                    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    db.Database.EnsureCreated();

                    // Add sample vouchers
                    db.Accgl2025s.AddRange(
                        new Accgl2025 { Id = 1m, VoucherNo = "V001", Damount = 100, Camount = 50 },
                        new Accgl2025 { Id = 2m, VoucherNo = "V002", Damount = 200, Camount = 150 }
                    );
                    db.SaveChanges();
                }
            });
        }
    }
}
