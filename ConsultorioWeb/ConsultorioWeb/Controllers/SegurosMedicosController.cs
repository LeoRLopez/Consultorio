using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin,Usuario")]
    public class SegurosMedicosController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: SegurosMedicos
        public ActionResult Index()
        {
            return View(db.SegurosMedico.ToList());
        }

        // GET: SegurosMedicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegurosMedico segurosMedico = db.SegurosMedico.Find(id);
            if (segurosMedico == null)
            {
                return HttpNotFound();
            }
            return View(segurosMedico);
        }

        // GET: SegurosMedicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SegurosMedicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSeguroMedico,Nombre,BajaLogica")] SegurosMedico segurosMedico)
        {
            if (ModelState.IsValid)
            {
                db.SegurosMedico.Add(segurosMedico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(segurosMedico);
        }

        // GET: SegurosMedicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegurosMedico segurosMedico = db.SegurosMedico.Find(id);
            if (segurosMedico == null)
            {
                return HttpNotFound();
            }
            return View(segurosMedico);
        }

        // POST: SegurosMedicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSeguroMedico,Nombre,BajaLogica")] SegurosMedico segurosMedico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(segurosMedico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(segurosMedico);
        }

        // GET: SegurosMedicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegurosMedico segurosMedico = db.SegurosMedico.Find(id);
            if (segurosMedico == null)
            {
                return HttpNotFound();
            }
            return View(segurosMedico);
        }

        // POST: SegurosMedicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SegurosMedico segurosMedico = db.SegurosMedico.Find(id);
            db.SegurosMedico.Remove(segurosMedico);
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
