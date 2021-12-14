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
    public class MantReservaController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantReserva
        public ActionResult Index()
        {
            var tb_reserva = db.Tb_reserva.Include(t => t.Tb_pasajero);
            return View(tb_reserva.ToList());
        }

        // GET: MantReserva/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_reserva tb_reserva = db.Tb_reserva.Find(id);
            if (tb_reserva == null)
            {
                return HttpNotFound();
            }
            return View(tb_reserva);
        }

        // GET: MantReserva/Create
        public ActionResult Create()
        {
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre");
            return View();
        }

        // POST: MantReserva/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idReserva,F_Reserva,F_Salida,F_Llegada,observaciones,F_Registro,F_Modificacion,estado,idPasajero")] Tb_reserva tb_reserva)
        {
            if (ModelState.IsValid)
            {
                db.Tb_reserva.Add(tb_reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_reserva.idPasajero);
            return View(tb_reserva);
        }

        // GET: MantReserva/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_reserva tb_reserva = db.Tb_reserva.Find(id);
            if (tb_reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_reserva.idPasajero);
            return View(tb_reserva);
        }

        // POST: MantReserva/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idReserva,F_Reserva,F_Salida,F_Llegada,observaciones,F_Registro,F_Modificacion,estado,idPasajero")] Tb_reserva tb_reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_reserva.idPasajero);
            return View(tb_reserva);
        }

        // GET: MantReserva/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_reserva tb_reserva = db.Tb_reserva.Find(id);
            if (tb_reserva == null)
            {
                return HttpNotFound();
            }
            return View(tb_reserva);
        }

        // POST: MantReserva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_reserva tb_reserva = db.Tb_reserva.Find(id);
            db.Tb_reserva.Remove(tb_reserva);
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
