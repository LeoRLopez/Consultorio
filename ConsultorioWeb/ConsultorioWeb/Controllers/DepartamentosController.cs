using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin,Usuario")]
    public class DepartamentosController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Departamentos
        public ActionResult Index()
        {
            var departamento = db.Departamento.Include(d => d.Ciudad).Include(d => d.Provincia);
            return View(departamento.ToList());
        }

        // GET: Departamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamento.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        // GET: Departamentos/Create
        public ActionResult Create()
        {
            ViewBag.ProvinciaId = new SelectList(db.Ciudad, "CiudadId", "Nombre");
            ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "Nombre");
            return View();
        }

        // POST: Departamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DepartamentoId,Nombre,ProvinciaId")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Departamento.Add(departamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProvinciaId = new SelectList(db.Ciudad, "CiudadId", "Nombre", departamento.ProvinciaId);
            ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "Nombre", departamento.ProvinciaId);
            return View(departamento);
        }

        // GET: Departamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamento.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProvinciaId = new SelectList(db.Ciudad, "CiudadId", "Nombre", departamento.ProvinciaId);
            ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "Nombre", departamento.ProvinciaId);
            return View(departamento);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DepartamentoId,Nombre,ProvinciaId")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProvinciaId = new SelectList(db.Ciudad, "CiudadId", "Nombre", departamento.ProvinciaId);
            ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "Nombre", departamento.ProvinciaId);
            return View(departamento);
        }

        // GET: Departamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamento.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Departamento departamento = db.Departamento.Find(id);
            db.Departamento.Remove(departamento);
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
