namespace ApontaMe.Forms
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            lcApontame = new DevExpress.XtraLayout.LayoutControl();
            pcApontame = new DevExpress.XtraEditors.PanelControl();
            btnApontamentos = new DevExpress.XtraEditors.SimpleButton();
            btnUsuarios = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)lcApontame).BeginInit();
            lcApontame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcApontame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // lcApontame
            // 
            lcApontame.Controls.Add(pcApontame);
            lcApontame.Controls.Add(btnApontamentos);
            lcApontame.Controls.Add(btnUsuarios);
            lcApontame.Dock = DockStyle.Fill;
            lcApontame.Location = new Point(0, 0);
            lcApontame.Name = "lcApontame";
            lcApontame.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(938, 7, 650, 400);
            lcApontame.Root = Root;
            lcApontame.Size = new Size(712, 341);
            lcApontame.TabIndex = 0;
            lcApontame.Text = "layoutControl1";
            // 
            // pcApontame
            // 
            pcApontame.Location = new Point(12, 79);
            pcApontame.Name = "pcApontame";
            pcApontame.Size = new Size(688, 240);
            pcApontame.TabIndex = 6;
            // 
            // btnApontamentos
            // 
            btnApontamentos.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnApontamentos.Appearance.Options.UseFont = true;
            btnApontamentos.ImageOptions.Image = (Image)resources.GetObject("btnApontamentos.ImageOptions.Image");
            btnApontamentos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            btnApontamentos.Location = new Point(128, 12);
            btnApontamentos.Name = "btnApontamentos";
            btnApontamentos.Size = new Size(99, 63);
            btnApontamentos.StyleController = lcApontame;
            btnApontamentos.TabIndex = 5;
            btnApontamentos.Text = "Apontamentos";
            btnApontamentos.Click += btnApontamentos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnUsuarios.Appearance.Options.UseFont = true;
            btnUsuarios.ImageOptions.Image = (Image)resources.GetObject("btnUsuarios.ImageOptions.Image");
            btnUsuarios.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            btnUsuarios.Location = new Point(12, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(99, 63);
            btnUsuarios.StyleController = lcApontame;
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, emptySpaceItem2, emptySpaceItem3, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(712, 341);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnUsuarios;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.MaxSize = new Size(103, 67);
            layoutControlItem1.MinSize = new Size(103, 67);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(103, 67);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.Text = "Usuarios";
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 311);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(692, 10);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnApontamentos;
            layoutControlItem2.Location = new Point(116, 0);
            layoutControlItem2.MaxSize = new Size(103, 67);
            layoutControlItem2.MinSize = new Size(103, 67);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(103, 67);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.Text = "Apontamentos";
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(103, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(13, 67);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(219, 0);
            emptySpaceItem3.MinSize = new Size(104, 24);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(473, 67);
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = pcApontame;
            layoutControlItem3.Location = new Point(0, 67);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(692, 244);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(712, 341);
            Controls.Add(lcApontame);
            IconOptions.ShowIcon = false;
            Name = "FrmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aponta.me";
            ((System.ComponentModel.ISupportInitialize)lcApontame).EndInit();
            lcApontame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcApontame).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcApontame;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnUsuarios;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnApontamentos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.PanelControl pcApontame;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}