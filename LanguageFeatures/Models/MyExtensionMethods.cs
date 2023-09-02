namespace LanguageFeatures.Models;

public static class MyExtensionMethods
{
    public static decimal TotalPrice(this IEnumerable<Product?> products)
    {
        decimal total = 0m;
        foreach (Product? maybeProduct in products)
        {
            total += maybeProduct?.Price ?? 0m;
        }
        return total;
    }

    public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> productEnum, decimal minimumPrice)
    {
        foreach (Product? prod in productEnum)
        {
            if ((prod?.Price ?? 0m ) >= minimumPrice)
            {
                yield return prod;
            }
        }
    }
}