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
    public class FichaInventarioController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: FichaInventario
        public ActionResult Index()
        {
            var fichaInventario = db.FichaInventario.Include(f => f.EstadoLote).Include(f => f.Lote).Include(f => f.TecnicoBromatologico);
            return View(fichaInventario.ToList());
        }

        // GET: FichaInventario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaInventario fichaInventario = db.FichaInventario.Find(id);
            if (fichaInventario == null)
            {
                return HttpNotFound();
            }
            return View(fichaInventario);
        }

        // GET: FichaInventario/Create
        public ActionResult Create()
        {
            ViewBag.CodigoEstadoLote = new SelectList(db.EstadoLote, "Codigo", "Descripcion");
            ViewBag.IdLote = new SelectList(db.Lote, "IdLote", "IdLote");
            ViewBag.IdTecnicoBromatologico = new SelectList(db.TecnicoBromatologico, "TecnicoId", "NombreCompleto");
            return View();
        }

        // POST: FichaInventario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFichaInventario,IdLote,CodigoEstadoLote,Año,Semana,OberservacionesGenerales,IdTecnicoBromatologico")] FichaInventario fichaInventario)
        {
            if (ModelState.IsValid)
            {
                db.FichaInventario.Add(fichaInventario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoEstadoLote = new SelectList(db.EstadoLote, "Codigo", "Descripcion", fichaInventario.CodigoEstadoLote);
            ViewBag.IdLote = new SelectList(db.Lote, "IdLote", "IdLote", fichaInventario.IdLote);
            ViewBag.IdTecnicoBromatologico = new SelectList(db.TecnicoBromatologico, "TecnicoId", "NombreCompleto", fichaInventario.IdTecnicoBromatologico);
            return View(fichaInventario);
        }

        // GET: FichaInventario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaInventario fichaInventario = db.FichaInventario.Find(id);
            if (fichaInventario == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoEstadoLote = new SelectList(db.EstadoLote, "Codigo", "Descripcion", fichaInventario.CodigoEstadoLote);
            ViewBag.IdLote = new SelectList(db.Lote, "IdLote", "IdLote", fichaInventario.IdLote);
            ViewBag.IdTecnicoBromatologico = new SelectList(db.TecnicoBromatologico, "TecnicoId", "NombreCompleto", fichaInventario.IdTecnicoBromatologico);
            return View(fichaInventario);
        }

        // POST: FichaInventario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFichaInventario,IdLote,CodigoEstadoLote,Año,Semana,OberservacionesGenerales,IdTecnicoBromatologico")] FichaInventario fichaInventario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fichaInventario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoEstadoLote = new SelectList(db.EstadoLote, "Codigo", "Descripcion", fichaInventario.CodigoEstadoLote);
            ViewBag.IdLote = new SelectList(db.Lote, "IdLote", "IdLote", fichaInventario.IdLote);
            ViewBag.IdTecnicoBromatologico = new SelectList(db.TecnicoBromatologico, "TecnicoId", "NombreCompleto", fichaInventario.IdTecnicoBromatologico);
            return View(fichaInventario);
        }

        // GET: FichaInventario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaInventario fichaInventario = db.FichaInventario.Find(id);
            if (fichaInventario == null)
            {
                return HttpNotFound();
            }
            return View(fichaInventario);
        }

        // POST: FichaInventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FichaInventario fichaInventario = db.FichaInventario.Find(id);
            db.FichaInventario.Remove(fichaInventario);
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
