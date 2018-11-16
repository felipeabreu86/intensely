using System.Web.Mvc;

namespace Site.Areas.Restrito.Controllers
{
    public class InicioController : Controller
    {
        // GET: Restrito/Inicio
        public ActionResult Index()
        {
            return View();
        }
    }
}