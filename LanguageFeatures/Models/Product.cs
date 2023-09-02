namespace LanguageFeatures.Models;

public class Product
{
    public string Name  {get; set;} = String.Empty;
    public decimal? Price {get; set;}
    public static Product?[] GetProducts()
    {
        Product kayak = new Product() {Name ="Kayak", Price = 275m};
        Product lifejacket = new Product() {Name ="LifeJacket", Price=48.95m};
        return new Product?[] {kayak, lifejacket, null};
    }

}