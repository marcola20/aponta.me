using ApontaMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Interfaces
{
    public interface IUsuarioService
    {
        Usuario? GetUsuario(int id);
        List<Usuario> FindUsuarios();
        void CreateUsuarios(Usuario usuario);
        void UpdateUsuarios(Usuario usuario);
        void DeleteUsuarios(int id);
    }
}
