using Proyecto_MVC.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_MVC.Controllers
{
    public class DetallePagoController : Controller
    {
        // GET: DetallePago
        private Agencia_BDEntities db = new Agencia_BDEntities();

        public ActionResult Index(String dni)
        {
            dynamic mymodel = new ExpandoObject();

            mymodel.detalle = db.usp_ListarPasajeroDetallePagoPorDocumento(dni);

            return View(mymodel);
        }
    }
}
