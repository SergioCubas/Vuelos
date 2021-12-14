using Proyecto_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_MVC.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Tb_pasajero user)
        {
            if (ModelState.IsValid)
            {
                using (Agencia_BDEntities db = new Agencia_BDEntities())
                {
                    var obj = db.Tb_pasajero.Where
                        (a => a.email.Equals(user.email)
                        && a.num_documento.Equals(user.num_documento)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.idPasajero.ToString();
                        Session["UserNombre"] = obj.nombre.ToString();
                        Session["UserRol"] = obj.id_Rol.ToString();

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.message = "Credenciales incorrectas";
                    }
                }
            }
            return View(user);
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

        [HttpGet]
        public ActionResult Logout()
        {
            Session["UserID"] = null;
            Session["UserNombre"] = null;
            Session["UserRol"] = null;

            return View("Index");
        }
    }
}