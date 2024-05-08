using Livraria.Application.Enum;

namespace Livraria.Application.Response;

public class DefaultResponse<T>
{
    public List<T> Data { get; private set; } = [];
    public List<string> Errors { get; private set; } = [];
    public ResponseStatus Status { get; private set; }

    public DefaultResponse
        ( List<T> data,
        ResponseStatus status = ResponseStatus.Success )
    {
        Data = data;
        Status = status;
    }
    public DefaultResponse
        ( T data,
        ResponseStatus status = ResponseStatus.Success )
    {
        Data.Add( data );
        Status = status;
    }

    public DefaultResponse
        ( List<string> errors,
        ResponseStatus status = ResponseStatus.Error )
    {
        Errors = errors;
        Status = status;
    }

    public DefaultResponse
        ( string errors,
        ResponseStatus status = ResponseStatus.Error )
    {
        Errors.Add( errors );
        Status = status;
    }
}
