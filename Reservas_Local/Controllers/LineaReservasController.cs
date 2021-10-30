using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Reservas_Local.Models;

namespace Reservas_Local.Controllers
{
    public class LineaReservasController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: LineaReservas
        public ActionResult Index()
        {
            var lineaReserva = db.LineaReserva.Include(l => l.HorarioReserv).Include(l => l.Local).Include(l => l.SemanaCiclo);
            return View(lineaReserva.ToList());
        }

        // GET: LineaReservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaReserva lineaReserva = db.LineaReserva.Find(id);
            if (lineaReserva == null)
            {
                return HttpNotFound();
            }
            return View(lineaReserva);
        }

        // GET: LineaReservas/Create
        public ActionResult Create()
        {
            ViewBag.HorarioID = new SelectList(db.Horario, "HorarioID", "HorarioID");
            ViewBag.LocalID = new SelectList(db.Local, "LocalID", "NombreLocal");
            ViewBag.SemanaID = new SelectList(db.Semana, "SemanaID", "SemanaID");
            return View();
        }

        // POST: LineaReservas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaReservaID,LocalID,HorarioID,SemanaID")] LineaReserva lineaReserva)
        {
            if (ModelState.IsValid)
            {
                db.LineaReserva.Add(lineaReserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HorarioID = new SelectList(db.Horario, "HorarioID", "HorarioID", lineaReserva.HorarioID);
            ViewBag.LocalID = new SelectList(db.Local, "LocalID", "NombreLocal", lineaReserva.LocalID);
            ViewBag.SemanaID = new SelectList(db.Semana, "SemanaID", "SemanaID", lineaReserva.SemanaID);
            return View(lineaReserva);
        }

        // GET: LineaReservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaReserva lineaReserva = db.LineaReserva.Find(id);
            if (lineaReserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.HorarioID = new SelectList(db.Horario, "HorarioID", "HorarioID", lineaReserva.HorarioID);
            ViewBag.LocalID = new SelectList(db.Local, "LocalID", "NombreLocal", lineaReserva.LocalID);
            ViewBag.SemanaID = new SelectList(db.Semana, "SemanaID", "SemanaID", lineaReserva.SemanaID);
            return View(lineaReserva);
        }

        // POST: LineaReservas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaReservaID,LocalID,HorarioID,SemanaID")] LineaReserva lineaReserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineaReserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HorarioID = new SelectList(db.Horario, "HorarioID", "HorarioID", lineaReserva.HorarioID);
            ViewBag.LocalID = new SelectList(db.Local, "LocalID", "NombreLocal", lineaReserva.LocalID);
            ViewBag.SemanaID = new SelectList(db.Semana, "SemanaID", "SemanaID", lineaReserva.SemanaID);
            return View(lineaReserva);
        }

        // GET: LineaReservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaReserva lineaReserva = db.LineaReserva.Find(id);
            if (lineaReserva == null)
            {
                return HttpNotFound();
            }
            return View(lineaReserva);
        }

        // POST: LineaReservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaReserva lineaReserva = db.LineaReserva.Find(id);
            db.LineaReserva.Remove(lineaReserva);
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
