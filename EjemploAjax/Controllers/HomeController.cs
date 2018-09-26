using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]

        public ActionResult operacion (int n1,int n2, string opr )
        {
            /*Int32 t = numero * 5;
            ViewBag.Resultado = t;*/
             

             

            if (opr == "Potencia"){
                double resultado = 0;
                resultado = Math.Pow(n1, n2);
                ViewBag.Resultado = resultado;
            }
            else if (opr =="Factorial")
            {       int resultado = 1;
                for (int i = 1; i <= n1; i++)
                {
                   
                      resultado = resultado * i;
                    
                }
                int resultado2 = 1;
                for (int i = 1; i <= n2; i++)
                {

                    resultado2 = resultado2 * i;
                    
                }
                ViewBag.Resultado = "El Factorial de " + n1 + " es : " + resultado + " y "+ "El Factorial de " + n2+ " es :" + resultado2;

            }
            else if (opr == "Mayor"){
                if (n1 >n2){
                    int res = 0;
                    res=n1;
                    ViewBag.Resultado ="El mayor es "+ res;
                }
                else {
                    int res = 0;
                     res=n2;
                    ViewBag.Resultado = "El mayor es "+res;
                }
            }
            else if (opr == "Menor"){
                if (n1 <n2){
                    int resul = 0;
                    resul=n1;
                    ViewBag.Resultado = "El menor es "+ resul;
                }
                else {
                    int resul = 0;
                    resul=n2;
                    ViewBag.Resultado = "El menor es " + resul;
                }
            };



            return PartialView("Resultado");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}