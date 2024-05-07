using Livraria.Application.DTOs;
using Livraria.Domain.Entities;

namespace Livraria.Application.Extensions;

public static class ViewBookExtension
{
    public static ViewBook ToViewBook ( this Book book )
        => new( book.Title,
               book.Author,
               book.PublishedAt,
               book.PublishingCompany,
               book.Category,
               book.Id,
               book.Cover,
               book.Synopsis );

    public static Book ToBook ( this ViewBook viewBook )
        => new( viewBook.Title,
               viewBook.Author,
               viewBook.PublishedAt,
               viewBook.PublishingCompany,
               viewBook.Category,
               viewBook.Id,
               viewBook.Cover,
               viewBook.Synopsis );
}
