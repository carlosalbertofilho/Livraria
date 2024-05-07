using Livraria.Domain.Abstrations;
using Livraria.Infrastructure.Context;
using Livraria.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.CrossCutting.DependenciesApp;

public static class DbInjections
{
    public static IServiceCollection AddDbInfra (
        this IServiceCollection services, IConfiguration configuration )
    {
        var connectionString =
            configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Não consegue conectar no banco de dados");

        services.AddDbContext<ApplicationDbContext>( options
            => options.UseSqlServer( connectionString ) );

        services.AddScoped<IBookRepository, BookRepository>();

        return services;
    }
}
