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
    public class BancosController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Bancos
        public ActionResult Index()
        {
            return View(db.Bancos.ToList());
        }

        // GET: Bancos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancos bancos = db.Bancos.Find(id);
            if (bancos == null)
            {
                return HttpNotFound();
            }
            return View(bancos);
        }

        // GET: Bancos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bancos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdBanco,Nombre,BajaLogica,CodigoBCRA")] Bancos bancos)
        {
            if (ModelState.IsValid)
            {
                db.Bancos.Add(bancos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bancos);
        }

        // GET: Bancos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancos bancos = db.Bancos.Find(id);
            if (bancos == null)
            {
                return HttpNotFound();
            }
            return View(bancos);
        }

        // POST: Bancos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdBanco,Nombre,BajaLogica,CodigoBCRA")] Bancos bancos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bancos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bancos);
        }

        // GET: Bancos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancos bancos = db.Bancos.Find(id);
            if (bancos == null)
            {
                return HttpNotFound();
            }
            return View(bancos);
        }

        // POST: Bancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bancos bancos = db.Bancos.Find(id);
            db.Bancos.Remove(bancos);
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
