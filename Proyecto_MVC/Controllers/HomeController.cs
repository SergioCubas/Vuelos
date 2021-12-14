using Proyecto_MVC.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Proyecto_MVC.ProxyVuelos;
using Proyecto_MVC.ProxyPasajeros;

namespace Proyecto_MVC.Controllers
{
    public class HomeController : Controller
    {

        ServicioVueloClient miservVuelos = new ServicioVueloClient();

        public ActionResult Index()
        {
            ViewBag.ListarVuelos = miservVuelos.GetAllVuelos();
            return View();

            //mymodel.Vuelos = miservVuelos.GetAllVuelos ();
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
        public ActionResult Mantenimiento()
        {
            ViewBag.Message = "Mantenimiento de tablas";

            return View();
        }
    }
}