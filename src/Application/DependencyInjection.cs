using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Jaroszek.CCoderHouse.IFormFilePoC.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        return services;
    }
}