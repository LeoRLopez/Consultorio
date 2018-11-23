using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PersonalesInternosController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: PersonalesInternos
        public ActionResult Index()
        {
            var personalInterno = db.PersonalInterno.Include(p => p.Ciudad).Include(p => p.Medico).Include(p => p.Pais).Include(p => p.Provincia).Include(p => p.Usuario);
            return View(personalInterno.ToList());
        }

        // GET: PersonalesInternos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInterno personalInterno = db.PersonalInterno.Find(id);
            if (personalInterno == null)
            {
                return HttpNotFound();
            }
            return View(personalInterno);
        }

        // GET: PersonalesInternos/Create
        public ActionResult Create()
        {
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre");
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico");
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre");
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre");
            ViewBag.IdUsuario = new SelectList(db.Usuario, "IdUsuario", "NombreUsuario");
            return View();
        }

        // POST: PersonalesInternos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPersonal,Nombre,Apellido,NumeroDocumento,FechaNacimiento,Edad,Sexo,EstadoCivil,TelCel,Email,Activo,Direccion,IdCiudad,IdProvincia,IdPais,IdUsuario,IdMedico,Bajalogica")] PersonalInterno personalInterno)
        {
            if (ModelState.IsValid)
            {
                db.PersonalInterno.Add(personalInterno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", personalInterno.IdCiudad);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", personalInterno.IdMedico);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", personalInterno.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", personalInterno.IdProvincia);
            ViewBag.IdUsuario = new SelectList(db.Usuario, "IdUsuario", "NombreUsuario", personalInterno.IdUsuario);
            return View(personalInterno);
        }

        // GET: PersonalesInternos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInterno personalInterno = db.PersonalInterno.Find(id);
            if (personalInterno == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", personalInterno.IdCiudad);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", personalInterno.IdMedico);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", personalInterno.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", personalInterno.IdProvincia);
            ViewBag.IdUsuario = new SelectList(db.Usuario, "IdUsuario", "NombreUsuario", personalInterno.IdUsuario);
            return View(personalInterno);
        }

        // POST: PersonalesInternos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPersonal,Nombre,Apellido,NumeroDocumento,FechaNacimiento,Edad,Sexo,EstadoCivil,TelCel,Email,Activo,Direccion,IdCiudad,IdProvincia,IdPais,IdUsuario,IdMedico,Bajalogica")] PersonalInterno personalInterno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalInterno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCiudad = new SelectList(db.Ciudad, "CiudadId", "Nombre", personalInterno.IdCiudad);
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "MatriculaMedico", personalInterno.IdMedico);
            ViewBag.IdPais = new SelectList(db.Pais, "PaisId", "Nombre", personalInterno.IdPais);
            ViewBag.IdProvincia = new SelectList(db.Provincia, "ProvinciaId", "Nombre", personalInterno.IdProvincia);
            ViewBag.IdUsuario = new SelectList(db.Usuario, "IdUsuario", "NombreUsuario", personalInterno.IdUsuario);
            return View(personalInterno);
        }

        // GET: PersonalesInternos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInterno personalInterno = db.PersonalInterno.Find(id);
            if (personalInterno == null)
            {
                return HttpNotFound();
            }
            return View(personalInterno);
        }

        // POST: PersonalesInternos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalInterno personalInterno = db.PersonalInterno.Find(id);
            db.PersonalInterno.Remove(personalInterno);
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
