namespace ApontaMe.Forms.Usuários
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnFechar = new DevExpress.XtraEditors.SimpleButton();
            btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            btnEditar = new DevExpress.XtraEditors.SimpleButton();
            btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            grdUsuarios = new DevExpress.XtraGrid.GridControl();
            grdViewUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPessoa_Fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            colPessoa_Juridica = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            workerUsuarios = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnFechar);
            layoutControl1.Controls.Add(btnExcluir);
            layoutControl1.Controls.Add(btnEditar);
            layoutControl1.Controls.Add(btnAdicionar);
            layoutControl1.Controls.Add(grdUsuarios);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1147, 7, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(661, 264);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnFechar
            // 
            btnFechar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnFechar.Appearance.Options.UseFont = true;
            btnFechar.ImageOptions.Image = (Image)resources.GetObject("btnFechar.ImageOptions.Image");
            btnFechar.Location = new Point(321, 221);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(115, 27);
            btnFechar.StyleController = layoutControl1;
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fecha&r Janela";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnExcluir.Appearance.Options.UseFont = true;
            btnExcluir.ImageOptions.Image = (Image)resources.GetObject("btnExcluir.ImageOptions.Image");
            btnExcluir.Location = new Point(224, 221);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(89, 27);
            btnExcluir.StyleController = layoutControl1;
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnEditar.Appearance.Options.UseFont = true;
            btnEditar.ImageOptions.Image = (Image)resources.GetObject("btnEditar.ImageOptions.Image");
            btnEditar.Location = new Point(116, 221);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 27);
            btnEditar.StyleController = layoutControl1;
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnAdicionar.Appearance.Options.UseFont = true;
            btnAdicionar.ImageOptions.Image = (Image)resources.GetObject("btnAdicionar.ImageOptions.Image");
            btnAdicionar.Location = new Point(12, 221);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 27);
            btnAdicionar.StyleController = layoutControl1;
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // grdUsuarios
            // 
            grdUsuarios.Location = new Point(12, 12);
            grdUsuarios.MainView = grdViewUsuarios;
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.Size = new Size(637, 205);
            grdUsuarios.TabIndex = 4;
            grdUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewUsuarios });
            // 
            // grdViewUsuarios
            // 
            grdViewUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUsuarioID, colPessoa_Fisica, colPessoa_Juridica });
            grdViewUsuarios.GridControl = grdUsuarios;
            grdViewUsuarios.Name = "grdViewUsuarios";
            grdViewUsuarios.OptionsView.ShowFooter = true;
            grdViewUsuarios.OptionsView.ShowGroupPanel = false;
            grdViewUsuarios.OptionsView.ShowIndicator = false;
            // 
            // colUsuarioID
            // 
            colUsuarioID.Caption = "Código";
            colUsuarioID.FieldName = "UsuarioID";
            colUsuarioID.Name = "colUsuarioID";
            colUsuarioID.OptionsColumn.AllowEdit = false;
            colUsuarioID.OptionsColumn.AllowFocus = false;
            colUsuarioID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colUsuarioID.OptionsColumn.FixedWidth = true;
            colUsuarioID.OptionsColumn.ReadOnly = true;
            colUsuarioID.Visible = true;
            colUsuarioID.VisibleIndex = 0;
            colUsuarioID.Width = 72;
            // 
            // colPessoa_Fisica
            // 
            colPessoa_Fisica.Caption = "Pessoa Física";
            colPessoa_Fisica.FieldName = "Pessoa_Fisica";
            colPessoa_Fisica.Name = "colPessoa_Fisica";
            colPessoa_Fisica.OptionsColumn.AllowEdit = false;
            colPessoa_Fisica.OptionsColumn.AllowFocus = false;
            colPessoa_Fisica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colPessoa_Fisica.OptionsColumn.FixedWidth = true;
            colPessoa_Fisica.OptionsColumn.ReadOnly = true;
            colPessoa_Fisica.Visible = true;
            colPessoa_Fisica.VisibleIndex = 1;
            colPessoa_Fisica.Width = 286;
            // 
            // colPessoa_Juridica
            // 
            colPessoa_Juridica.Caption = "Pessoa Jurídica";
            colPessoa_Juridica.FieldName = "Pessoa_Juridica";
            colPessoa_Juridica.Name = "colPessoa_Juridica";
            colPessoa_Juridica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colPessoa_Juridica.OptionsColumn.FixedWidth = true;
            colPessoa_Juridica.Visible = true;
            colPessoa_Juridica.VisibleIndex = 2;
            colPessoa_Juridica.Width = 350;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, emptySpaceItem1, layoutControlItem4, layoutControlItem5 });
            Root.Name = "Root";
            Root.Size = new Size(661, 264);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = grdUsuarios;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(641, 209);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnAdicionar;
            layoutControlItem2.Location = new Point(0, 209);
            layoutControlItem2.MaxSize = new Size(104, 35);
            layoutControlItem2.MinSize = new Size(104, 35);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem2.Size = new Size(104, 35);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnEditar;
            layoutControlItem3.Location = new Point(104, 209);
            layoutControlItem3.MaxSize = new Size(108, 35);
            layoutControlItem3.MinSize = new Size(108, 35);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem3.Size = new Size(108, 35);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(432, 209);
            emptySpaceItem1.MinSize = new Size(104, 24);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(209, 35);
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnExcluir;
            layoutControlItem4.Location = new Point(212, 209);
            layoutControlItem4.MaxSize = new Size(97, 35);
            layoutControlItem4.MinSize = new Size(97, 35);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem4.Size = new Size(97, 35);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnFechar;
            layoutControlItem5.Location = new Point(309, 209);
            layoutControlItem5.MaxSize = new Size(123, 35);
            layoutControlItem5.MinSize = new Size(123, 35);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem5.Size = new Size(123, 35);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // workerUsuarios
            // 
            workerUsuarios.DoWork += workerUsuarios_DoWork;
            workerUsuarios.RunWorkerCompleted += workerUsuarios_RunWorkerCompleted;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 264);
            Controls.Add(layoutControl1);
            IconOptions.ShowIcon = false;
            Name = "FrmUsuarios";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewUsuarios;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        internal DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        internal DevExpress.XtraGrid.Columns.GridColumn colPessoa_Fisica;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoa_Juridica;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.ComponentModel.BackgroundWorker workerUsuarios;
    }
}