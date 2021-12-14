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
    public class MantDepartamentoController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantDepartamento
        public ActionResult Index()
        {
            return View(db.Tb_departamento.ToList());
        }

        // GET: MantDepartamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_departamento tb_departamento = db.Tb_departamento.Find(id);
            if (tb_departamento == null)
            {
                return HttpNotFound();
            }
            return View(tb_departamento);
        }

        // GET: MantDepartamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantDepartamento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_departamento,nombre,F_Registro,F_Modificacion,estado")] Tb_departamento tb_departamento)
        {
            if (ModelState.IsValid)
            {
                db.Tb_departamento.Add(tb_departamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_departamento);
        }

        // GET: MantDepartamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_departamento tb_departamento = db.Tb_departamento.Find(id);
            if (tb_departamento == null)
            {
                return HttpNotFound();
            }
            return View(tb_departamento);
        }

        // POST: MantDepartamento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_departamento,nombre,F_Registro,F_Modificacion,estado")] Tb_departamento tb_departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_departamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_departamento);
        }

        // GET: MantDepartamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_departamento tb_departamento = db.Tb_departamento.Find(id);
            if (tb_departamento == null)
            {
                return HttpNotFound();
            }
            return View(tb_departamento);
        }

        // POST: MantDepartamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_departamento tb_departamento = db.Tb_departamento.Find(id);
            db.Tb_departamento.Remove(tb_departamento);
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
