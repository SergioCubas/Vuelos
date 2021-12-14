using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;
using Proyecto_MVC.ProxyPasajeros;

namespace Proyecto_MVC.Controllers
{
    public class PasajeroaController : Controller
    {
        // GET: Pasajeroa
        ServicioPasajeroClient miservPasajeros = new ServicioPasajeroClient();
        
        public ActionResult Index()
        {
            ViewBag.ListarPasajeros = miservPasajeros.ListarPasajeros();
            ViewBag.ListarGeneros = ObtenerGeneros();
            ViewBag.ListarPais = ObtenerPaises();
            ViewBag.ListarDepartamentos = ObtenerDepartamentos();
            return View();
        }
        public List<SelectListItem> ObtenerDepartamentos()
        {
            List<SelectListItem> items = new SelectList(miservPasajeros.ListarDepartamentos(), "NomDep", "NomDep").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Departamento", Value = "0" });
            return items;
        }

        public List<SelectListItem> ObtenerPaises()
        {
            List<SelectListItem> items = new SelectList(miservPasajeros.ListarPaises(), "NomPais", "NomPais").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione País", Value = "0" });
            return items;
        }
        public List<SelectListItem> ObtenerGeneros()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem{Text = "Selecccione género", Value = "0"},
                new SelectListItem{Text = "Femenino", Value = "f"},
                new SelectListItem{Text = "Masculino", Value = "m"},
            };
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criteriogenero = fc["cboGenero"];
            String criteriopais = fc["cboPais"];
            String criterioDepartamento = fc["cboDepartamento"];

            if (condicion.Equals("PorGenero"))

            {

                ViewBag.ListarPasajeros = miservPasajeros.ListarPasajerosPorGenero(criteriogenero);

            }

            else if (condicion.Equals("PorDepartamento"))

            {

                ViewBag.ListarPasajeros = miservPasajeros.ListarPasajerosPorDepartamento(criterioDepartamento);

            }
            else if (condicion.Equals("PorPais"))

            {

                ViewBag.ListarPasajeros = miservPasajeros.ListarPasajerosPorPais(criteriopais);

            }

            else

            {

                ViewBag.ListarPasajeros = miservPasajeros.ListarPasajeros();

            }
            ViewBag.ListarGeneros = ObtenerGeneros();
            ViewBag.ListarPais = ObtenerPaises();
            ViewBag.ListarDepartamentos = ObtenerDepartamentos();
            return View("Index");



        }

        


    }
}