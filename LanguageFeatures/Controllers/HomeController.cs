namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        Dictionary<string, Product> products = new()
        {
            ["Kayak"]=new Product {Name = "Kayak", Price=275m},
            ["LifeJacket"]=new Product {Name = "LifeJacket", Price=630m}
        };
        return View("Index", products.Keys);
    }
}