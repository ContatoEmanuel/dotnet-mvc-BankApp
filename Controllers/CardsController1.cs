using Microsoft.AspNetCore.Mvc;

public class CardsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
