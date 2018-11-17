using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Repositorio;

namespace Site.Areas.Restrito.Models
{
    public class UsuarioViewModel
    {
        string Email { get; set; }
        string Nome { get; set; }

        public static UsuarioViewModel GetById(int id)
        {
            IUsuariosRepositorio usuarios = new UsuariosRepositorio();
            Usuario usuario = usuarios.ObterUsuario(id);
            if(usuario != null)
            {
                return new UsuarioViewModel()
                {
                    Email = usuario.Email,
                    Nome = usuario.Nome
                };
            }
            return null;
        }
    }
}