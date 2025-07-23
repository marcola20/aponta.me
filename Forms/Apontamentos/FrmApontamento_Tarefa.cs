using ApontaMe.Models;
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
    public partial class FrmApontamento_Tarefa : XtraForm
    {
        public ApontamentoTarefa TarefaEditada { get; set; } = new();

        public FrmApontamento_Tarefa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TarefaEditada.Inicio = Convert.ToInt32(spnInicio.Value);
            TarefaEditada.Fim = Convert.ToInt32(spnFim.Value);
            TarefaEditada.Descricao = txtDescricao.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void FrmApontamento_Tarefa_Load(object sender, EventArgs e)
        {
            spnInicio.Value = TarefaEditada.Inicio;
            spnFim.Value = TarefaEditada.Fim;
            txtDescricao.Text = TarefaEditada.Descricao ?? string.Empty;
        }
    }
}