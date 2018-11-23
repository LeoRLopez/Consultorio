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
            return RedirectToAction("Edit");
        }

        // GET: InfoConsultorio/Edit/5
        public ActionResult Edit(int? id = 1)
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
                return RedirectToAction("Index","Home");
            }
            return View(infoConsultorio);
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