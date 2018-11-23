using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HistoriasClinicasController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: HistoriasClinicas
        public ActionResult Index()
        {
            var historiaClinica = db.HistoriaClinica.Include(h => h.Paciente).Include(h => h.Turno);
            return View(historiaClinica.ToList());
        }

        // GET: HistoriasClinicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaClinica historiaClinica = db.HistoriaClinica.Find(id);
            if (historiaClinica == null)
            {
                return HttpNotFound();
            }
            return View(historiaClinica);
        }

        // GET: HistoriasClinicas/Create
        public ActionResult Create()
        {
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres");
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "Diagnostico");
            return View();
        }

        // POST: HistoriasClinicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdHistoriaClinica,FechaAtencion,Descripcion,IdPaciente,IdTurno")] HistoriaClinica historiaClinica)
        {
            if (ModelState.IsValid)
            {
                db.HistoriaClinica.Add(historiaClinica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", historiaClinica.IdPaciente);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "Diagnostico", historiaClinica.IdTurno);
            return View(historiaClinica);
        }

        // GET: HistoriasClinicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaClinica historiaClinica = db.HistoriaClinica.Find(id);
            if (historiaClinica == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", historiaClinica.IdPaciente);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "Diagnostico", historiaClinica.IdTurno);
            return View(historiaClinica);
        }

        // POST: HistoriasClinicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdHistoriaClinica,FechaAtencion,Descripcion,IdPaciente,IdTurno")] HistoriaClinica historiaClinica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historiaClinica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nombres", historiaClinica.IdPaciente);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "Diagnostico", historiaClinica.IdTurno);
            return View(historiaClinica);
        }

        // GET: HistoriasClinicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaClinica historiaClinica = db.HistoriaClinica.Find(id);
            if (historiaClinica == null)
            {
                return HttpNotFound();
            }
            return View(historiaClinica);
        }

        // POST: HistoriasClinicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistoriaClinica historiaClinica = db.HistoriaClinica.Find(id);
            db.HistoriaClinica.Remove(historiaClinica);
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
