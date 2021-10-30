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
    public class HoraController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: Hora
        public ActionResult Index()
        {
            return View(db.Hora.ToList());
        }

        // GET: Hora/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hora hora = db.Hora.Find(id);
            if (hora == null)
            {
                return HttpNotFound();
            }
            return View(hora);
        }

        // GET: Hora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hora/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoraID,HInicio,HFin")] Hora hora)
        {
            if (ModelState.IsValid)
            {
                db.Hora.Add(hora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hora);
        }

        // GET: Hora/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hora hora = db.Hora.Find(id);
            if (hora == null)
            {
                return HttpNotFound();
            }
            return View(hora);
        }

        // POST: Hora/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoraID,HInicio,HFin")] Hora hora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hora);
        }

        // GET: Hora/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hora hora = db.Hora.Find(id);
            if (hora == null)
            {
                return HttpNotFound();
            }
            return View(hora);
        }

        // POST: Hora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hora hora = db.Hora.Find(id);
            db.Hora.Remove(hora);
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
