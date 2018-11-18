using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Repositorio;

namespace Site.Areas.Restrito.Models
{
    public class UsuarioViewModel
    {
        public string Email { get; }
        public string Nome { get; }
        public bool IsAdmin { get; }

        private UsuarioViewModel() { }

        private UsuarioViewModel(string email, string nome, bool isAdmin)
        {
            Email = email;
            Nome = nome;
            IsAdmin = isAdmin;
        }

        public static UsuarioViewModel GetInstance(string userId)
        {
            int id = 0;
            int.TryParse(userId, out id);
            if (id > 0)
                return GetByUserId(id);
            else
                return new UsuarioViewModel();
        }

        private static UsuarioViewModel GetByUserId(int id)
        {
            IUsuariosRepositorio usuarios = new UsuariosRepositorio();
            Usuario usuario = usuarios.ObterUsuario(id);
            if (usuario != null)
            {
                return new UsuarioViewModel(usuario.Email, usuario.Nome, usuario.IsAdmin);
            }
            return null;
        }
    }
}