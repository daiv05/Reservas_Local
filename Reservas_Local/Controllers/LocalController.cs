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
    public class LocalController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: Local
        public ActionResult Index()
        {
            var local = db.Local.Include(l => l.Edificio);
            return View(local.ToList());
        }

        // GET: Local/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Local local = db.Local.Find(id);
            if (local == null)
            {
                return HttpNotFound();
            }
            return View(local);
        }

        // GET: Local/Create
        public ActionResult Create()
        {
            ViewBag.EdificioID = new SelectList(db.Edificio, "EdificioID", "NombreEdif");
            return View();
        }

        // POST: Local/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocalID,NombreLocal,Altitud,Latitud,EdificioID,Planta,Puntuacion")] Local local)
        {
            if (ModelState.IsValid)
            {
                db.Local.Add(local);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EdificioID = new SelectList(db.Edificio, "EdificioID", "NombreEdif", local.EdificioID);
            return View(local);
        }

        // GET: Local/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Local local = db.Local.Find(id);
            if (local == null)
            {
                return HttpNotFound();
            }
            ViewBag.EdificioID = new SelectList(db.Edificio, "EdificioID", "NombreEdif", local.EdificioID);
            return View(local);
        }

        // POST: Local/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalID,NombreLocal,Altitud,Latitud,EdificioID,Planta,Puntuacion")] Local local)
        {
            if (ModelState.IsValid)
            {
                db.Entry(local).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EdificioID = new SelectList(db.Edificio, "EdificioID", "NombreEdif", local.EdificioID);
            return View(local);
        }

        // GET: Local/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Local local = db.Local.Find(id);
            if (local == null)
            {
                return HttpNotFound();
            }
            return View(local);
        }

        // POST: Local/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Local local = db.Local.Find(id);
            db.Local.Remove(local);
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
