using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Carrega a página principal do site
        /// </summary>
        /// <returns>View index</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}