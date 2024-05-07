using Livraria.Domain.Enums;

namespace Livraria.Domain.Extensions;

/// <summary>
/// Cast the category to a friendly string
/// </summary>
public static class CategoryExtension
{
    public static string ToFriendlyString ( this Category category )
    {
        return category switch
        {
            Category.Informatica => "Informática",
            Category.Ficcao => "Ficção",
            Category.Biografia => "Biografia",
            Category.Romance => "Romance",
            Category.Suspense => "Suspense",
            Category.Terror => "Terror",
            Category.AutoAjuda => "Autoajuda",
            Category.Religiao => "Religião",
            Category.Historia => "História",
            Category.Poesia => "Poesia",
            Category.Conto => "Conto",
            Category.Fantasia => "Fantasia",
            Category.Drama => "Drama",
            Category.Aventura => "Aventura",
            Category.Comedia => "Comédia",
            Category.Culinaria => "Culinária",
            Category.Nenhum => "Nenhum",
            _ => throw new ArgumentOutOfRangeException( nameof( category ), category, null ),
        };
    }
}
