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
    public class MantPaisController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantPais
        public ActionResult Index()
        {
            var tb_pais = db.Tb_pais.Include(t => t.Tb_departamento);
            return View(tb_pais.ToList());
        }

        // GET: MantPais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pais tb_pais = db.Tb_pais.Find(id);
            if (tb_pais == null)
            {
                return HttpNotFound();
            }
            return View(tb_pais);
        }

        // GET: MantPais/Create
        public ActionResult Create()
        {
            ViewBag.id_departamento = new SelectList(db.Tb_departamento, "id_departamento", "nombre");
            return View();
        }

        // POST: MantPais/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPais,nombre,F_Registro,F_Modificacion,estado,id_departamento")] Tb_pais tb_pais)
        {
            if (ModelState.IsValid)
            {
                db.Tb_pais.Add(tb_pais);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_departamento = new SelectList(db.Tb_departamento, "id_departamento", "nombre", tb_pais.id_departamento);
            return View(tb_pais);
        }

        // GET: MantPais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pais tb_pais = db.Tb_pais.Find(id);
            if (tb_pais == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_departamento = new SelectList(db.Tb_departamento, "id_departamento", "nombre", tb_pais.id_departamento);
            return View(tb_pais);
        }

        // POST: MantPais/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPais,nombre,F_Registro,F_Modificacion,estado,id_departamento")] Tb_pais tb_pais)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_pais).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_departamento = new SelectList(db.Tb_departamento, "id_departamento", "nombre", tb_pais.id_departamento);
            return View(tb_pais);
        }

        // GET: MantPais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pais tb_pais = db.Tb_pais.Find(id);
            if (tb_pais == null)
            {
                return HttpNotFound();
            }
            return View(tb_pais);
        }

        // POST: MantPais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_pais tb_pais = db.Tb_pais.Find(id);
            db.Tb_pais.Remove(tb_pais);
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
