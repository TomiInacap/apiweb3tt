using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicacionWebparaEva3TT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripcion de la Pagina AppWeb para Eva3 TT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tu Pagina de Contacto.";

            return View();
        }
    }
}