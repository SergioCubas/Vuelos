using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;

namespace Proyecto_MVC.Controllers
{
    public class MantAvionController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantAvion
        public ActionResult Index()
        {
            var tb_avion = db.Tb_avion.Include(t => t.Tb_aerolinea);
            return View(tb_avion.ToList());
        }

        // GET: MantAvion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_avion tb_avion = db.Tb_avion.Find(id);
            if (tb_avion == null)
            {
                return HttpNotFound();
            }
            return View(tb_avion);
        }

        // GET: MantAvion/Create
        public ActionResult Create()
        {
            ViewBag.idAerolinea = new SelectList(db.Tb_aerolinea, "idAerolinea", "ruc");
            return View();
        }

        // POST: MantAvion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAvion,capacidad,codigo,F_Registro,F_Modificacion,estado,idAerolinea")] Tb_avion tb_avion)
        {
            if (ModelState.IsValid)
            {
                db.Tb_avion.Add(tb_avion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idAerolinea = new SelectList(db.Tb_aerolinea, "idAerolinea", "ruc", tb_avion.idAerolinea);
            return View(tb_avion);
        }

        // GET: MantAvion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_avion tb_avion = db.Tb_avion.Find(id);
            if (tb_avion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idAerolinea = new SelectList(db.Tb_aerolinea, "idAerolinea", "ruc", tb_avion.idAerolinea);
            return View(tb_avion);
        }

        // POST: MantAvion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAvion,capacidad,codigo,F_Registro,F_Modificacion,estado,idAerolinea")] Tb_avion tb_avion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_avion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idAerolinea = new SelectList(db.Tb_aerolinea, "idAerolinea", "ruc", tb_avion.idAerolinea);
            return View(tb_avion);
        }

        // GET: MantAvion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_avion tb_avion = db.Tb_avion.Find(id);
            if (tb_avion == null)
            {
                return HttpNotFound();
            }
            return View(tb_avion);
        }

        // POST: MantAvion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_avion tb_avion = db.Tb_avion.Find(id);
            db.Tb_avion.Remove(tb_avion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
