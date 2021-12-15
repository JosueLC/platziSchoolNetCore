using System;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public IActionResult Index()
        {
            Escuela escuela = new();
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Colegio San Francis";
            escuela.AñoDeCreación = 2000;

            ViewBag.cosaDinamica = "Hol@ Mundo";

            return View(escuela);
        }
    }
}