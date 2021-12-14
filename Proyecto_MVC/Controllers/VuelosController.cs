using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;
using Proyecto_MVC.ProxyVuelos;

namespace Proyecto_MVC.Controllers
{
    public class VuelosController : Controller
    {
        ServicioVueloClient miservVuelos = new ServicioVueloClient();
        // GET: Vuelos
        public ActionResult Index()
        {
            ViewBag.ListarVuelos = miservVuelos.GetAllVuelos();
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            ViewBag.ListarAerolinea = ObtenerAerolineas();
            //ViewBag.ListarFechaOrigen = ObtenerFechasOrigen();
            //ViewBag.ListarFechaLlegada = ObtenerFechasLlegada();
            return View();
        }

        public List<SelectListItem> ObtenerCiudadesOrigen()
        {
            List<SelectListItem> items = new SelectList(miservVuelos.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Origen", Value = "0" });
            return items;
        }

        public List<SelectListItem> ObtenerCiudadesDestino()
        {
            List<SelectListItem> items = new SelectList(miservVuelos.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Destino", Value = "0" });
            return items;
        }

        public List<SelectListItem> ObtenerAerolineas()
        {
            List<SelectListItem> items = new SelectList(miservVuelos.ListarAerolineas(), "nombre_aerolinea", "nombre_aerolinea").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Aerolinea", Value = "0" });
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criterio1 = fc["criterio1"];
            String criterio2 = fc["criterio2"];
            String criterioCiudadOrigen = fc["cboCiudadOrigen"];
            String criterioCiudadDestino = fc["cboCiudadDestino"];
            String criterioAerolinea = fc["cboAerolinea"];

            if (condicion.Equals("PorCiudadOrigen"))

            {

                ViewBag.ListarVuelos = miservVuelos.ListarPorCiudadOrigen(criterioCiudadOrigen);

            }

            else if (condicion.Equals("PorCiudadDestino"))

            {

                ViewBag.ListarVuelos = miservVuelos.ListarPorCiudadDestino(criterioCiudadDestino);

            }
        
            else if (condicion.Equals("PorAerolinea"))

            {

                ViewBag.ListarVuelos = miservVuelos.ListarPorAerolinea(criterioAerolinea);

            }
            else if (condicion.Equals("PorFechaSalida"))

            {

                ViewBag.ListarVuelos = miservVuelos.ListarPorFechaSalida(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }
            else if (condicion.Equals("PorFechaLlegada"))

            {

                ViewBag.ListarVuelos = miservVuelos.ListarPorFechaLlegada(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }

            else

            {

                ViewBag.ListarVuelos = miservVuelos.GetAllVuelos();

            }
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            ViewBag.ListarAerolinea = ObtenerAerolineas();
            return View("Index");



        }
    }
}