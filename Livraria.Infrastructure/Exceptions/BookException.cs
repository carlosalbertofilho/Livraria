namespace Livraria.Infrastructure.Exceptions;

public class BookException (
    string message = BookException._message ) : Exception( message )
{
    private const string _message = "Um erro ocorreu ao processar o Livro";
}
