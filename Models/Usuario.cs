using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Pessoa_Fisica { get; set; } = string.Empty;
        public string? Pessoa_Juridica { get; set; } = string.Empty;
    }
}
