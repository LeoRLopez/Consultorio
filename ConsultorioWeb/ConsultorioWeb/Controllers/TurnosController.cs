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
    [Authorize(Roles = "Admin,Medico,Paciente,Usuario")]
    public class TurnosController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Turnos
        public ActionResult Index()
        {
            List<Turno> turnos = new List<Turno>();
            var userEmail = User.Identity.Name;
            string userRole = "";
            var currentUserRoles = System.Web.HttpContext.Current.Session["CurrentUserRoles"];
            if (currentUserRoles != null)
                userRole = System.Web.HttpContext.Current.Session["CurrentUserRoles"].ToString();

            if (userRole == "Admin" || userRole == "Usuario")
            {
                turnos = db.Turno.Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            else if (userRole == "Medico")
            {
                var idMedico = db.PersonalInterno.FirstOrDefault(x => x.Email == userEmail).IdMedico;
                turnos = db.Turno.Where(x=>x.IdMedico == idMedico)
                    .Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            else if (userRole == "Paciente")
            {
                var idPaciente = db.Paciente.FirstOrDefault(x => x.Email == userEmail).IdPaciente;
                turnos = db.Turno.Where(x => x.IdPaciente == idPaciente)
                    .Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            return View(turnos);
        }

        // GET: Turnos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turno turno = db.Turno.Find(id);
            if (turno == null)
            {
                return HttpNotFound();
            }
            return View(turno);
        }

        // GET: Turnos/Create
        public ActionResult Create()
        {
            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad, "EspecialidadId", "Nombre");
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre");
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico");
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres");
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre");
            return View();
        }

        // POST: Turnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTurno,IdMedico,IdPaciente,IdFormaDePago,FechaYHora,IdSeguroMedico,Diagnostico,Descripcion,Asistio,Atendido,PrecioTurno,IdEspecialidadMedico")] Turno turno)
        {
            if (ModelState.IsValid)
            {
                db.Turno.Add(turno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad, "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            return View(turno);
        }

        // GET: Turnos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turno turno = db.Turno.Find(id);
            if (turno == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad, "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            return View(turno);
        }

        // POST: Turnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTurno,IdMedico,IdPaciente,IdFormaDePago,FechaYHora,IdSeguroMedico,Diagnostico,Descripcion,Asistio,Atendido,PrecioTurno,IdEspecialidadMedico")] Turno turno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad, "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            return View(turno);
        }

        // GET: Turnos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turno turno = db.Turno.Find(id);
            if (turno == null)
            {
                return HttpNotFound();
            }
            return View(turno);
        }

        // POST: Turnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = db.Turno.Find(id);
            db.Turno.Remove(turno);
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
