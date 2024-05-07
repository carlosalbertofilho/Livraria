using Livraria.Application.Abstrations;
using Livraria.Application.DTOs;
using Livraria.Application.Response;
using Livraria.Domain.Abstrations;
using Livraria.Infrastructure.Repositories;
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
			return new DefaultResponse<ViewBook>( createdBook );
		}
		catch ( Exception e )
		{
            return new DefaultResponse<ViewBook>( e.Message );

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
            return new DefaultResponse<IEnumerable<ViewBook>>( e.Message );
        }
    }

    public Task<DefaultResponse<ViewBook>> GetById ( int id )
    {
        throw new NotImplementedException();
    }
    public Task<DefaultResponse<ViewBook>> Delete ( int id )
    {
        throw new NotImplementedException();
    }

    public Task<DefaultResponse<ViewBook>> Update ( EditBook book )
    {
        throw new NotImplementedException();
    }
}
