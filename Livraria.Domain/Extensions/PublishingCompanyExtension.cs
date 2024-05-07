using Livraria.Domain.Enums;

namespace Livraria.Domain.Extensions;

/// <summary>
/// Cast the publishing company to a friendly string
/// </summary>
public static class PublishingCompanyExtension
{
    public static string ToFriendlyString ( this PublishingCompany publishingCompany )
    {
        return publishingCompany switch
        {
            PublishingCompany.CasaDoCodigo => "Casa do Código",
            PublishingCompany.Novatec => "Novatec",
            PublishingCompany.AltaBooks => "Alta Books",
            PublishingCompany.Intrinseca => "Intrínseca",
            PublishingCompany.Sextante => "Sextante",
            PublishingCompany.Nenhum => "Nenhum",
            _ => throw new ArgumentOutOfRangeException( nameof( publishingCompany ), publishingCompany, null ),
        };
    }
}
