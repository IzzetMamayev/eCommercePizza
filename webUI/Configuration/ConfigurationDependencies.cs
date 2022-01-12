using eCommercePizza.Services;
using eCommercePizza.Services.Implementations;
using eCommercePizza.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using webUI.Helpers;
using webUI.Interfaces;

namespace webUI.Configuration
{
    public class ConfigurationDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<ICatalogService, CatalogService>();
            services.AddTransient<ICartService, CartService>();
            //services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IFileHelper, FileHelper>();
        }
    }
}
