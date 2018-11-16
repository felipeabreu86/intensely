using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Linq;
using Logger;

namespace Dominio.Repositorio
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        /// <summary>
        /// Busca um usuário na tabela USUARIOS por meio do seu e-mail cadastrado
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <returns>Usuário encontrado ou null</returns>
        public Usuario ObterUsuario(string email)
        {
            try
            {
                return _context?.Usuarios?.FirstOrDefault(x => email.Equals(x.Email)) ?? null;
            }
            catch (Exception e)
            {
                Log.Error(e, "Erro ao obter usuário");
                return null;
            }
        }

        /// <summary>
        /// Salva ou atualiza no banco de dados USUARIOS dado uma instância de usuário passada por parâmetro
        /// </summary>
        /// <param name="usuario">Usuário a ser adicionado ou atualizado</param>
        public void SalvarOuAtualizar(Usuario usuario)
        {
            try
            {
                if (usuario == null) return;
                if (usuario.Id == 0)
                {
                    _context?.Usuarios?.Add(usuario);
                }
                else
                {
                    var usuarioExistente = _context?.Usuarios?.Find(usuario.Id) ?? null;
                    if (usuarioExistente != null)
                    {
                        usuarioExistente = usuario;
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Log.Error(e, "Erro ao salvar ou atualizar usuário");
            }
        }
    }
}