namespace Livraria.Application.Response;

public class DefaultResponse<T>
{
    public T? Data { get; private set; }
    public List<string> Errors { get; private set; } = [];

    public DefaultResponse( T? data )
    {
        Data = data;
    }

    public DefaultResponse(List<string> errors)
    {
        Errors = errors;
    }

    public DefaultResponse( string errors )
    {
        Errors.Add( errors );
    }
}
