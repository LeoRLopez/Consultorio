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
    public class EstadoLotesController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: EstadoLotes
        public ActionResult Index()
        {
            return View(db.EstadoLote.ToList());
        }

        // GET: EstadoLotes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoLote estadoLote = db.EstadoLote.Find(id);
            if (estadoLote == null)
            {
                return HttpNotFound();
            }
            return View(estadoLote);
        }

        // GET: EstadoLotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoLotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Descripcion")] EstadoLote estadoLote)
        {
            if (ModelState.IsValid)
            {
                db.EstadoLote.Add(estadoLote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoLote);
        }

        // GET: EstadoLotes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoLote estadoLote = db.EstadoLote.Find(id);
            if (estadoLote == null)
            {
                return HttpNotFound();
            }
            return View(estadoLote);
        }

        // POST: EstadoLotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Descripcion")] EstadoLote estadoLote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoLote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoLote);
        }

        // GET: EstadoLotes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoLote estadoLote = db.EstadoLote.Find(id);
            if (estadoLote == null)
            {
                return HttpNotFound();
            }
            return View(estadoLote);
        }

        // POST: EstadoLotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EstadoLote estadoLote = db.EstadoLote.Find(id);
            db.EstadoLote.Remove(estadoLote);
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
