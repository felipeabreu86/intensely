using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Usuario ObterUsuario(int id);
        Usuario ObterUsuario(string email);
        void SalvarOuAtualizar(Usuario usuario);
    }
}