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
    public class ClasificaEnController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: ClasificaEn
        public ActionResult Index()
        {
            var clasificaEn = db.ClasificaEn.Include(c => c.Categoria).Include(c => c.Producto);
            return View(clasificaEn.ToList());
        }

        // GET: ClasificaEn/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasificaEn clasificaEn = db.ClasificaEn.Find(id);
            if (clasificaEn == null)
            {
                return HttpNotFound();
            }
            return View(clasificaEn);
        }

        // GET: ClasificaEn/Create
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "NombreCategoria");
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE");
            return View();
        }

        // POST: ClasificaEn/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdClasificaEn,IdProducto,IdCategoria")] ClasificaEn clasificaEn)
        {
            if (ModelState.IsValid)
            {
                db.ClasificaEn.Add(clasificaEn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "NombreCategoria", clasificaEn.IdCategoria);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", clasificaEn.IdProducto);
            return View(clasificaEn);
        }

        // GET: ClasificaEn/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasificaEn clasificaEn = db.ClasificaEn.Find(id);
            if (clasificaEn == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "NombreCategoria", clasificaEn.IdCategoria);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", clasificaEn.IdProducto);
            return View(clasificaEn);
        }

        // POST: ClasificaEn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdClasificaEn,IdProducto,IdCategoria")] ClasificaEn clasificaEn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasificaEn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "NombreCategoria", clasificaEn.IdCategoria);
            ViewBag.IdProducto = new SelectList(db.Producto, "IdProducto", "RNE", clasificaEn.IdProducto);
            return View(clasificaEn);
        }

        // GET: ClasificaEn/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasificaEn clasificaEn = db.ClasificaEn.Find(id);
            if (clasificaEn == null)
            {
                return HttpNotFound();
            }
            return View(clasificaEn);
        }

        // POST: ClasificaEn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClasificaEn clasificaEn = db.ClasificaEn.Find(id);
            db.ClasificaEn.Remove(clasificaEn);
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
