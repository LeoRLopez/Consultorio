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
    public class ListaVerificacionesController : Controller
    {
        private DepositoEntities db = new DepositoEntities();

        // GET: ListaVerificaciones
        public ActionResult Index()
        {
            var listaVerificacion = db.ListaVerificacion.Include(l => l.FichaInventario).Include(l => l.Verificacion);
            return View(listaVerificacion.ToList());
        }

        // GET: ListaVerificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaVerificacion listaVerificacion = db.ListaVerificacion.Find(id);
            if (listaVerificacion == null)
            {
                return HttpNotFound();
            }
            return View(listaVerificacion);
        }

        // GET: ListaVerificaciones/Create
        public ActionResult Create()
        {
            ViewBag.IdFichaInventario = new SelectList(db.FichaInventario, "IdFichaInventario", "CodigoEstadoLote");
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion");
            return View();
        }

        // POST: ListaVerificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdListaVerificacion,IdVerificacion,IdFichaInventario,Fecha,Hora,Resultado")] ListaVerificacion listaVerificacion)
        {
            if (ModelState.IsValid)
            {
                db.ListaVerificacion.Add(listaVerificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFichaInventario = new SelectList(db.FichaInventario, "IdFichaInventario", "CodigoEstadoLote", listaVerificacion.IdFichaInventario);
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", listaVerificacion.IdVerificacion);
            return View(listaVerificacion);
        }

        // GET: ListaVerificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaVerificacion listaVerificacion = db.ListaVerificacion.Find(id);
            if (listaVerificacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFichaInventario = new SelectList(db.FichaInventario, "IdFichaInventario", "CodigoEstadoLote", listaVerificacion.IdFichaInventario);
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", listaVerificacion.IdVerificacion);
            return View(listaVerificacion);
        }

        // POST: ListaVerificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdListaVerificacion,IdVerificacion,IdFichaInventario,Fecha,Hora,Resultado")] ListaVerificacion listaVerificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listaVerificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFichaInventario = new SelectList(db.FichaInventario, "IdFichaInventario", "CodigoEstadoLote", listaVerificacion.IdFichaInventario);
            ViewBag.IdVerificacion = new SelectList(db.Verificacion, "IdVerificacion", "Descripcion", listaVerificacion.IdVerificacion);
            return View(listaVerificacion);
        }

        // GET: ListaVerificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaVerificacion listaVerificacion = db.ListaVerificacion.Find(id);
            if (listaVerificacion == null)
            {
                return HttpNotFound();
            }
            return View(listaVerificacion);
        }

        // POST: ListaVerificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListaVerificacion listaVerificacion = db.ListaVerificacion.Find(id);
            db.ListaVerificacion.Remove(listaVerificacion);
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
