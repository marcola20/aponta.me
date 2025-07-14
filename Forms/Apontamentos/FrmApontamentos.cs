using ApontaMe.Interfaces;
using ApontaMe.Models;
using ApontaMe.Services;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApontaMe.Forms.Apontamentos
{
    public partial class FrmApontamentos : DevExpress.XtraEditors.XtraForm
    {
        private readonly IApontamentoService _apontamentoService;
        private readonly IUsuarioService _usuarioService;

        public FrmApontamentos(IApontamentoService apontamentoService, IUsuarioService usuarioService)
        {
            InitializeComponent();
            _apontamentoService = apontamentoService;
            _usuarioService = usuarioService;
        }

        private void FrmApontamentos_Load(object sender, EventArgs e)
        {
            if (!workerApontamentos.IsBusy)
                workerApontamentos.RunWorkerAsync();
        }

        private void workerApontamentos_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _apontamentoService.FindApontamentos();
        }

        private void workerApontamentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Erro ao carregar apontamentos: " + e.Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Result is List<Apontamento> apontamentos)
            {
                grdApontamento.DataSource = apontamentos;
                grdApontamento.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Erro: resultado inesperado ao carregar apontamentos.", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using var frm = new FrmApontamento_Editar(_usuarioService);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _apontamentoService.CreateApontamento(frm.ApontamentoEditado);

                    MessageBox.Show("Apontamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerApontamentos.IsBusy)
                        workerApontamentos.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar apontamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdViewApontamento.GetFocusedRow() is not Apontamento apontamentoSelecionado)
            {
                MessageBox.Show("Selecione um apontamento para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new FrmApontamento_Editar(_usuarioService, apontamentoSelecionado)
            {
                Modo_Editar = true
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _apontamentoService.UpdateApontamento(frm.ApontamentoEditado);

                    MessageBox.Show("Apontamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerApontamentos.IsBusy)
                        workerApontamentos.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar apontamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (grdViewApontamento.GetFocusedRow() is not Apontamento apontamentoSelecionado)
            {
                MessageBox.Show("Selecione um apontamento para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("Deseja realmente excluir este apontamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    _apontamentoService.DeleteApontamento(apontamentoSelecionado.ApontamentoID);

                    MessageBox.Show("Apontamento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerApontamentos.IsBusy)
                        workerApontamentos.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir apontamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}