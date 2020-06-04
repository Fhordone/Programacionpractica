using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demomvc.Models;
using demomvc.Data;

namespace demomvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly DatabaseContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }


        public  IActionResult ContactoCreate(Contacto objContacto){

            if (ModelState.IsValid)
            {
                 objContacto.Mensaje = "Hola Mundo " + objContacto.FirstName + 
                 " su Calculo es " +  (objContacto.Operador1* objContacto.Operador2);

                _context.Add(objContacto);
                _context.SaveChanges();

                 return View("Contacto",objContacto);   
            }
            return View("Contacto");
        }



        public IActionResult GetContactos()
        {
            /*var listContactos = new List<Contacto>();
            listContactos.Add(
                new Contacto(){ FirstName="Juan",LastName="Perez", Agree=true, Gender="M", Country="PE",Email="jperez@gmail.com" });
            listContactos.Add(
                new Contacto(){ FirstName="Shakira",LastName="Gomez", Agree=true, Gender="F", Country="CO",Email="shakira@gmail.com" });
            listContactos.Add(
                new Contacto(){ FirstName="Bob",LastName="Tracy", Agree=false, Gender="M", Country="US",Email="rob@gmail.com" });
            */
            var listContactos=_context.Contactos.ToList();
            return View("ListaContactos",listContactos);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
