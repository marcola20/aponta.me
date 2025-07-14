using ApontaMe.Forms.Usuários;
using ApontaMe.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using ApontaMe.Data;
using ApontaMe.Forms.Apontamentos;

namespace ApontaMe.Forms
{
    public partial class FrmInicial : XtraForm
    {
        private readonly AppDbContext _db;

        public FrmInicial(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var usuarioService = new UsuarioService(_db);
            AbrirFormulario(new FrmUsuarios(usuarioService));
        }

        private void AbrirFormulario(Form form)
        {
            pcApontame.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pcApontame.Controls.Add(form);
            form.Show();
        }

        private void btnApontamentos_Click(object sender, EventArgs e)
        {
            var apontamentoService = new ApontamentoService(_db);
            var usuarioService = new UsuarioService(_db);
            AbrirFormulario(new FrmApontamentos(apontamentoService, usuarioService));
        }
    }
}
