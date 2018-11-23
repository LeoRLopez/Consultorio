using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin,Usuario")]
    public class FormasDePagoController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: FormasDePago
        public ActionResult Index()
        {
            return View(db.FormaDePago.ToList());
        }

        // GET: FormasDePago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaDePago formaDePago = db.FormaDePago.Find(id);
            if (formaDePago == null)
            {
                return HttpNotFound();
            }
            return View(formaDePago);
        }

        // GET: FormasDePago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormasDePago/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFormaDePago,Nombre")] FormaDePago formaDePago)
        {
            if (ModelState.IsValid)
            {
                db.FormaDePago.Add(formaDePago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formaDePago);
        }

        // GET: FormasDePago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaDePago formaDePago = db.FormaDePago.Find(id);
            if (formaDePago == null)
            {
                return HttpNotFound();
            }
            return View(formaDePago);
        }

        // POST: FormasDePago/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFormaDePago,Nombre")] FormaDePago formaDePago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formaDePago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formaDePago);
        }

        // GET: FormasDePago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaDePago formaDePago = db.FormaDePago.Find(id);
            if (formaDePago == null)
            {
                return HttpNotFound();
            }
            return View(formaDePago);
        }

        // POST: FormasDePago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormaDePago formaDePago = db.FormaDePago.Find(id);
            db.FormaDePago.Remove(formaDePago);
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
