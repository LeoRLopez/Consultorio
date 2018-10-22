using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
        private List<string> __horariosTurno = new List<string> { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15" };

        // GET: Turnos
        public ActionResult Index()
        {
            List<Turno> turnos = new List<Turno>();
            var userEmail = User.Identity.Name;

            string userRole = "";
            string currentUserRoles = System.Web.HttpContext.Current.Session["CurrentUserRoles"].ToString();
            if (currentUserRoles != null)
                userRole = System.Web.HttpContext.Current.Session["CurrentUserRoles"].ToString();

            if (userRole == "Admin" || userRole == "Usuario")
            {
                turnos = db.Turno.Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            else if (userRole == "Medico")
            {
                var idMedico = db.PersonalInterno.FirstOrDefault(x => x.Email == userEmail).IdMedico;
                turnos = db.Turno.Where(x => x.IdMedico == idMedico)
                    .Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            else if (userRole == "Paciente")
            {
                var idPaciente = db.Paciente.FirstOrDefault(x => x.Email == userEmail).IdPaciente;
                turnos = db.Turno.Where(x => x.IdPaciente == idPaciente)
                    .Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(t => t.Paciente).Include(t => t.SegurosMedico).ToList();
            }
            return View(turnos.OrderByDescending(x => x.FechaYHora).ToList());
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
            var turno = new Turno { FechaYHora = DateTime.Today };
            string userRole = "";
            string currentUserRoles = System.Web.HttpContext.Current.Session["CurrentUserRoles"].ToString();
            if (currentUserRoles != null)
                userRole = System.Web.HttpContext.Current.Session["CurrentUserRoles"].ToString();

            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad.ToList().Select(x => new { x.EspecialidadId, Nombre = x.Nombre + "($" + x.PrecioPorDefecto + ")" }).ToList(), "EspecialidadId", "Nombre");
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre");
            ViewBag.IdMedico = new SelectList(db.Medico.ToList().Select(x => new { x.IdMedico, ApellidoNombre = x.PersonalInterno.FirstOrDefault().Apellido + ", " + x.PersonalInterno.FirstOrDefault().Nombre }), "IdMedico", "ApellidoNombre");
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre");
            ViewBag.HorarioTurno = new SelectList(this.__horariosTurno);

            if (userRole != "Paciente")
            {
                ViewBag.IdPaciente = new SelectList(db.Paciente.ToList().Select(x => new { x.IdPaciente, ApellidoNombre = x.Apellidos + ", " + x.Nombres }), "IdPaciente", "ApellidoNombre");
            }
            else
            {
                var userEmail = User.Identity.Name;
                turno.IdPaciente = db.Paciente.FirstOrDefault(x => x.Email == userEmail).IdPaciente;
            }

            return View(turno);
        }

        // POST: Turnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTurno,IdMedico,IdPaciente,IdFormaDePago,FechaYHora,IdSeguroMedico,Diagnostico,Descripcion,Asistio,Atendido,PrecioTurno,IdEspecialidadMedico")] Turno turno, FormCollection formCollection)
        {
            DateTime fechaSeleccionada = turno.FechaYHora.Date;
            string horarioTurno = formCollection["HorarioTurno"];

            if (int.TryParse(horarioTurno.Split(':')[0], out int horaTurnoActual) && int.TryParse(horarioTurno.Split(':')[1], out int minutosTurnoActual))
            {
                var fechaHoraTurnoActual = new DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, horaTurnoActual, minutosTurnoActual, 0);
                if (db.Turno.Any(x => x.IdMedico == turno.IdMedico && x.FechaYHora == fechaHoraTurnoActual))
                {
                    var horariosOcupados = string.Join(", ", db.Turno.Where(x => x.IdMedico == turno.IdMedico && EntityFunctions.TruncateTime(x.FechaYHora) == fechaSeleccionada.Date).ToList().Select(x => x.FechaYHora.ToString("HH:mm")));
                    ModelState.AddModelError("HorarioTurno", "El horario seleccionado no está disponible. Otros horarios NO DISPONIBLES para el " + fechaSeleccionada.ToString("dd/MM/yyyy") + " son: " + horariosOcupados);
                }
                else
                {
                    turno.FechaYHora = fechaHoraTurnoActual;
                }
            }
            else
            {
                ModelState.AddModelError("HorarioTurno", "Horario inválido");
            }

            if (ModelState.IsValid)
            {
                turno.PrecioTurno = db.Especialidad.First(x => x.EspecialidadId == turno.IdEspecialidadMedico).PrecioPorDefecto;
                db.Turno.Add(turno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad.ToList().Select(x => new { x.EspecialidadId, Nombre = x.Nombre + "($" + x.PrecioPorDefecto + ")" }).ToList(), "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico.ToList().Select(x => new { x.IdMedico, ApellidoNombre = x.PersonalInterno.FirstOrDefault().Apellido + ", " + x.PersonalInterno.FirstOrDefault().Nombre }), "IdMedico", "ApellidoNombre", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente.ToList().Select(x => new { x.IdPaciente, ApellidoNombre = x.Apellidos + ", " + x.Nombres }), "IdPaciente", "ApellidoNombre", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            ViewBag.HorarioTurno = new SelectList(this.__horariosTurno, horarioTurno);

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
            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad.ToList().Select(x => new { x.EspecialidadId, Nombre = x.Nombre + "($" + x.PrecioPorDefecto + ")" }).ToList(), "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico.ToList().Select(x => new { x.IdMedico, ApellidoNombre = x.PersonalInterno.FirstOrDefault().Apellido + ", " + x.PersonalInterno.FirstOrDefault().Nombre }), "IdMedico", "ApellidoNombre", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente.ToList().Select(x => new { x.IdPaciente, ApellidoNombre = x.Apellidos + ", " + x.Nombres }), "IdPaciente", "ApellidoNombre", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            ViewBag.HorarioTurno = new SelectList(this.__horariosTurno, turno.FechaYHora.ToString("HH:mm"));

            return View(turno);
        }

        // POST: Turnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTurno,IdMedico,IdPaciente,IdFormaDePago,FechaYHora,IdSeguroMedico,Diagnostico,Descripcion,Asistio,Atendido,PrecioTurno,IdEspecialidadMedico")] Turno turno, FormCollection formCollection)
        {
            DateTime fechaSeleccionada = turno.FechaYHora.Date;
            string horarioTurno = formCollection["HorarioTurno"];

            if (int.TryParse(horarioTurno.Split(':')[0], out int horaTurnoActual) && int.TryParse(horarioTurno.Split(':')[1], out int minutosTurnoActual))
            {
                var fechaHoraTurnoActual = new DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, horaTurnoActual, minutosTurnoActual, 0);
                if (db.Turno.Any(x => x.IdMedico == turno.IdMedico && x.FechaYHora == fechaHoraTurnoActual))
                {
                    var horariosOcupados = string.Join(", ", db.Turno.Where(x => x.IdMedico == turno.IdMedico && EntityFunctions.TruncateTime(x.FechaYHora) == fechaSeleccionada.Date).ToList().Select(x => x.FechaYHora.ToString("HH:mm")));
                    ModelState.AddModelError("HorarioTurno", "El horario seleccionado no está disponible. Otros horarios NO DISPONIBLES para el " + fechaSeleccionada.ToString("dd/MM/yyyy") + " son: " + horariosOcupados);
                }
                else
                {
                    turno.FechaYHora = fechaHoraTurnoActual;
                }
            }
            else
            {
                ModelState.AddModelError("HorarioTurno", "Horario inválido");
            }

            if (ModelState.IsValid)
            {
                turno.PrecioTurno = db.Especialidad.First(x => x.EspecialidadId == turno.IdEspecialidadMedico).PrecioPorDefecto;
                db.Entry(turno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEspecialidadMedico = new SelectList(db.Especialidad.ToList().Select(x => new { x.EspecialidadId, Nombre = x.Nombre + "($" + x.PrecioPorDefecto + ")" }).ToList(), "EspecialidadId", "Nombre", turno.IdEspecialidadMedico);
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", turno.IdFormaDePago);
            ViewBag.IdMedico = new SelectList(db.Medico.ToList().Select(x => new { x.IdMedico, ApellidoNombre = x.PersonalInterno.FirstOrDefault().Apellido + ", " + x.PersonalInterno.FirstOrDefault().Nombre }), "IdMedico", "ApellidoNombre", turno.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente.ToList().Select(x => new { x.IdPaciente, ApellidoNombre = x.Apellidos + ", " + x.Nombres }), "IdPaciente", "ApellidoNombre", turno.IdPaciente);
            ViewBag.IdSeguroMedico = new SelectList(db.SegurosMedico, "IdSeguroMedico", "Nombre", turno.IdSeguroMedico);
            ViewBag.HorarioTurno = new SelectList(this.__horariosTurno, turno.FechaYHora.ToString("HH:mm"));
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