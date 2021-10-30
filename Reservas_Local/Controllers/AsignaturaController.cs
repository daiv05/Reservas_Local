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
    public class AsignaturaController : Controller
    {
        private ReservContext db = new ReservContext();

        // GET: Asignatura
        public ActionResult Index()
        {
            var asignatura = db.Asignatura.Include(a => a.CicloAsignatura).Include(a => a.PensumAsignatura).Include(a => a.Prerrequisito).Include(a => a.TipoAsignatura);
            if (asignatura == null)
            {
                return View();
            } else
            {
                return View(asignatura.ToList());
            }

        }

        // GET: Asignatura/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignatura asignatura = db.Asignatura.Find(id);
            if (asignatura == null)
            {
                return HttpNotFound();
            }
            return View(asignatura);
        }

        // GET: Asignatura/Create
        public ActionResult Create()
        {
            ViewBag.CicloID = new SelectList(db.Ciclo, "CicloID", "TipoCiclo");
            ViewBag.PensumID = new SelectList(db.Pensum, "PensumID", "NombrePensum");
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura");
            ViewBag.TipoAsignaturaID = new SelectList(db.TipoAsignatura, "TipoAsignaturaID", "AsignaturaTipo");
            return View();
        }

        // POST: Asignatura/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AsignaturaID,CodAsignatura,NombreAsignatura,UV,TipoAsignaturaID,CicloID,PensumID")] Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                db.Asignatura.Add(asignatura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CicloID = new SelectList(db.Ciclo, "CicloID", "TipoCiclo", asignatura.CicloID);
            ViewBag.PensumID = new SelectList(db.Pensum, "PensumID", "NombrePensum", asignatura.PensumID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", asignatura.AsignaturaID);
            ViewBag.TipoAsignaturaID = new SelectList(db.TipoAsignatura, "TipoAsignaturaID", "AsignaturaTipo", asignatura.TipoAsignaturaID);
            return View(asignatura);
        }

        // GET: Asignatura/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignatura asignatura = db.Asignatura.Find(id);
            if (asignatura == null)
            {
                return HttpNotFound();
            }
            ViewBag.CicloID = new SelectList(db.Ciclo, "CicloID", "TipoCiclo", asignatura.CicloID);
            ViewBag.PensumID = new SelectList(db.Pensum, "PensumID", "NombrePensum", asignatura.PensumID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", asignatura.AsignaturaID);
            ViewBag.TipoAsignaturaID = new SelectList(db.TipoAsignatura, "TipoAsignaturaID", "AsignaturaTipo", asignatura.TipoAsignaturaID);
            return View(asignatura);
        }

        // POST: Asignatura/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsignaturaID,CodAsignatura,NombreAsignatura,UV,TipoAsignaturaID,CicloID,PensumID")] Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignatura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CicloID = new SelectList(db.Ciclo, "CicloID", "TipoCiclo", asignatura.CicloID);
            ViewBag.PensumID = new SelectList(db.Pensum, "PensumID", "NombrePensum", asignatura.PensumID);
            ViewBag.AsignaturaID = new SelectList(db.Asignatura, "AsignaturaID", "CodAsignatura", asignatura.AsignaturaID);
            ViewBag.TipoAsignaturaID = new SelectList(db.TipoAsignatura, "TipoAsignaturaID", "AsignaturaTipo", asignatura.TipoAsignaturaID);
            return View(asignatura);
        }

        // GET: Asignatura/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asignatura asignatura = db.Asignatura.Find(id);
            if (asignatura == null)
            {
                return HttpNotFound();
            }
            return View(asignatura);
        }

        // POST: Asignatura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asignatura asignatura = db.Asignatura.Find(id);
            db.Asignatura.Remove(asignatura);
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
