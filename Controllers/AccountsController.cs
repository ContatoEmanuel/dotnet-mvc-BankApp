using Microsoft.AspNetCore.Mvc;

namespace BankApp.Controllers
{
    //Tipos de Contas Bancarias
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
