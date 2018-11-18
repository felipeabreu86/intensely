using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Repositorio;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace Site.Controllers
{
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Inicio", new { area = "Restrito" });
            }
            return View(new Usuario());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuarioInput)
        {
            if (ModelState.IsValid)
            {
                IUsuariosRepositorio usuarios = new UsuariosRepositorio();
                Usuario usuario = usuarios.ObterUsuario(usuarioInput.Email);
                if (usuario == null || !Equals(usuario.Senha, usuarioInput.Senha))
                {
                    ModelState.AddModelError(string.Empty, "E-mail ou senha incorretos");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(usuario.Id.ToString(), false);
                    usuario.UltimoAcesso = DateTime.Now;
                    usuarios.SalvarOuAtualizar(usuario);
                    return RedirectToAction("Index", "Inicio", new { area = "Restrito" });
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}