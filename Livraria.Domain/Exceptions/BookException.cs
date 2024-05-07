using Livraria.Domain.Enums;

namespace Livraria.Domain.Exceptions;

public class BookException (
    string message = BookException.DefaultMessage ) : Exception( message )
{
    private const string DefaultMessage = "Livro inválido";

    /// <summary>
    /// Thows an exception if the value is null or empty
    /// </summary>
    /// <param name="value"></param>
    /// <param name="message"></param>
    /// <exception cref="BookException"></exception>
    public static void ThrowIfNullOrEmpty ( string value, string message )
    {
        if ( string.IsNullOrEmpty( value ) )
        {
            throw new BookException( message );
        }
    }

    /// <summary>
    /// Thows an exception if price is less than or equal to zero
    /// </summary>
    /// <param name="value"></param>
    /// <param name="message"></param>
    /// <exception cref="BookException"></exception>
    public static void ThrowIfLessOrEqualZero ( decimal value, string message )
    {
        if ( value <= 0 )
        {
            throw new BookException( message );
        }
    }

    /// <summary>
    /// Thows an exception if the value is null or empty
    /// </summary>
    /// <param name="value"></param>
    /// <param name="v"></param>
    /// <exception cref="BookException"></exception>
    internal static void ThrowIfNullOrEmpty ( Category value, string message )
    {
        if ( value.Equals( null ) )
        {
            throw new BookException( message );
        }
    }

    /// <summary>
    /// Thows an exception if the value is null or empty
    /// </summary> 
    /// <param name="value"></param>
    /// <param name="message"></param>
    /// <exception cref="BookException"></exception>
    internal static void ThrowIfNullOrEmpty ( PublishingCompany value, string message )
    {
        throw new BookException( message );
    }
}
