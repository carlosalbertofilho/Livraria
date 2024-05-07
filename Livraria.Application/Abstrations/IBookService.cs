using Livraria.Application.DTOs;
using Livraria.Application.Response;

namespace Livraria.Application.Abstrations;

public interface IBookService
{
    Task<DefaultResponse<ViewBook>> Create ( EditBook book );
    Task<DefaultResponse<ViewBook>> Update(EditBook book);
    Task<DefaultResponse<ViewBook>> Delete(int id);
    Task<DefaultResponse<IEnumerable<ViewBook>>> GetAll();
    Task<DefaultResponse<ViewBook>> GetById(int id);
}
