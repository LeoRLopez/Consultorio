using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin,Usuario")]
    public class PacientesController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Pacientes
        public ActionResult Index()
        {
            var paciente = db.Paciente.Include(p => p.Ciudad).Include(p => p.FormaDePago).Include(p => p.HistoriaClinica).Include(p => p.Pais).Include(p => p.Provincia);
            return View(paciente.ToList());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre");
            ViewBag.IdFormaPagoPorDefecto = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre");
            ViewBag.IdHistoriaClinica = new SelectList(db.HistoriaClinica, "IdHistoriaClinica", "AntecedentesMedicos");
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre");
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre");
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPaciente,Nombres,Apellidos,Email,NumeroDocumento,FechaNacimiento,Edad,Sexo,PrimeraAtencion,TelCelular,IdHistoriaClinica,IdFormaPagoPorDefecto,IdSeguroMedico,Direccion,CodigoPostal,IdCiudad,IdProvincia,IdPais")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Paciente.Add(paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", paciente.IdCiudad);
            ViewBag.IdFormaPagoPorDefecto = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", paciente.IdFormaPagoPorDefecto);
            ViewBag.IdHistoriaClinica = new SelectList(db.HistoriaClinica, "IdHistoriaClinica", "AntecedentesMedicos", paciente.IdHistoriaClinica);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", paciente.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", paciente.IdProvincia);
            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", paciente.IdCiudad);
            ViewBag.IdFormaPagoPorDefecto = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", paciente.IdFormaPagoPorDefecto);
            ViewBag.IdHistoriaClinica = new SelectList(db.HistoriaClinica, "IdHistoriaClinica", "AntecedentesMedicos", paciente.IdHistoriaClinica);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", paciente.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", paciente.IdProvincia);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPaciente,Nombres,Apellidos,Email,NumeroDocumento,FechaNacimiento,Edad,Sexo,PrimeraAtencion,TelCelular,IdHistoriaClinica,IdFormaPagoPorDefecto,IdSeguroMedico,Direccion,CodigoPostal,IdCiudad,IdProvincia,IdPais")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", paciente.IdCiudad);
            ViewBag.IdFormaPagoPorDefecto = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", paciente.IdFormaPagoPorDefecto);
            ViewBag.IdHistoriaClinica = new SelectList(db.HistoriaClinica, "IdHistoriaClinica", "AntecedentesMedicos", paciente.IdHistoriaClinica);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", paciente.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", paciente.IdProvincia);
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paciente paciente = db.Paciente.Find(id);
            db.Paciente.Remove(paciente);
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
