using Livraria.Domain.Enums;
using Livraria.Domain.Exceptions;
using Livraria.Domain.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.Entities;

/// <summary>
/// Book entity
/// </summary>
/// <param name="title"></param>
/// <param name="author"></param>
/// <param name="publishedAt"></param>
/// <param name="publishingCompany"></param>
/// <param name="category"></param>
/// <param name="id"></param>
/// <param name="cover"></param>
/// <param name="synopsis"></param>
public class Book ( string title,
                  string author,
                  DateTime publishedAt,
                  PublishingCompany publishingCompany,
                  Category category,
                  int id = 0,
                  string cover = "",
                  string synopsis = "" )
{
    private string title = title;
    private string author = author;
    private DateTime publishedAt = publishedAt;
    private DateTime registetredAt = DateTime.UtcNow;
    private PublishingCompany publishingCompany = publishingCompany;
    private Category category = category;

    public int Id { get; private set; } = id;

    public string Title
    {
        get => title;
        private set
        {
            BookException.ThrowIfNullOrEmpty( value, "Título do livro é obrigatório" );
            title = value;
        }
    }

    public string Author
    {
        get => author;
        private set
        {
            BookException.ThrowIfNullOrEmpty( value, "Autor do livro é obrigatório" );
            author = value;
        }
    }

    public DateTime PublishedAt
    {
        get => publishedAt;
        private set
        {
            BookException.ThrowIfLessOrEqualZero( value.Ticks, "Data de publicação do livro é obrigatória" );
            publishedAt = value;
        }
    }

    public DateTime RegistetredAt
    {
        get => registetredAt;
        private set
        {
            registetredAt = value;
        }
    }


    public PublishingCompany PublishingCompany
    {
        get => publishingCompany;
        private set
        {
            BookException.ThrowIfNullOrEmpty( value, "Editora do livro é obrigatória" );
            publishingCompany = value;
        }
    }

    public string Cover { get; private set; } = cover;

    public string Synopsis { get; private set; } = synopsis;

    public Category Category
    {
        get => category;
        private set
        {
            BookException.ThrowIfNullOrEmpty( value, "Categoria do livro é obrigatória" );
            category = value;
        }
    }

    public void Update ( Book book )
    {
        Title = book.Title;
        Author = book.Author;
        PublishedAt = book.PublishedAt;
        PublishingCompany = book.PublishingCompany;
        Category = book.Category;
        Cover = book.Cover;
        Synopsis = book.Synopsis;
    }


    public string PublishingCompanyName
        => PublishingCompany.ToFriendlyString();

    public string CategoryName
        => Category.ToFriendlyString();

    public override string ToString ()
    {
        return $"{Title} - {Author} - {PublishingCompanyName} - {CategoryName}";
    }
}
