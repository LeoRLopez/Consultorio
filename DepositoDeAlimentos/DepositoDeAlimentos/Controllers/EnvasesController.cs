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
    public class EnvasesController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: Envases
        public ActionResult Index()
        {
            return View(db.Envase.ToList());
        }

        // GET: Envases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Envase envase = db.Envase.Find(id);
            if (envase == null)
            {
                return HttpNotFound();
            }
            return View(envase);
        }

        // GET: Envases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Envases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEnvase,Peso,Volumen,Descripcion")] Envase envase)
        {
            if (ModelState.IsValid)
            {
                db.Envase.Add(envase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(envase);
        }

        // GET: Envases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Envase envase = db.Envase.Find(id);
            if (envase == null)
            {
                return HttpNotFound();
            }
            return View(envase);
        }

        // POST: Envases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEnvase,Peso,Volumen,Descripcion")] Envase envase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(envase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(envase);
        }

        // GET: Envases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Envase envase = db.Envase.Find(id);
            if (envase == null)
            {
                return HttpNotFound();
            }
            return View(envase);
        }

        // POST: Envases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Envase envase = db.Envase.Find(id);
            db.Envase.Remove(envase);
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
