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
        /// <param name="id">Id do Usuário</param>
        /// <returns>View da área restrita</returns>
        public ActionResult Index(int id)
        {
            var viewModel = UsuarioViewModel.GetById(id);
            return View(viewModel);
        }
    }
}