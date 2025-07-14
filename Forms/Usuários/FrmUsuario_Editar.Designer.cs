namespace ApontaMe.Forms.Usuários
{
    partial class FrmUsuario_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario_Editar));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            txtPessoa_Juridica = new DevExpress.XtraEditors.TextEdit();
            txtPessoa_Fisica = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            lciPessoa_Fisica = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciPessoa_Juridica = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPessoa_Juridica.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPessoa_Fisica.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciPessoa_Fisica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciPessoa_Juridica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnCancelar);
            layoutControl1.Controls.Add(btnSalvar);
            layoutControl1.Controls.Add(txtPessoa_Juridica);
            layoutControl1.Controls.Add(txtPessoa_Fisica);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(690, 7, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(298, 148);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnCancelar.Appearance.Options.UseFont = true;
            btnCancelar.ImageOptions.Image = (Image)resources.GetObject("btnCancelar.ImageOptions.Image");
            btnCancelar.Location = new Point(200, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 27);
            btnCancelar.StyleController = layoutControl1;
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnSalvar.Appearance.Options.UseFont = true;
            btnSalvar.ImageOptions.Image = (Image)resources.GetObject("btnSalvar.ImageOptions.Image");
            btnSalvar.Location = new Point(109, 93);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(77, 27);
            btnSalvar.StyleController = layoutControl1;
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPessoa_Juridica
            // 
            txtPessoa_Juridica.Location = new Point(12, 68);
            txtPessoa_Juridica.Name = "txtPessoa_Juridica";
            txtPessoa_Juridica.Size = new Size(274, 20);
            txtPessoa_Juridica.StyleController = layoutControl1;
            txtPessoa_Juridica.TabIndex = 3;
            // 
            // txtPessoa_Fisica
            // 
            txtPessoa_Fisica.Location = new Point(12, 28);
            txtPessoa_Fisica.Name = "txtPessoa_Fisica";
            txtPessoa_Fisica.Size = new Size(274, 20);
            txtPessoa_Fisica.StyleController = layoutControl1;
            txtPessoa_Fisica.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciPessoa_Fisica, emptySpaceItem1, lciPessoa_Juridica, layoutControlItem1, layoutControlItem2, simpleSeparator1, emptySpaceItem2, emptySpaceItem3 });
            Root.Name = "Root";
            Root.Size = new Size(298, 148);
            Root.TextVisible = false;
            // 
            // lciPessoa_Fisica
            // 
            lciPessoa_Fisica.Control = txtPessoa_Fisica;
            lciPessoa_Fisica.Location = new Point(0, 0);
            lciPessoa_Fisica.Name = "lciPessoa_Fisica";
            lciPessoa_Fisica.Size = new Size(278, 40);
            lciPessoa_Fisica.Text = "Nome Pessoa Física:";
            lciPessoa_Fisica.TextLocation = DevExpress.Utils.Locations.Top;
            lciPessoa_Fisica.TextSize = new Size(107, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 112);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(278, 16);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // lciPessoa_Juridica
            // 
            lciPessoa_Juridica.Control = txtPessoa_Juridica;
            lciPessoa_Juridica.Location = new Point(0, 40);
            lciPessoa_Juridica.Name = "lciPessoa_Juridica";
            lciPessoa_Juridica.Size = new Size(278, 40);
            lciPessoa_Juridica.Text = "Nome Pessoa Jurídica:";
            lciPessoa_Juridica.TextLocation = DevExpress.Utils.Locations.Top;
            lciPessoa_Juridica.TextSize = new Size(107, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnSalvar;
            layoutControlItem1.Location = new Point(97, 81);
            layoutControlItem1.MaxSize = new Size(81, 31);
            layoutControlItem1.MinSize = new Size(81, 31);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(81, 31);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnCancelar;
            layoutControlItem2.Location = new Point(188, 81);
            layoutControlItem2.MaxSize = new Size(90, 31);
            layoutControlItem2.MinSize = new Size(90, 31);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(90, 31);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            simpleSeparator1.AllowHotTrack = false;
            simpleSeparator1.Location = new Point(97, 80);
            simpleSeparator1.Name = "simpleSeparator1";
            simpleSeparator1.Size = new Size(181, 1);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 80);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(97, 32);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(178, 81);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(10, 31);
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // FrmEditar_Usuario
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(298, 148);
            ControlBox = false;
            Controls.Add(layoutControl1);
            IconOptions.ShowIcon = false;
            Name = "FrmEditar_Usuario";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Usuário";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPessoa_Juridica.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPessoa_Fisica.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciPessoa_Fisica).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciPessoa_Juridica).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtPessoa_Fisica;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciPessoa_Fisica;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtPessoa_Juridica;
        private DevExpress.XtraLayout.LayoutControlItem lciPessoa_Juridica;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}