using Livraria.Application.Abstrations;
using Livraria.Application.DTOs;
using Livraria.Application.Response;
using Livraria.Domain.Abstrations;
using Livraria.Infrastructure.Repositories;

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

    public Task<DefaultResponse<ViewBook>> Delete ( int id )
    {
        throw new NotImplementedException();
    }

    public Task<DefaultResponse<IEnumerable<ViewBook>>> GetAll ()
    {
        throw new NotImplementedException();
    }

    public Task<DefaultResponse<ViewBook>> GetById ( int id )
    {
        throw new NotImplementedException();
    }

    public Task<DefaultResponse<ViewBook>> Update ( EditBook book )
    {
        throw new NotImplementedException();
    }
}
