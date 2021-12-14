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
    public class MantAsientoController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantAsiento
        public ActionResult Index()
        {
            return View(db.Tb_asiento.ToList());
        }

        // GET: MantAsiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_asiento tb_asiento = db.Tb_asiento.Find(id);
            if (tb_asiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_asiento);
        }

        // GET: MantAsiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantAsiento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAsiento,tipo,fila,letra,precio,F_Registro,F_Modificacion,estado")] Tb_asiento tb_asiento)
        {
            if (ModelState.IsValid)
            {
                db.Tb_asiento.Add(tb_asiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_asiento);
        }

        // GET: MantAsiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_asiento tb_asiento = db.Tb_asiento.Find(id);
            if (tb_asiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_asiento);
        }

        // POST: MantAsiento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAsiento,tipo,fila,letra,precio,F_Registro,F_Modificacion,estado")] Tb_asiento tb_asiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_asiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_asiento);
        }

        // GET: MantAsiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_asiento tb_asiento = db.Tb_asiento.Find(id);
            if (tb_asiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_asiento);
        }

        // POST: MantAsiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_asiento tb_asiento = db.Tb_asiento.Find(id);
            db.Tb_asiento.Remove(tb_asiento);
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
