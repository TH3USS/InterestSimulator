using Microsoft.AspNetCore.Mvc;
using InterestSimulator.Models;

namespace InterestSimulator.Controllers
{
    public class SimuladorJurosController : Controller
    {
        // Exibe o formulário
        public IActionResult Index()
        {
            return View();
        }

        // Recebe o formulário e calcula o valor
        [HttpPost]
        public IActionResult Calcular(SimuladorJuros simuladorJuros)
        {
            if (ModelState.IsValid)
            {
                simuladorJuros.CalcularJurosSimples();
                // Se você quiser calcular juros compostos, use:
                // simuladorJuros.CalcularJurosCompostos();

                return View("Resultado", simuladorJuros);
            }

            return View("Index", simuladorJuros);
        }
    }
}
