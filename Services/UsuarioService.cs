using ApontaMe.Data;
using ApontaMe.Interfaces;
using ApontaMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _dbContext;

        public UsuarioService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Usuario? GetUsuario(int id)
        {
            try
            {
                return _dbContext.Usuarios.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o usuário: " + ex.Message, ex);
            }
        }

        public List<Usuario> FindUsuarios()
        {
            try
            {
                return _dbContext.Usuarios.OrderBy(u => u.Pessoa_Fisica).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuários: " + ex.Message, ex);
            }
        }

        public void CreateUsuarios(Usuario usuario)
        {
            try
            {
                _dbContext.Usuarios.Add(usuario);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar usuário: " + ex.Message, ex);
            }
        }

        public void UpdateUsuarios(Usuario usuario)
        {
            try
            {
                _dbContext.Usuarios.Update(usuario);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar usuário: " + ex.Message, ex);
            }
        }

        public void DeleteUsuarios(int id)
        {
            try
            {
                var usuario = _dbContext.Usuarios.Find(id);
                if (usuario == null)
                    throw new Exception("Usuário não encontrado para exclusão.");

                _dbContext.Usuarios.Remove(usuario);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir usuário: " + ex.Message, ex);
            }
        }
    }
}
