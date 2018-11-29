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
    public class MarcoRegulatorioController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: MarcoRegulatorio
        public ActionResult Index()
        {
            return View(db.MarcoRegulatorio.ToList());
        }

        // GET: MarcoRegulatorio/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcoRegulatorio marcoRegulatorio = db.MarcoRegulatorio.Find(id);
            if (marcoRegulatorio == null)
            {
                return HttpNotFound();
            }
            return View(marcoRegulatorio);
        }

        // GET: MarcoRegulatorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarcoRegulatorio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nro,Duracion,TemperaturaMinima,TemperaturaMaxima")] MarcoRegulatorio marcoRegulatorio)
        {
            if (ModelState.IsValid)
            {
                db.MarcoRegulatorio.Add(marcoRegulatorio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marcoRegulatorio);
        }

        // GET: MarcoRegulatorio/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcoRegulatorio marcoRegulatorio = db.MarcoRegulatorio.Find(id);
            if (marcoRegulatorio == null)
            {
                return HttpNotFound();
            }
            return View(marcoRegulatorio);
        }

        // POST: MarcoRegulatorio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nro,Duracion,TemperaturaMinima,TemperaturaMaxima")] MarcoRegulatorio marcoRegulatorio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marcoRegulatorio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marcoRegulatorio);
        }

        // GET: MarcoRegulatorio/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcoRegulatorio marcoRegulatorio = db.MarcoRegulatorio.Find(id);
            if (marcoRegulatorio == null)
            {
                return HttpNotFound();
            }
            return View(marcoRegulatorio);
        }

        // POST: MarcoRegulatorio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MarcoRegulatorio marcoRegulatorio = db.MarcoRegulatorio.Find(id);
            db.MarcoRegulatorio.Remove(marcoRegulatorio);
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
