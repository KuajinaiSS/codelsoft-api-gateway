using api_gateway.Microservices.Interfaces;

namespace api_gateway.Microservices.Extensions
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
