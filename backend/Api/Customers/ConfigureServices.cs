using MediatR;

namespace Api.Customers
{
    public static class ConfigureServices
    {
        public static void ConfigureCustomers(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ConfigureServices));

            services.AddDbContext<CustomersDbContext>(ServiceLifetime.Scoped);
        }
    }
}
