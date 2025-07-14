using ApontaMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Interfaces
{
    public interface IApontamentoService
    {
        List<Apontamento> FindApontamentos();
        Apontamento? GetApontamento(int id);
        void CreateApontamento(Apontamento apontamento);
        void UpdateApontamento(Apontamento apontamento);
        void DeleteApontamento(int id);
    }

}
