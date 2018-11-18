using Site.Areas.Restrito.Models;
using System.Web.Mvc;

namespace Site.Areas.Restrito.Controllers
{
    [Authorize]
    public class InicioController : Controller
    {
        /// <summary>
        /// Carrega a tela inicial da área restrita do site
        /// </summary>
        /// <returns>View da área restrita</returns>
        public ActionResult Index()
        {
            var idUsuario = User.Identity.Name;
            return View(UsuarioViewModel.GetInstance(idUsuario));
        }
    }
}