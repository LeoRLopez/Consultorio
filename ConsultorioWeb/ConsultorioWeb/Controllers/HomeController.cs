using ConsultorioWeb.Models;
using System.Web.Mvc;
using System.Linq;

namespace ConsultorioWeb.Controllers
{
    public class HomeController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        public ActionResult Index()
        {
            var infoConsultorio = db.InfoConsultorio.FirstOrDefault();
            if (infoConsultorio != null)
            {
                ViewBag.Mision = infoConsultorio.Mision;
                ViewBag.Vision = infoConsultorio.Vision;
                ViewBag.Descripcion = infoConsultorio.Descripcion;
            }
            return View();
        }

        public ActionResult Contact()
        {
            var infoConsultorio = db.InfoConsultorio.FirstOrDefault();
            if (infoConsultorio != null)
            {
                ViewBag.Direccion = infoConsultorio.Dirección;
                ViewBag.Telefono = infoConsultorio.Telefono;
                ViewBag.Email = infoConsultorio.Email;
            }
            return View();
        }
    }
}