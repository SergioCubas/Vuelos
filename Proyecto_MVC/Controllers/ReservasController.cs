using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.ProxyReservas;

namespace Proyecto_MVC.Controllers
{
    public class ReservasController : Controller
    {
        ServicioReservaClient miservReservas = new ServicioReservaClient();
        // GET: Reservas
        public ActionResult Index()
        {
            ViewBag.ListarReservas = miservReservas.ListarReservas();
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            return View();
        }

        public List<SelectListItem> ObtenerCiudadesOrigen()
        {
            List<SelectListItem> items = new SelectList(miservReservas.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Origen", Value = "0" });
            return items;
        }

        public List<SelectListItem> ObtenerCiudadesDestino()
        {
            List<SelectListItem> items = new SelectList(miservReservas.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Destino", Value = "0" });
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criterio1 = fc["criterio1"];
            String criterio2 = fc["criterio2"];
            String criterio = fc["criterio"];
            String criterioCiudadOrigen = fc["cboCiudadOrigen"];
            String criterioCiudadDestino = fc["cboCiudadDestino"];
            
            if (condicion.Equals("PorCiudadOrigen"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorCiudadOrigen(criterioCiudadOrigen);

            }

            else if (condicion.Equals("PorCiudadDestino"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorCiudadDestino(criterioCiudadDestino);

            }
            else if (condicion.Equals("PorDni"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorDni(criterio);

            }

            else if (condicion.Equals("PorFechaSalida"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorFechaSalida(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }
            else if (condicion.Equals("PorFechaLlegada"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorFechaLlegada(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }

            else

            {

                ViewBag.ListarReservas = miservReservas.ListarReservas();

            }
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            return View("Index");



        }
    }
}