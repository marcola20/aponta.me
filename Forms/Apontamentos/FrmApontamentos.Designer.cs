namespace ApontaMe.Forms.Apontamentos
{
    partial class FrmApontamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApontamentos));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            grdApontamento = new DevExpress.XtraGrid.GridControl();
            grdViewApontamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            colApontamentoID = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPessoa_Fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            colMes = new DevExpress.XtraGrid.Columns.GridColumn();
            colAno = new DevExpress.XtraGrid.Columns.GridColumn();
            btnExcel = new DevExpress.XtraEditors.SimpleButton();
            btnFechar = new DevExpress.XtraEditors.SimpleButton();
            btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            btnEditar = new DevExpress.XtraEditors.SimpleButton();
            btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            workerApontamentos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdApontamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewApontamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(grdApontamento);
            layoutControl1.Controls.Add(btnExcel);
            layoutControl1.Controls.Add(btnFechar);
            layoutControl1.Controls.Add(btnExcluir);
            layoutControl1.Controls.Add(btnEditar);
            layoutControl1.Controls.Add(btnAdicionar);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1152, 7, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(661, 272);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // grdApontamento
            // 
            grdApontamento.Location = new Point(12, 12);
            grdApontamento.MainView = grdViewApontamento;
            grdApontamento.Name = "grdApontamento";
            grdApontamento.Size = new Size(637, 211);
            grdApontamento.TabIndex = 10;
            grdApontamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewApontamento });
            // 
            // grdViewApontamento
            // 
            grdViewApontamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colApontamentoID, colUsuarioID, colPessoa_Fisica, colMes, colAno });
            grdViewApontamento.GridControl = grdApontamento;
            grdViewApontamento.Name = "grdViewApontamento";
            grdViewApontamento.OptionsView.ShowFooter = true;
            grdViewApontamento.OptionsView.ShowGroupPanel = false;
            grdViewApontamento.OptionsView.ShowIndicator = false;
            grdViewApontamento.DoubleClick += btnEditar_Click;
            // 
            // colApontamentoID
            // 
            colApontamentoID.AppearanceCell.Options.UseTextOptions = true;
            colApontamentoID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colApontamentoID.Caption = "Cód. Apontamento";
            colApontamentoID.FieldName = "ApontamentoID";
            colApontamentoID.Name = "colApontamentoID";
            colApontamentoID.OptionsColumn.AllowEdit = false;
            colApontamentoID.OptionsColumn.AllowFocus = false;
            colApontamentoID.OptionsColumn.ReadOnly = true;
            colApontamentoID.Visible = true;
            colApontamentoID.VisibleIndex = 0;
            colApontamentoID.Width = 117;
            // 
            // colUsuarioID
            // 
            colUsuarioID.AppearanceCell.Options.UseTextOptions = true;
            colUsuarioID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colUsuarioID.Caption = "Cód. Usuário";
            colUsuarioID.FieldName = "UsuarioID";
            colUsuarioID.Name = "colUsuarioID";
            colUsuarioID.OptionsColumn.AllowEdit = false;
            colUsuarioID.OptionsColumn.AllowFocus = false;
            colUsuarioID.OptionsColumn.ReadOnly = true;
            colUsuarioID.Visible = true;
            colUsuarioID.VisibleIndex = 1;
            colUsuarioID.Width = 84;
            // 
            // colPessoa_Fisica
            // 
            colPessoa_Fisica.Caption = "Nome do Usuário";
            colPessoa_Fisica.FieldName = "Usuario.Pessoa_Fisica";
            colPessoa_Fisica.Name = "colPessoa_Fisica";
            colPessoa_Fisica.OptionsColumn.AllowEdit = false;
            colPessoa_Fisica.OptionsColumn.AllowFocus = false;
            colPessoa_Fisica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colPessoa_Fisica.OptionsColumn.ReadOnly = true;
            colPessoa_Fisica.OptionsFilter.AllowFilter = false;
            colPessoa_Fisica.Visible = true;
            colPessoa_Fisica.VisibleIndex = 2;
            colPessoa_Fisica.Width = 271;
            // 
            // colMes
            // 
            colMes.AppearanceCell.Options.UseTextOptions = true;
            colMes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colMes.Caption = "Mês";
            colMes.FieldName = "Mes";
            colMes.Name = "colMes";
            colMes.OptionsColumn.AllowEdit = false;
            colMes.OptionsColumn.AllowFocus = false;
            colMes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colMes.OptionsColumn.ReadOnly = true;
            colMes.OptionsFilter.AllowFilter = false;
            colMes.Visible = true;
            colMes.VisibleIndex = 3;
            colMes.Width = 111;
            // 
            // colAno
            // 
            colAno.AppearanceCell.Options.UseTextOptions = true;
            colAno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colAno.Caption = "Ano";
            colAno.FieldName = "Ano";
            colAno.Name = "colAno";
            colAno.OptionsColumn.AllowEdit = false;
            colAno.OptionsColumn.AllowFocus = false;
            colAno.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colAno.OptionsColumn.ReadOnly = true;
            colAno.Visible = true;
            colAno.VisibleIndex = 4;
            colAno.Width = 125;
            // 
            // btnExcel
            // 
            btnExcel.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnExcel.Appearance.Options.UseFont = true;
            btnExcel.ImageOptions.Image = (Image)resources.GetObject("btnExcel.ImageOptions.Image");
            btnExcel.Location = new Point(301, 227);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(116, 29);
            btnExcel.StyleController = layoutControl1;
            btnExcel.TabIndex = 9;
            btnExcel.Text = "Gerar &Planilha";
            // 
            // btnFechar
            // 
            btnFechar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnFechar.Appearance.Options.UseFont = true;
            btnFechar.ImageOptions.Image = (Image)resources.GetObject("btnFechar.ImageOptions.Image");
            btnFechar.Location = new Point(425, 227);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(111, 29);
            btnFechar.StyleController = layoutControl1;
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar Janel&a";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnExcluir.Appearance.Options.UseFont = true;
            btnExcluir.ImageOptions.Image = (Image)resources.GetObject("btnExcluir.ImageOptions.Image");
            btnExcluir.Location = new Point(209, 227);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 29);
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
            btnEditar.Location = new Point(121, 227);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 29);
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
            btnAdicionar.Location = new Point(12, 227);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 29);
            btnAdicionar.StyleController = layoutControl1;
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem1, layoutControlItem6, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(661, 272);
            Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnAdicionar;
            layoutControlItem2.Location = new Point(0, 215);
            layoutControlItem2.MaxSize = new Size(109, 37);
            layoutControlItem2.MinSize = new Size(109, 37);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem2.Size = new Size(109, 37);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnEditar;
            layoutControlItem3.Location = new Point(109, 215);
            layoutControlItem3.MaxSize = new Size(88, 37);
            layoutControlItem3.MinSize = new Size(88, 37);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem3.Size = new Size(88, 37);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnExcluir;
            layoutControlItem4.Location = new Point(197, 215);
            layoutControlItem4.MaxSize = new Size(92, 37);
            layoutControlItem4.MinSize = new Size(92, 37);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem4.Size = new Size(92, 37);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnFechar;
            layoutControlItem5.Location = new Point(413, 215);
            layoutControlItem5.MaxSize = new Size(119, 37);
            layoutControlItem5.MinSize = new Size(119, 37);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem5.Size = new Size(119, 37);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(532, 215);
            emptySpaceItem1.MinSize = new Size(104, 24);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(109, 37);
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnExcel;
            layoutControlItem6.Location = new Point(289, 215);
            layoutControlItem6.MaxSize = new Size(124, 37);
            layoutControlItem6.MinSize = new Size(124, 37);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 6);
            layoutControlItem6.Size = new Size(124, 37);
            layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = grdApontamento;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(641, 215);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // workerApontamentos
            // 
            workerApontamentos.DoWork += workerApontamentos_DoWork;
            workerApontamentos.RunWorkerCompleted += workerApontamentos_RunWorkerCompleted;
            // 
            // FrmApontamentos
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 272);
            Controls.Add(layoutControl1);
            IconOptions.ShowIcon = false;
            Name = "FrmApontamentos";
            Text = "Apontamentos";
            Load += FrmApontamentos_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdApontamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewApontamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.ComponentModel.BackgroundWorker workerApontamentos;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl grdApontamento;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewApontamento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colApontamentoID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoa_Fisica;
        private DevExpress.XtraGrid.Columns.GridColumn colMes;
        private DevExpress.XtraGrid.Columns.GridColumn colAno;
    }
}