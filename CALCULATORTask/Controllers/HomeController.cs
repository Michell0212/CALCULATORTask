using Microsoft.AspNetCore.Mvc;
using CursoMVC.Models;

namespace CursoMVC.Controllers
{
    public class HomeController : Controller
    {

        // =======================
        //       CALCULADORA
        // =======================
        [HttpGet]
        public IActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculadora(Calculadora model)
        {
            switch (model.operaciones)
            {
                case Operaciones.Suma:
                    model.resultado = model.n1 + model.n2;
                    break;
                case Operaciones.Resta:
                    model.resultado = model.n1 - model.n2;
                    break;
                case Operaciones.Multiplicacion:
                    model.resultado = model.n1 * model.n2;
                    break;
                case Operaciones.Division:
                    if (model.n2 == 0)
                    {
                        ModelState.AddModelError("", "No se puede dividir para 0.");
                        return View(model);
                    }
                    model.resultado = model.n1 / model.n2;
                    break;
            }

            return View(model);
        }
    }
}