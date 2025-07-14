namespace ApontaMe.Forms.Apontamentos
{
    partial class FrmApontamento_Tarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApontamento_Tarefa));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            txtDescricao = new DevExpress.XtraEditors.MemoEdit();
            spnFim = new DevExpress.XtraEditors.SpinEdit();
            spnInicio = new DevExpress.XtraEditors.SpinEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescricao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnFim.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnInicio.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnCancelar);
            layoutControl1.Controls.Add(btnSalvar);
            layoutControl1.Controls.Add(txtDescricao);
            layoutControl1.Controls.Add(spnFim);
            layoutControl1.Controls.Add(spnInicio);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(731, 7, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(263, 178);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnCancelar.Appearance.Options.UseFont = true;
            btnCancelar.ImageOptions.Image = (Image)resources.GetObject("btnCancelar.ImageOptions.Image");
            btnCancelar.Location = new Point(165, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 22);
            btnCancelar.StyleController = layoutControl1;
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancela&r";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnSalvar.Appearance.Options.UseFont = true;
            btnSalvar.ImageOptions.Image = (Image)resources.GetObject("btnSalvar.ImageOptions.Image");
            btnSalvar.Location = new Point(71, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 22);
            btnSalvar.StyleController = layoutControl1;
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "&Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 68);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(239, 72);
            txtDescricao.StyleController = layoutControl1;
            txtDescricao.TabIndex = 4;
            // 
            // spnFim
            // 
            spnFim.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spnFim.Location = new Point(136, 28);
            spnFim.Name = "spnFim";
            spnFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnFim.Size = new Size(115, 20);
            spnFim.Properties.Mask.EditMask = "n0";
            spnFim.Properties.MaxValue = 31;
            spnFim.Properties.MinValue = 1;
            spnFim.StyleController = layoutControl1;
            spnFim.TabIndex = 3;
            // 
            // spnInicio
            // 
            spnInicio.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spnInicio.Location = new Point(12, 28);
            spnInicio.Name = "spnInicio";
            spnInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnInicio.Size = new Size(110, 20);
            spnInicio.StyleController = layoutControl1;
            spnInicio.TabIndex = 0;
            spnInicio.Properties.MaxValue = 31;
            spnInicio.Properties.MinValue = 1;
            spnInicio.Properties.Mask.EditMask = "n0";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem3, emptySpaceItem4 });
            Root.Name = "Root";
            Root.Size = new Size(263, 178);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = spnInicio;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(114, 40);
            layoutControlItem1.Text = "Dia Inicial";
            layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem1.TextSize = new Size(46, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = spnFim;
            layoutControlItem2.Location = new Point(124, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(119, 40);
            layoutControlItem2.Text = "Dia Final";
            layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem2.TextSize = new Size(46, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(114, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(10, 40);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtDescricao;
            layoutControlItem3.Location = new Point(0, 40);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(243, 92);
            layoutControlItem3.Text = "Descrição";
            layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem3.TextSize = new Size(46, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnSalvar;
            layoutControlItem4.Location = new Point(59, 132);
            layoutControlItem4.MinSize = new Size(75, 26);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(84, 26);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnCancelar;
            layoutControlItem5.Location = new Point(153, 132);
            layoutControlItem5.MaxSize = new Size(90, 26);
            layoutControlItem5.MinSize = new Size(90, 26);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(90, 26);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 132);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(59, 26);
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new Point(143, 132);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(10, 26);
            emptySpaceItem4.TextSize = new Size(0, 0);
            // 
            // FrmApontamento_Tarefa
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(263, 178);
            Controls.Add(layoutControl1);
            IconOptions.ShowIcon = false;
            Name = "FrmApontamento_Tarefa";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tarefas";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDescricao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnFim.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnInicio.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit spnInicio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit spnFim;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.MemoEdit txtDescricao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}