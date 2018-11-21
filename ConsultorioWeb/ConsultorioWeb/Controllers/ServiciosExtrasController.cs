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
    public class ServiciosExtrasController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: ServiciosExtras
        public ActionResult Index()
        {
            return View(db.ServicioExtra.ToList());
        }

        // GET: ServiciosExtras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioExtra servicioExtra = db.ServicioExtra.Find(id);
            if (servicioExtra == null)
            {
                return HttpNotFound();
            }
            return View(servicioExtra);
        }

        // GET: ServiciosExtras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiciosExtras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioExtraId,Nombre,Precio")] ServicioExtra servicioExtra)
        {
            if (ModelState.IsValid)
            {
                db.ServicioExtra.Add(servicioExtra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicioExtra);
        }

        // GET: ServiciosExtras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioExtra servicioExtra = db.ServicioExtra.Find(id);
            if (servicioExtra == null)
            {
                return HttpNotFound();
            }
            return View(servicioExtra);
        }

        // POST: ServiciosExtras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioExtraId,Nombre,Precio")] ServicioExtra servicioExtra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicioExtra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicioExtra);
        }

        // GET: ServiciosExtras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioExtra servicioExtra = db.ServicioExtra.Find(id);
            if (servicioExtra == null)
            {
                return HttpNotFound();
            }
            return View(servicioExtra);
        }

        // POST: ServiciosExtras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicioExtra servicioExtra = db.ServicioExtra.Find(id);
            db.ServicioExtra.Remove(servicioExtra);
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
