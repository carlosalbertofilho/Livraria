using Livraria.Application.DTOs;
using Livraria.Domain.Entities;

namespace Livraria.Application.Extensions;

public static class EditBookExtension
{
    public static Book ToBook ( this EditBook editBook ) 
        => new( editBook.Title,
               editBook.Author,
               editBook.PublishedAt,
               editBook.PublishingCompany,
               editBook.Category,
               0,
               editBook.Cover,
               editBook.Synopsis );
    public static EditBook ToEditBook ( this Book book )
        => new( book.Title,
               book.Author,
               book.PublishedAt,
               book.PublishingCompany,
               book.Category,
               book.Cover,
               book.Synopsis );
}
