using System.Text;
using api_gateway.Microservices;
using api_gateway.Microservices.Interfaces;

namespace UserService.Api.Extensions
{
    public static class AppServiceExtensions
    {
        public static void AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config
        )
        {
            AddServices(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IResourceMicroservice, ResourceMicroservice>();
        }
    }
}
