using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Usuario ObterUsuario(string email);
        void SalvarOuAtualizar(Usuario usuario);
    }
}