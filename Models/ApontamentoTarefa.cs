using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Models
{
    public class ApontamentoTarefa
    {
        public int ApontamentoTarefaID { get; set; }

        public int ApontamentoID { get; set; }
        public Apontamento Apontamento { get; set; } = new Apontamento();

        public int Inicio { get; set; } 
        public int Fim { get; set; }  

        public string Descricao { get; set; } = string.Empty;
    }
}
