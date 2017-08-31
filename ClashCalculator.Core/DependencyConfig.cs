using ClashCalculator.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClashCalculator.Core
{
    public static class DependencyConfig
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("DefaultConnection");
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<ClashCalculatorContext>(options => options.UseSqlServer(connString));
        }
    }
}
