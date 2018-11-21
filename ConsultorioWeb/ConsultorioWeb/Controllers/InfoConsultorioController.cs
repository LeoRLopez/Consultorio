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
    public class InfoConsultorioController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: InfoConsultorio
        public ActionResult Index()
        {
            return View(db.InfoConsultorio.ToList());
        }

        // GET: InfoConsultorio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoConsultorio infoConsultorio = db.InfoConsultorio.Find(id);
            if (infoConsultorio == null)
            {
                return HttpNotFound();
            }
            return View(infoConsultorio);
        }

        // GET: InfoConsultorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoConsultorio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,NombreConsultorio,Dirección,Telefono,Email,DiasyHorariosAtencion,Web,Mision,Vision,Descripcion")] InfoConsultorio infoConsultorio)
        {
            if (ModelState.IsValid)
            {
                db.InfoConsultorio.Add(infoConsultorio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infoConsultorio);
        }

        // GET: InfoConsultorio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoConsultorio infoConsultorio = db.InfoConsultorio.Find(id);
            if (infoConsultorio == null)
            {
                return HttpNotFound();
            }
            return View(infoConsultorio);
        }

        // POST: InfoConsultorio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,NombreConsultorio,Dirección,Telefono,Email,DiasyHorariosAtencion,Web,Mision,Vision,Descripcion")] InfoConsultorio infoConsultorio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoConsultorio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infoConsultorio);
        }

        // GET: InfoConsultorio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoConsultorio infoConsultorio = db.InfoConsultorio.Find(id);
            if (infoConsultorio == null)
            {
                return HttpNotFound();
            }
            return View(infoConsultorio);
        }

        // POST: InfoConsultorio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InfoConsultorio infoConsultorio = db.InfoConsultorio.Find(id);
            db.InfoConsultorio.Remove(infoConsultorio);
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
