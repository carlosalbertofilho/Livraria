using Livraria.Domain.Abstrations;
using Livraria.Domain.Entities;
using Livraria.Domain.Exceptions;
using Livraria.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.Repositories;

public class BookRepository (
    ApplicationDbContext context ) : IBookRepository
{

    private readonly ApplicationDbContext _context = context;
    public async Task<IEnumerable<Book>> GetAllAsync ()
    {
        var books = await _context.Books.ToListAsync()
            ?? throw new BookException("Nenhum livro cadastrado");
        return books;
    }

    public async Task<Book> GetByIdAsync ( int id )
    {
        var book = await _context.Books.FindAsync(id)
            ?? throw new BookException("Livro não encontrado!");
        return book;
    }

    public async Task<Book> CreateAsync ( Book book )
    {
        try
        {
            await _context.Books.AddAsync( book );
            await _context.SaveChangesAsync();
            return book;
        }
        catch
        {
            throw new BookException( "Falha ao criar livro" );
        }
    }

    public async Task DeleteAsync ( int id )
    {
        try
        {
            var book = await _context.Books.FindAsync(id)
            ?? throw new BookException("Livro não encontrado!");
            _context.Books.Remove( book );
            await _context.SaveChangesAsync();
        }
        catch
        {
            throw new BookException( "Falha ao Deletar o Livro" );
        }
    }
    public async Task<Book> UpdateAsync ( Book book )
    {

        try
        {
            var bookToUpdate = await _context.Books.FindAsync(book.Id)
                   ?? throw new BookException("Livro não encontrado!");
            bookToUpdate.Update( book );
            _context.Books.Update( bookToUpdate );
            await _context.SaveChangesAsync();
            return bookToUpdate;
        }
        catch ( Exception e)
        {
            throw new BookException( e.Message );
        }
    }
}
