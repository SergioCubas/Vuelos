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
    public class MantDestinoController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantDestino
        public ActionResult Index()
        {
            var tb_Destino = db.Tb_Destino.Include(t => t.Tb_aeropuerto);
            return View(tb_Destino.ToList());
        }

        // GET: MantDestino/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Destino tb_Destino = db.Tb_Destino.Find(id);
            if (tb_Destino == null)
            {
                return HttpNotFound();
            }
            return View(tb_Destino);
        }

        // GET: MantDestino/Create
        public ActionResult Create()
        {
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre");
            return View();
        }

        // POST: MantDestino/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDestino,F_Registro,F_Modificacion,estado,idAeropuerto")] Tb_Destino tb_Destino)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Destino.Add(tb_Destino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_Destino.idAeropuerto);
            return View(tb_Destino);
        }

        // GET: MantDestino/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Destino tb_Destino = db.Tb_Destino.Find(id);
            if (tb_Destino == null)
            {
                return HttpNotFound();
            }
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_Destino.idAeropuerto);
            return View(tb_Destino);
        }

        // POST: MantDestino/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDestino,F_Registro,F_Modificacion,estado,idAeropuerto")] Tb_Destino tb_Destino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Destino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_Destino.idAeropuerto);
            return View(tb_Destino);
        }

        // GET: MantDestino/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Destino tb_Destino = db.Tb_Destino.Find(id);
            if (tb_Destino == null)
            {
                return HttpNotFound();
            }
            return View(tb_Destino);
        }

        // POST: MantDestino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Destino tb_Destino = db.Tb_Destino.Find(id);
            db.Tb_Destino.Remove(tb_Destino);
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
