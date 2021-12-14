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
    public class MantAeropuertoController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantAeropuerto
        public ActionResult Index()
        {
            var tb_aeropuerto = db.Tb_aeropuerto.Include(t => t.Tb_pais);
            return View(tb_aeropuerto.ToList());
        }

        // GET: MantAeropuerto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aeropuerto tb_aeropuerto = db.Tb_aeropuerto.Find(id);
            if (tb_aeropuerto == null)
            {
                return HttpNotFound();
            }
            return View(tb_aeropuerto);
        }

        // GET: MantAeropuerto/Create
        public ActionResult Create()
        {
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre");
            return View();
        }

        // POST: MantAeropuerto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAeropuerto,nombre,F_Registro,F_Modificacion,estado,idPais")] Tb_aeropuerto tb_aeropuerto)
        {
            if (ModelState.IsValid)
            {
                db.Tb_aeropuerto.Add(tb_aeropuerto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_aeropuerto.idPais);
            return View(tb_aeropuerto);
        }

        // GET: MantAeropuerto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aeropuerto tb_aeropuerto = db.Tb_aeropuerto.Find(id);
            if (tb_aeropuerto == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_aeropuerto.idPais);
            return View(tb_aeropuerto);
        }

        // POST: MantAeropuerto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAeropuerto,nombre,F_Registro,F_Modificacion,estado,idPais")] Tb_aeropuerto tb_aeropuerto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_aeropuerto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_aeropuerto.idPais);
            return View(tb_aeropuerto);
        }

        // GET: MantAeropuerto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aeropuerto tb_aeropuerto = db.Tb_aeropuerto.Find(id);
            if (tb_aeropuerto == null)
            {
                return HttpNotFound();
            }
            return View(tb_aeropuerto);
        }

        // POST: MantAeropuerto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_aeropuerto tb_aeropuerto = db.Tb_aeropuerto.Find(id);
            db.Tb_aeropuerto.Remove(tb_aeropuerto);
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
