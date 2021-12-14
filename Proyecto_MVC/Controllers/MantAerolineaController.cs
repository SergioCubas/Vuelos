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
    public class MantAerolineaController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantAerolinea
        public ActionResult Index()
        {
            return View(db.Tb_aerolinea.ToList());
        }

        // GET: MantAerolinea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aerolinea tb_aerolinea = db.Tb_aerolinea.Find(id);
            if (tb_aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(tb_aerolinea);
        }

        // GET: MantAerolinea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantAerolinea/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAerolinea,ruc,nombre,F_Registro,F_Modificacion,estado")] Tb_aerolinea tb_aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.Tb_aerolinea.Add(tb_aerolinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_aerolinea);
        }

        // GET: MantAerolinea/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aerolinea tb_aerolinea = db.Tb_aerolinea.Find(id);
            if (tb_aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(tb_aerolinea);
        }

        // POST: MantAerolinea/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAerolinea,ruc,nombre,F_Registro,F_Modificacion,estado")] Tb_aerolinea tb_aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_aerolinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_aerolinea);
        }

        // GET: MantAerolinea/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_aerolinea tb_aerolinea = db.Tb_aerolinea.Find(id);
            if (tb_aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(tb_aerolinea);
        }

        // POST: MantAerolinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_aerolinea tb_aerolinea = db.Tb_aerolinea.Find(id);
            db.Tb_aerolinea.Remove(tb_aerolinea);
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
