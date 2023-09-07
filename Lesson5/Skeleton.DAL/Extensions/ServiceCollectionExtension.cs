using Microsoft.Extensions.DependencyInjection;

namespace Skeleton.DAL.Extensions;

public static class ServiceCollectionExtension
{
    public static void InjectDatabaseServices(this IServiceCollection services)
    {
        services.AddDatabase();
    }

    private static void AddDatabase(this IServiceCollection services)
    {
        // add database here; use sql server
    }
}