using Livraria.Application.Abstrations;
using Livraria.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.CrossCutting.DependenciesApp;

public static class AddServices
{
    public static IServiceCollection AddServicesApp 
        ( this IServiceCollection services )
    {
        services.AddScoped<IBookService, BookService>();
        return services;
    }
}
