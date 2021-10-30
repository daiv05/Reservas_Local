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
    public class HorarioController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: Horario
        public ActionResult Index()
        {
            var horario = db.Horario.Include(h => h.Dia).Include(h => h.Hora);
            return View(horario.ToList());
        }

        // GET: Horario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario horario = db.Horario.Find(id);
            if (horario == null)
            {
                return HttpNotFound();
            }
            return View(horario);
        }

        // GET: Horario/Create
        public ActionResult Create()
        {
            ViewBag.DiaID = new SelectList(db.Dia, "DiaID", "NombreDia");
            ViewBag.HoraID = new SelectList(db.Hora, "HoraID", "HInicio");
            return View();
        }

        // POST: Horario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HorarioID,HoraID,DiaID")] Horario horario)
        {
            if (ModelState.IsValid)
            {
                db.Horario.Add(horario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DiaID = new SelectList(db.Dia, "DiaID", "NombreDia", horario.DiaID);
            ViewBag.HoraID = new SelectList(db.Hora, "HoraID", "HInicio", horario.HoraID);
            return View(horario);
        }

        // GET: Horario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario horario = db.Horario.Find(id);
            if (horario == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiaID = new SelectList(db.Dia, "DiaID", "NombreDia", horario.DiaID);
            ViewBag.HoraID = new SelectList(db.Hora, "HoraID", "HInicio", horario.HoraID);
            return View(horario);
        }

        // POST: Horario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HorarioID,HoraID,DiaID")] Horario horario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DiaID = new SelectList(db.Dia, "DiaID", "NombreDia", horario.DiaID);
            ViewBag.HoraID = new SelectList(db.Hora, "HoraID", "HInicio", horario.HoraID);
            return View(horario);
        }

        // GET: Horario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario horario = db.Horario.Find(id);
            if (horario == null)
            {
                return HttpNotFound();
            }
            return View(horario);
        }

        // POST: Horario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Horario horario = db.Horario.Find(id);
            db.Horario.Remove(horario);
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
