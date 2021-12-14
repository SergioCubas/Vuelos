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
    public class MantPagoController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantPago
        public ActionResult Index()
        {
            var tb_pago = db.Tb_pago.Include(t => t.Tb_pasajero).Include(t => t.Tb_reserva);
            return View(tb_pago.ToList());
        }

        // GET: MantPago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pago tb_pago = db.Tb_pago.Find(id);
            if (tb_pago == null)
            {
                return HttpNotFound();
            }
            return View(tb_pago);
        }

        // GET: MantPago/Create
        public ActionResult Create()
        {
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre");
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones");
            return View();
        }

        // POST: MantPago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPago,fecha,tipo_comprobante,num_comprobante,medio_pago,F_Registro,F_Modificacion,estado,idPasajero,idReserva")] Tb_pago tb_pago)
        {
            if (ModelState.IsValid)
            {
                db.Tb_pago.Add(tb_pago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_pago.idPasajero);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_pago.idReserva);
            return View(tb_pago);
        }

        // GET: MantPago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pago tb_pago = db.Tb_pago.Find(id);
            if (tb_pago == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_pago.idPasajero);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_pago.idReserva);
            return View(tb_pago);
        }

        // POST: MantPago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPago,fecha,tipo_comprobante,num_comprobante,medio_pago,F_Registro,F_Modificacion,estado,idPasajero,idReserva")] Tb_pago tb_pago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_pago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPasajero = new SelectList(db.Tb_pasajero, "idPasajero", "nombre", tb_pago.idPasajero);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_pago.idReserva);
            return View(tb_pago);
        }

        // GET: MantPago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_pago tb_pago = db.Tb_pago.Find(id);
            if (tb_pago == null)
            {
                return HttpNotFound();
            }
            return View(tb_pago);
        }

        // POST: MantPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_pago tb_pago = db.Tb_pago.Find(id);
            db.Tb_pago.Remove(tb_pago);
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
