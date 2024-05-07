using Livraria.Application.Extensions;
using Livraria.Domain.Entities;
using Livraria.Domain.Enums;

namespace Livraria.Application.DTOs;

public record ViewBook (
    string Title,
    string Author,
    DateTime PublishedAt,
    PublishingCompany PublishingCompany,
    Category Category,
    int Id = 0,
    string Cover = "",
    string Synopsis = "" )
{
    public static implicit operator ViewBook( Book book )
        => book.ToViewBook();

    public static implicit operator Book( ViewBook viewBook )
        => viewBook.ToBook();
};