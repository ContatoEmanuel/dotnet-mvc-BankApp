using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BankApp.Models;

namespace BankApp.Controllers
{
    public class InvestmentsController : Controller
    {
        public IActionResult Index()
        {
            var investments = new List<Investments>
            {
                new Investments
                {
                    Id = 1,
                    Name = "CDB (Certificado de Depósito Bancário)",
                    Description = "Invista em CDBs e tenha segurança com rendimentos previsíveis.",
                    Amount = 1000,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(1)
                },
                new Investments
                {
                    Id = 2,
                    Name = "Tesouro Direto",
                    Description = "Invista no Tesouro Direto e tenha segurança e rentabilidade.",
                    Amount = 500,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(2)
                },
                new Investments
                {
                    Id = 3,
                    Name = "Fundos de Investimento",
                    Description = "Diversifique sua carteira com Fundos de Investimento.",
                    Amount = 2000,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(3)
                },
                new Investments
                {
                    Id = 4,
                    Name = "Ações",
                    Description = "Invista em ações e tenha potencial de altos rendimentos.",
                    Amount = 1500,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(5)
                }
            };

            return View(investments);
        }
    }
}
