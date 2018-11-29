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
    public class IncluyeController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: Incluye
        public ActionResult Index()
        {
            var incluye = db.Incluye.Include(i => i.Verificacion).Include(i => i.MarcoRegulatorio);
            return View(incluye.ToList());
        }

        // GET: Incluye/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incluye incluye = db.Incluye.Find(id);
            if (incluye == null)
            {
                return HttpNotFound();
            }
            return View(incluye);
        }

        // GET: Incluye/Create
        public ActionResult Create()
        {
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion");
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion");
            return View();
        }

        // POST: Incluye/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdIncluye,NroMarcoRegulatorio,IdVerificacion,NombreTecnico")] Incluye incluye)
        {
            if (ModelState.IsValid)
            {
                db.Incluye.Add(incluye);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", incluye.IdVerificacion);
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", incluye.NroMarcoRegulatorio);
            return View(incluye);
        }

        // GET: Incluye/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incluye incluye = db.Incluye.Find(id);
            if (incluye == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", incluye.IdVerificacion);
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", incluye.NroMarcoRegulatorio);
            return View(incluye);
        }

        // POST: Incluye/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdIncluye,NroMarcoRegulatorio,IdVerificacion,NombreTecnico")] Incluye incluye)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incluye).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", incluye.IdVerificacion);
            ViewBag.NroMarcoRegulatorio = new SelectList(db.MarcoRegulatorio, "Nro", "Duracion", incluye.NroMarcoRegulatorio);
            return View(incluye);
        }

        // GET: Incluye/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incluye incluye = db.Incluye.Find(id);
            if (incluye == null)
            {
                return HttpNotFound();
            }
            return View(incluye);
        }

        // POST: Incluye/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Incluye incluye = db.Incluye.Find(id);
            db.Incluye.Remove(incluye);
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
