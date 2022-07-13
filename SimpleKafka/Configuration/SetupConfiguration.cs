using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace SimpleKafka.Configuration;
public static class ConfigurationRegistration
{
    public static void RegisterConfiguration(this IServiceCollection servicesBuilder)
    {
        servicesBuilder.AddSettings<RetryConfiguration>();
        servicesBuilder.AddSettings<KafkaConfiguration>();
        servicesBuilder.AddSettings<TopicCreationConfiguration>();
    }

    private static IServiceCollection AddSettings<TSettings>(this IServiceCollection services) where TSettings : BaseConfiguration
    {
        services.AddSingleton(provider =>
        {
            var config = provider.GetService<IConfiguration>();
            if (config == null)
                throw new NullReferenceException("Configuration Service Not Available");
            var configuration = config.GetSection(typeof(TSettings).Name).Get<TSettings>();
            return configuration;
        });
        return services;
    }
}