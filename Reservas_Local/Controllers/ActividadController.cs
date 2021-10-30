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
    public class ActividadController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: Actividad
        public ActionResult Index()
        {
            var actividad = db.Actividad.Include(a => a.Anio).Include(a => a.Asignatura).Include(a => a.TipoActividad);
            return View(actividad.ToList());
        }

        // GET: Actividad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actividad actividad = db.Actividad.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            return View(actividad);
        }

        // GET: Actividad/Create
        public ActionResult Create()
        {
            ViewBag.AnioID = new SelectList(db.Anio, "AnioID", "AnioCurso");
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura");
            ViewBag.TipoActividadID = new SelectList(db.TipoActividad, "TipoActividadID", "ActividadTipo");
            return View();
        }

        // POST: Actividad/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActividadID,TipoActividadID,AsignaturaID,Ciclo,AnioID")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                db.Actividad.Add(actividad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AnioID = new SelectList(db.Anio, "AnioID", "AnioCurso", actividad.AnioID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", actividad.AsignaturaID);
            ViewBag.TipoActividadID = new SelectList(db.TipoActividad, "TipoActividadID", "ActividadTipo", actividad.TipoActividadID);
            return View(actividad);
        }

        // GET: Actividad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actividad actividad = db.Actividad.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnioID = new SelectList(db.Anio, "AnioID", "AnioCurso", actividad.AnioID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", actividad.AsignaturaID);
            ViewBag.TipoActividadID = new SelectList(db.TipoActividad, "TipoActividadID", "ActividadTipo", actividad.TipoActividadID);
            return View(actividad);
        }

        // POST: Actividad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActividadID,TipoActividadID,AsignaturaID,Ciclo,AnioID")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actividad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnioID = new SelectList(db.Anio, "AnioID", "AnioCurso", actividad.AnioID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", actividad.AsignaturaID);
            ViewBag.TipoActividadID = new SelectList(db.TipoActividad, "TipoActividadID", "ActividadTipo", actividad.TipoActividadID);
            return View(actividad);
        }

        // GET: Actividad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actividad actividad = db.Actividad.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            return View(actividad);
        }

        // POST: Actividad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actividad actividad = db.Actividad.Find(id);
            db.Actividad.Remove(actividad);
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
