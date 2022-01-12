using eCommercePizza.Entities;
using eCommercePizza.Repositories;
using eCommercePizza.Repositories.Implementations;
using eCommercePizza.Repositories.Interfaces;
using eCommercePizza.Services.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePizza.Services.Configuration
{
    public class ConfigurationRepositories
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });

            services.AddIdentity<User, Role>().
               AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddScoped<DbContext, AppDbContext>();


            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<IRepository<Item>, Repository<Item>>();
            services.AddTransient<IRepository<Category>, Repository<Category>>();
            services.AddTransient<IRepository<ItemType>, Repository<ItemType>>();
            services.AddTransient<IRepository<CartItem>, Repository<CartItem>>();
            services.AddTransient<IRepository<PaymentDetails>, Repository<PaymentDetails>>();
            services.AddTransient<IRepository<OrderItem>, Repository<OrderItem>>();

            //services.AddTransient<IOrderRepository, OrderRepository>();

        }
    }
}
