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
    public class MantVueloController : Controller
    {
        private Agencia_BDEntities db = new Agencia_BDEntities();

        // GET: MantVuelo
        public ActionResult Index()
        {
            var tb_vuelo = db.Tb_vuelo.Include(t => t.Tb_aeropuerto).Include(t => t.Tb_asiento).Include(t => t.Tb_avion).Include(t => t.Tb_Destino).Include(t => t.Tb_reserva);
            return View(tb_vuelo.ToList());
        }

        // GET: MantVuelo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_vuelo tb_vuelo = db.Tb_vuelo.Find(id);
            if (tb_vuelo == null)
            {
                return HttpNotFound();
            }
            return View(tb_vuelo);
        }

        // GET: MantVuelo/Create
        public ActionResult Create()
        {
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre");
            ViewBag.idAsiento = new SelectList(db.Tb_asiento, "idAsiento", "tipo");
            ViewBag.idAvion = new SelectList(db.Tb_avion, "idAvion", "codigo");
            ViewBag.idDestino = new SelectList(db.Tb_Destino, "idDestino", "idDestino");
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones");
            return View();
        }

        // POST: MantVuelo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idVuelo,F_Registro,F_Modificacion,estado,idAeropuerto,idReserva,idAsiento,idAvion,idDestino")] Tb_vuelo tb_vuelo)
        {
            if (ModelState.IsValid)
            {
                db.Tb_vuelo.Add(tb_vuelo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_vuelo.idAeropuerto);
            ViewBag.idAsiento = new SelectList(db.Tb_asiento, "idAsiento", "tipo", tb_vuelo.idAsiento);
            ViewBag.idAvion = new SelectList(db.Tb_avion, "idAvion", "codigo", tb_vuelo.idAvion);
            ViewBag.idDestino = new SelectList(db.Tb_Destino, "idDestino", "idDestino", tb_vuelo.idDestino);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_vuelo.idReserva);
            return View(tb_vuelo);
        }

        // GET: MantVuelo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_vuelo tb_vuelo = db.Tb_vuelo.Find(id);
            if (tb_vuelo == null)
            {
                return HttpNotFound();
            }
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_vuelo.idAeropuerto);
            ViewBag.idAsiento = new SelectList(db.Tb_asiento, "idAsiento", "tipo", tb_vuelo.idAsiento);
            ViewBag.idAvion = new SelectList(db.Tb_avion, "idAvion", "codigo", tb_vuelo.idAvion);
            ViewBag.idDestino = new SelectList(db.Tb_Destino, "idDestino", "idDestino", tb_vuelo.idDestino);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_vuelo.idReserva);
            return View(tb_vuelo);
        }

        // POST: MantVuelo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idVuelo,F_Registro,F_Modificacion,estado,idAeropuerto,idReserva,idAsiento,idAvion,idDestino")] Tb_vuelo tb_vuelo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_vuelo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idAeropuerto = new SelectList(db.Tb_aeropuerto, "idAeropuerto", "nombre", tb_vuelo.idAeropuerto);
            ViewBag.idAsiento = new SelectList(db.Tb_asiento, "idAsiento", "tipo", tb_vuelo.idAsiento);
            ViewBag.idAvion = new SelectList(db.Tb_avion, "idAvion", "codigo", tb_vuelo.idAvion);
            ViewBag.idDestino = new SelectList(db.Tb_Destino, "idDestino", "idDestino", tb_vuelo.idDestino);
            ViewBag.idReserva = new SelectList(db.Tb_reserva, "idReserva", "observaciones", tb_vuelo.idReserva);
            return View(tb_vuelo);
        }

        // GET: MantVuelo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_vuelo tb_vuelo = db.Tb_vuelo.Find(id);
            if (tb_vuelo == null)
            {
                return HttpNotFound();
            }
            return View(tb_vuelo);
        }

        // POST: MantVuelo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_vuelo tb_vuelo = db.Tb_vuelo.Find(id);
            db.Tb_vuelo.Remove(tb_vuelo);
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
