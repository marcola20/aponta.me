using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Models
{
    public  class Apontamento
    {
        public int ApontamentoID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario? Usuario { get; set; } = new Usuario();
        public int Ano { get; set; }
        public int Mes { get; set; }

        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }
        public TimeSpan Intervalo { get; set; }
        public ICollection<ApontamentoTarefa> Tarefas { get; set; } = new List<ApontamentoTarefa>();
    }
}
