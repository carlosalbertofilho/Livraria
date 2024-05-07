using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.Context;

public class ApplicationDbContext ( DbContextOptions options ) : DbContext( options )
{
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating ( ModelBuilder builder )
    {
        base.OnModelCreating( builder );
        builder.ApplyConfigurationsFromAssembly( typeof( ApplicationDbContext ).Assembly );
    }
}