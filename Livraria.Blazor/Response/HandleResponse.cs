using Livraria.Application.DTOs;
using Livraria.Application.Response;
using Livraria.Blazor.Enum;

namespace Livraria.Blazor.Response;

public class HandleResponse
{
    public ResponseStatus Status { get; } 
    public List<string> Errors { get; }
    public ViewBook? ResponseData { get; } 

    public HandleResponse ( DefaultResponse<ViewBook> response )
    {
        Status = response.Errors.Count > 0 
            ? ResponseStatus.Error 
            : ResponseStatus.Success;
        Errors = response.Errors;
        ResponseData = response.Data;
    }

    public HandleResponse ( DefaultResponse<IEnumerable<ViewBook>> response )
    {
        Status = response.Data is null 
            ? ResponseStatus.Error 
            : ResponseStatus.Success;
        Errors = response.Errors;
        ResponseData = response.Data?.FirstOrDefault();
    }
}
