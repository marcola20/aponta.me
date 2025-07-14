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
    public partial class FrmUsuario_Editar : XtraForm
    {
        public Usuario UsuarioEditado { get; private set; } = new Usuario();

        private Usuario? _usuarioOriginal; 

        public FrmUsuario_Editar(Usuario? usuario = null)
        {
            InitializeComponent();
            if (usuario != null)
            {
                _usuarioOriginal = usuario;
                txtPessoa_Fisica.Text = usuario.Pessoa_Fisica;
                txtPessoa_Juridica.Text = usuario.Pessoa_Juridica ?? "";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPessoa_Fisica.Text))
            {
                MessageBox.Show("O campo 'Nome Pessoa Física' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioOriginal != null)
            {
                UsuarioEditado = _usuarioOriginal;
            }

            UsuarioEditado.Pessoa_Fisica = txtPessoa_Fisica.Text.Trim();
            UsuarioEditado.Pessoa_Juridica = string.IsNullOrWhiteSpace(txtPessoa_Juridica.Text) ? null : txtPessoa_Juridica.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}