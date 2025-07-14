using ApontaMe.Data;
using ApontaMe.Interfaces;
using ApontaMe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontaMe.Services
{
    public class ApontamentoService : IApontamentoService
    {
        private readonly AppDbContext _context;

        public ApontamentoService(AppDbContext context)
        {
            _context = context;
        }

        public List<Apontamento> FindApontamentos()
        {
            try
            {
                return _context.Apontamentos
                    .Include(a => a.Usuario)
                    .Include(a => a.Tarefas)
                    .OrderByDescending(a => a.Ano).ThenByDescending(a => a.Mes)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar apontamentos: " + ex.Message, ex);
            }
        }

        public Apontamento? GetApontamento(int id)
        {
            try
            {
                return _context.Apontamentos
                    .Include(a => a.Usuario)
                    .Include(a => a.Tarefas)
                    .FirstOrDefault(a => a.ApontamentoID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar apontamento por ID: " + ex.Message, ex);
            }
        }

        public void CreateApontamento(Apontamento apontamento)
        {
            try
            {
                _context.Apontamentos.Add(apontamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar apontamento: " + ex.Message, ex);
            }
        }

        public void UpdateApontamento(Apontamento apontamento)
        {
            try
            {
                _context.Apontamentos.Update(apontamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar apontamento: " + ex.Message, ex);
            }
        }

        public void DeleteApontamento(int id)
        {
            try
            {
                var apontamento = _context.Apontamentos.Find(id);
                if (apontamento != null)
                {
                    _context.Apontamentos.Remove(apontamento);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir apontamento: " + ex.Message, ex);
            }
        }
    }
}
