using Livraria.Application.DTOs;
using Livraria.Application.Response;
using Livraria.Blazor.Enum;

namespace Livraria.Blazor.Response;

public class HandleResponse ( DefaultResponse<ViewBook> response )
{
    public ResponseStatus Status { get; } 
        = response.Errors.Count > 0 
        ? ResponseStatus.Error 
        : ResponseStatus.Success;
    public List<string> Errors { get; } = response.Errors;
    public ViewBook? ResponseData { get; } = response.Data;
}
