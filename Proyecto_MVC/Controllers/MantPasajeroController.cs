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
    public class MantPasajeroController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantPasajero
        public ActionResult Index()
        {
            var tb_pasajero = db.Tb_pasajero.Include(t => t.Tb_pais);
            return View(tb_pasajero.ToList());
        }

        // GET: MantPasajero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pasajero tb_pasajero = db.Tb_pasajero.Find(id);
            if (tb_pasajero == null)
            {
                return HttpNotFound();
            }
            return View(tb_pasajero);
        }

        // GET: MantPasajero/Create
        public ActionResult Create()
        {
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre");
            return View();
        }

        // POST: MantPasajero/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPasajero,nombre,apaterno,amaterno,tipo_documento,num_documento,telefono,email,genero,F_Nacimiento,F_Registro,F_Modificacion,estado,idPais")] Tb_pasajero tb_pasajero)
        {
            if (ModelState.IsValid)
            {
                db.Tb_pasajero.Add(tb_pasajero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_pasajero.idPais);
            return View(tb_pasajero);
        }

        // GET: MantPasajero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pasajero tb_pasajero = db.Tb_pasajero.Find(id);
            if (tb_pasajero == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_pasajero.idPais);
            return View(tb_pasajero);
        }

        // POST: MantPasajero/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPasajero,nombre,apaterno,amaterno,tipo_documento,num_documento,telefono,email,genero,F_Nacimiento,F_Registro,F_Modificacion,estado,idPais")] Tb_pasajero tb_pasajero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_pasajero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPais = new SelectList(db.Tb_pais, "idPais", "nombre", tb_pasajero.idPais);
            return View(tb_pasajero);
        }

        // GET: MantPasajero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pasajero tb_pasajero = db.Tb_pasajero.Find(id);
            if (tb_pasajero == null)
            {
                return HttpNotFound();
            }
            return View(tb_pasajero);
        }

        // POST: MantPasajero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_pasajero tb_pasajero = db.Tb_pasajero.Find(id);
            db.Tb_pasajero.Remove(tb_pasajero);
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
