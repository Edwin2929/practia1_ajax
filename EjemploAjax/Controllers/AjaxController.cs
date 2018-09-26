using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploAjax.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Operar( string nombre)
        {
            string n = nombre;
            ViewBag.Resultado = n;
            return View("Operar");
        }
    }
}