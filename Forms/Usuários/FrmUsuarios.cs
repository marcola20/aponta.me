using ApontaMe.Interfaces;
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

namespace ApontaMe.Forms.Usuários
{
    public partial class FrmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        private List<Usuario> UsuariosDataSource = new List<Usuario>();

        private readonly IUsuarioService _usuarioService;
        public FrmUsuarios(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (!workerUsuarios.IsBusy)
                workerUsuarios.RunWorkerAsync();
        }


        private void workerUsuarios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Erro ao carregar usuários: " + e.Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Result is List<Usuario> usuarios)
            {
                UsuariosDataSource = usuarios;
                grdUsuarios.DataSource = UsuariosDataSource;
                grdUsuarios.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Erro: resultado inesperado ao carregar usuários.", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void workerUsuarios_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _usuarioService.FindUsuarios();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using var frm = new FrmUsuario_Editar();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _usuarioService.CreateUsuarios(frm.UsuarioEditado);

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerUsuarios.IsBusy)
                        workerUsuarios.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var usuarioSelecionado = grdViewUsuarios.GetFocusedRow() as Usuario;

            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir o usuário '{usuarioSelecionado.Pessoa_Fisica}'?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _usuarioService.DeleteUsuarios(usuarioSelecionado.UsuarioID);
                    MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerUsuarios.IsBusy)
                        workerUsuarios.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var usuarioSelecionado = grdViewUsuarios.GetFocusedRow() as Usuario;

            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioDoBanco = _usuarioService.GetUsuario(usuarioSelecionado.UsuarioID);

            if (usuarioDoBanco == null)
            {
                MessageBox.Show("Usuário não encontrado no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var frm = new FrmUsuario_Editar(usuarioDoBanco);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _usuarioService.UpdateUsuarios(frm.UsuarioEditado);

                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!workerUsuarios.IsBusy)
                        workerUsuarios.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}