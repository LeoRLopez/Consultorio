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
    public class ReguladoPorController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: ReguladoPor
        public ActionResult Index()
        {
            var reguladoPor = db.ReguladoPor.Include(r => r.MarcoRegulatorio).Include(r => r.Presentado);
            return View(reguladoPor.ToList());
        }

        // GET: ReguladoPor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReguladoPor reguladoPor = db.ReguladoPor.Find(id);
            if (reguladoPor == null)
            {
                return HttpNotFound();
            }
            return View(reguladoPor);
        }

        // GET: ReguladoPor/Create
        public ActionResult Create()
        {
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion");
            ViewBag.IdPresentado = new SelectList(db.Presentado, "IdPresentado", "IdPresentado");
            return View();
        }

        // POST: ReguladoPor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdReguladoPor,IdPresentado,NroMarcoRegulatorio")] ReguladoPor reguladoPor)
        {
            if (ModelState.IsValid)
            {
                db.ReguladoPor.Add(reguladoPor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", reguladoPor.NroMarcoRegulatorio);
            ViewBag.IdPresentado = new SelectList(db.Presentado, "IdPresentado", "IdPresentado", reguladoPor.IdPresentado);
            return View(reguladoPor);
        }

        // GET: ReguladoPor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReguladoPor reguladoPor = db.ReguladoPor.Find(id);
            if (reguladoPor == null)
            {
                return HttpNotFound();
            }
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", reguladoPor.NroMarcoRegulatorio);
            ViewBag.IdPresentado = new SelectList(db.Presentado, "IdPresentado", "IdPresentado", reguladoPor.IdPresentado);
            return View(reguladoPor);
        }

        // POST: ReguladoPor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdReguladoPor,IdPresentado,NroMarcoRegulatorio")] ReguladoPor reguladoPor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reguladoPor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", reguladoPor.NroMarcoRegulatorio);
            ViewBag.IdPresentado = new SelectList(db.Presentado, "IdPresentado", "IdPresentado", reguladoPor.IdPresentado);
            return View(reguladoPor);
        }

        // GET: ReguladoPor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReguladoPor reguladoPor = db.ReguladoPor.Find(id);
            if (reguladoPor == null)
            {
                return HttpNotFound();
            }
            return View(reguladoPor);
        }

        // POST: ReguladoPor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReguladoPor reguladoPor = db.ReguladoPor.Find(id);
            db.ReguladoPor.Remove(reguladoPor);
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
