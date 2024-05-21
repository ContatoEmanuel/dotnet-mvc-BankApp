using Microsoft.AspNetCore.Mvc;

namespace BankApp.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
