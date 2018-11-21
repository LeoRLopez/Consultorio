using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsultorioWeb.Models;

namespace ConsultorioWeb.Controllers
{
    public class TarjetasController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Tarjetas
        public ActionResult Index()
        {
            return View(db.Tarjetas.ToList());
        }

        // GET: Tarjetas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjetas tarjetas = db.Tarjetas.Find(id);
            if (tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(tarjetas);
        }

        // GET: Tarjetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarjetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTarjeta,Nombre,Titular,NumeroTarjeta,FechaVto,IdBanco,BajaLogica")] Tarjetas tarjetas)
        {
            if (ModelState.IsValid)
            {
                db.Tarjetas.Add(tarjetas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarjetas);
        }

        // GET: Tarjetas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjetas tarjetas = db.Tarjetas.Find(id);
            if (tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(tarjetas);
        }

        // POST: Tarjetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTarjeta,Nombre,Titular,NumeroTarjeta,FechaVto,IdBanco,BajaLogica")] Tarjetas tarjetas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarjetas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarjetas);
        }

        // GET: Tarjetas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjetas tarjetas = db.Tarjetas.Find(id);
            if (tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(tarjetas);
        }

        // POST: Tarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarjetas tarjetas = db.Tarjetas.Find(id);
            db.Tarjetas.Remove(tarjetas);
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
