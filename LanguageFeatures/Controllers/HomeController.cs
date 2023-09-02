namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        await Task.Delay(10000);
        return View("Index");
    }
}