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
using Proyecto_MVC.ProxyReservas;

namespace Proyecto_MVC.Controllers
{
    public class HomeController : Controller
    {

        ServicioVueloClient miservVuelos = new ServicioVueloClient();
        ServicioReservaClient miservReservas = new ServicioReservaClient();

        public ActionResult Index()
        {
            ViewBag.ListarVuelos = miservVuelos.GetAllVuelos();


            return View();

            //mymodel.Vuelos = miservVuelos.GetAllVuelos ();
        }

        [HttpPost]
        public ActionResult Reserva(Tb_reserva reserva)
        {
            if (ModelState.IsValid)
            {
                int idPasajero = (int)reserva.idPasajero;
                int idReserva = (int)reserva.idReserva;

                miservReservas.GenerarReserva(idPasajero, idReserva);

            }
            TempData["exit"] = "Reserva creada exitosamente!";

            return RedirectToAction("Index", "Home");
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


       

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Home");
            }

        }
    }
}