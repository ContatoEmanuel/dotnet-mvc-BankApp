using BankApp.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para enviar email ou salvar a mensagem no banco de dados

                // Redirecionar para uma página de confirmação
                return RedirectToAction("Confirmation");
            }

            return View(model);
        }

        // GET: Contact/Confirmation
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
