using ClashCalculator.Database;
using CocCalculator.Business;
using CocCalculator.Business.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CocCalculator.Core
{
    public static class DependencyConfig
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            //Services layer registration
            services.AddTransient<IAuthenticationBO, AuthenticationBO>();

            var connString = configuration.GetConnectionString("DefaultConnection");
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<CocCalculatorContext>(options => options.UseSqlServer(connString));
        }
    }
}
