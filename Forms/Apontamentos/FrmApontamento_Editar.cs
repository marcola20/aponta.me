using ApontaMe.Interfaces;
using ApontaMe.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSpreadsheet.DocumentFormats.Xlsb;
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
    public partial class FrmApontamento_Editar : DevExpress.XtraEditors.XtraForm
    {
        public Apontamento ApontamentoEditado { get; private set; }
        public bool Modo_Editar { get; set; } = false;


        private List<Usuario> UsuariosDataSource = new();
        private readonly List<ApontamentoTarefa> TarefasDataSource = new();
        private int _apontamentoTempID = -1;

        private readonly IUsuarioService _usuarioService;
        private readonly IApontamentoService _apontamentoService;

        public FrmApontamento_Editar(IUsuarioService usuarioService,
                                     IApontamentoService apontamentoService,
                                     Apontamento? apontamentoExistente = null)
        {
            InitializeComponent();

            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
            _apontamentoService = apontamentoService ?? throw new ArgumentNullException(nameof(apontamentoService));
            ApontamentoEditado = apontamentoExistente ?? new Apontamento
            {
                ApontamentoID = _apontamentoTempID--,
                Tarefas = new List<ApontamentoTarefa>()
            };
        }

        private void FrmEditar_Apontamento_Load(object sender, EventArgs e)
        {
            UsuariosDataSource = _usuarioService.FindUsuarios();
            cboUsuario.Properties.DataSource = UsuariosDataSource;

            cboAno.Properties.Items.AddRange(new[] { 2025, 2026, 2027 });

            var nomesMeses = Enumerable.Range(1, 12).Select(i => System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i)).ToArray();

            cboMes.Properties.Items.AddRange(nomesMeses);

            if (ApontamentoEditado.Mes > 0 && ApontamentoEditado.Mes <= 12)
                cboMes.SelectedIndex = ApontamentoEditado.Mes - 1;

            timeEntrada.Time = DateTime.Today.AddHours(8.5);
            timeSaida.Time = DateTime.Today.AddHours(17.5);

            if (ApontamentoEditado.Usuario != null)
                cboUsuario.EditValue = ApontamentoEditado.Usuario.UsuarioID;

            if (ApontamentoEditado.ApontamentoID > 0)
            {
                cboAno.EditValue = ApontamentoEditado.Ano;
                cboMes.EditValue = ApontamentoEditado.Mes;

                timeEntrada.Time = DateTime.Today.Add(ApontamentoEditado.Entrada);
                timeSaida.Time = DateTime.Today.Add(ApontamentoEditado.Saida);
                spnIntervalo.Value = (decimal)ApontamentoEditado.Intervalo.TotalHours;

                TarefasDataSource.AddRange(ApontamentoEditado.Tarefas);
            }

            if (Modo_Editar)
                cboUsuario.Enabled = false;

            grdTarefas.DataSource = TarefasDataSource;
        }

        private bool Validar()
        {
            if (cboUsuario.EditValue == null)
            {
                MessageBox.Show("Selecione um usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboMes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um mês.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboAno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um ano.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (!Validar())
            {
                btnSalvar.Enabled = true;
                return;
            }

            if (!Modo_Editar && ApontamentoEditado.ApontamentoID <= 0)
                ApontamentoEditado.ApontamentoID = 0;

            ApontamentoEditado.UsuarioID = Convert.ToInt32(cboUsuario.EditValue);
            ApontamentoEditado.Usuario = null;

            ApontamentoEditado.Ano = Convert.ToInt32(cboAno.EditValue);
            ApontamentoEditado.Mes = cboMes.SelectedIndex + 1;

            ApontamentoEditado.Entrada = timeEntrada.Time.TimeOfDay;
            ApontamentoEditado.Saida = timeSaida.Time.TimeOfDay;
            ApontamentoEditado.Intervalo = TimeSpan.FromHours((double)spnIntervalo.Value);

            foreach (var tarefa in TarefasDataSource)
            {
                if (!Modo_Editar && tarefa.ApontamentoTarefaID <= 0)
                    tarefa.ApontamentoTarefaID = 0;
            }

            ApontamentoEditado.Tarefas = TarefasDataSource.ToList();

            try
            {
                if (Modo_Editar)
                    _apontamentoService.UpdateApontamento(ApontamentoEditado);
                else
                    _apontamentoService.CreateApontamento(ApontamentoEditado);

                MessageBox.Show("Apontamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar apontamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSalvar.Enabled = true;
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroMes = cboMes.SelectedIndex + 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using var frm = new FrmApontamento_Tarefa();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var nova = frm.TarefaEditada;
                nova.ApontamentoTarefaID = _apontamentoTempID--;
                TarefasDataSource.Add(nova);
                grdTarefas.RefreshDataSource();
            }
        }

        private void grdViewTarefas_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.FieldName == "Inicio" || e.Column.FieldName == "Fim") && e.Value is int dia)
            {
                if (cboMes.EditValue is int mes && cboAno.EditValue is int ano)
                {
                    try
                    {
                        var data = new DateTime(ano, mes, dia);
                        e.DisplayText = data.ToString("dd/MM");
                    }
                    catch
                    {
                        e.DisplayText = $"Inválido";
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var tarefaSelecionada = grdViewTarefas.GetFocusedRow() as ApontamentoTarefa;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var copia = new ApontamentoTarefa
            {
                ApontamentoTarefaID = tarefaSelecionada.ApontamentoTarefaID,
                ApontamentoID = tarefaSelecionada.ApontamentoID,
                Inicio = tarefaSelecionada.Inicio,
                Fim = tarefaSelecionada.Fim,
                Descricao = tarefaSelecionada.Descricao
            };

            using var frm = new FrmApontamento_Tarefa { TarefaEditada = copia };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                tarefaSelecionada.Inicio = frm.TarefaEditada.Inicio;
                tarefaSelecionada.Fim = frm.TarefaEditada.Fim;
                tarefaSelecionada.Descricao = frm.TarefaEditada.Descricao;

                grdTarefas.RefreshDataSource();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var tarefaSelecionada = grdViewTarefas.GetFocusedRow() as ApontamentoTarefa;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show("Deseja realmente excluir esta tarefa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                TarefasDataSource.Remove(tarefaSelecionada);
                grdTarefas.RefreshDataSource();
            }
        }

    }
}
