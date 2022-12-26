using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Application.Repositories.Order;
using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using ETicaretAPI.Persistence.Repositories.Customer;
using ETicaretAPI.Persistence.Repositories.Order;
using ETicaretAPI.Persistence.Repositories.Product;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}

