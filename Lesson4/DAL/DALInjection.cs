using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DALInjection
    {
        public static void Inject(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContex>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString"]);
            });
        }
    }
}
