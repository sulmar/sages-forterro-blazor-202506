using Bogus;

namespace Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFakeEntities<T, TFaker>(
        this IServiceCollection services,
        int count = 10)
        where T : class
        where TFaker : Faker<T>, new()
    {
        services.AddSingleton<Faker<T>, TFaker>();
        services.AddSingleton<IEnumerable<T>>(sp => sp.GetRequiredService<Faker<T>>().Generate(count));

        return services;
    }
}
