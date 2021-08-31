using System;
using System.IO;
using System.Linq;
using Examen01_B93082.Infrastructure.GruposInvestigacion;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace Examen01_B93082.IntegrationTests.GruposInvestigacion
{
    public class GrupoInvestigacionWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup:class
    {
        private IConfiguration? _configuration;
        public void SeedDatabaseForTests(DbContext dbContext)
        {
            if (dbContext is null || _configuration is null) throw new
            Exception("Error in config.");
            var seedScriptName = _configuration["SeedDataScript"];
            var sql = File.ReadAllText(seedScriptName);
            var connection = new
            SqlConnection(dbContext.Database.GetConnectionString());
            connection.Open();
            var cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder(Array.Empty<string>())
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<TStartup>();
                ConfigureWebHost(webBuilder);
            });
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                "integrationsettings.json");
                config.AddJsonFile(filePath);
            });

            builder.ConfigureServices(services =>
            {
                var dbContextOptionsDescriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                typeof(DbContextOptions<>));
                if (dbContextOptionsDescriptor != null)
                    services.Remove(dbContextOptionsDescriptor);
                var sp = services.BuildServiceProvider();
                var configuration = sp.GetRequiredService<IConfiguration>();
                services.AddDbContext<GrupoInvestigacionDbContext>(
                options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("TestConnection"));
                });
                sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db =
                    scopedServices.GetRequiredService<GrupoInvestigacionDbContext>();
                    var logger = scopedServices
                    .GetRequiredService<ILogger<GrupoInvestigacionWebApplicationFactory<TStartup>>>();
                    _configuration = configuration;
                    try
                    {
                        db.Database.Migrate();
                        SeedDatabaseForTests(db);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "An error occurred seeding the " + "database with test messages  Error: { Message }", ex.Message);
                    }   
                }
            });
        }

    }
}
