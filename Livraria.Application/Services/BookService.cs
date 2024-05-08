using Livraria.Application.Abstrations;
using Livraria.Application.DTOs;
using Livraria.Application.Response;
using Livraria.Domain.Abstrations;
using Livraria.Application.Extensions;

namespace Livraria.Application.Services;

public class BookService ( IBookRepository bookRepository ) : IBookService
{
    private readonly IBookRepository _bookRepository = bookRepository;

    public async Task<DefaultResponse<ViewBook>> Create ( EditBook book )
    {
		try
		{
			var createdBook = await _bookRepository.CreateAsync( book );
			return new( createdBook );
		}
		catch ( Exception e )
		{
            return new( e.Message );

        }
    }
    public async Task<DefaultResponse<IEnumerable<ViewBook>>> GetAll ()
    {
        try
        {
            var books = await _bookRepository.GetAllAsync();
            return new DefaultResponse<IEnumerable<ViewBook>>( books.ToViewBook() );
        }
        catch ( Exception e )
        {
            return new( e.Message );
        }
    }

    public async Task<DefaultResponse<ViewBook>> GetById ( int id )
    {
        try
        {
            var book = await _bookRepository.GetByIdAsync( id );
            return new( book.ToViewBook() );
        }
        catch (Exception e)
        {
            return new( e.Message );
        }
    }
    public async Task<DefaultResponse<ViewBook>> Delete ( int id )
    {
        try
        {
            var book = await _bookRepository.GetByIdAsync( id );
            await _bookRepository.DeleteAsync( id );
            return new( book.ToViewBook() );
        }
        catch ( Exception e )
        {
            return new( e.Message );
        }
    }

    public async Task<DefaultResponse<ViewBook>> Update ( EditBook book )
    {
        try
        {
            var updatedBook = await _bookRepository.UpdateAsync( book );
            return new( updatedBook );
        }
        catch ( Exception e )
        {
            return new( e.Message );
        }
    }
}
