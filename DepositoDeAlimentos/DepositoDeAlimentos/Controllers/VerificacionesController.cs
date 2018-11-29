using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DepositoDeAlimentos.Models;

namespace DepositoDeAlimentos.Controllers
{
    public class VerificacionesController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: Verificaciones
        public ActionResult Index()
        {
            return View(db.Verificacion.ToList());
        }

        // GET: Verificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verificacion verificacion = db.Verificacion.Find(id);
            if (verificacion == null)
            {
                return HttpNotFound();
            }
            return View(verificacion);
        }

        // GET: Verificaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Verificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVerificacion,Descripcion")] Verificacion verificacion)
        {
            if (ModelState.IsValid)
            {
                db.Verificacion.Add(verificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(verificacion);
        }

        // GET: Verificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verificacion verificacion = db.Verificacion.Find(id);
            if (verificacion == null)
            {
                return HttpNotFound();
            }
            return View(verificacion);
        }

        // POST: Verificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVerificacion,Descripcion")] Verificacion verificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(verificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(verificacion);
        }

        // GET: Verificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verificacion verificacion = db.Verificacion.Find(id);
            if (verificacion == null)
            {
                return HttpNotFound();
            }
            return View(verificacion);
        }

        // POST: Verificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Verificacion verificacion = db.Verificacion.Find(id);
            db.Verificacion.Remove(verificacion);
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
