namespace ClientHub.App.Forms
{
    partial class CadastroCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcidadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcpf_cnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcriado_em = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.ImageOptions.Image")));
            this.btnAdicionar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 73);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(84, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 74);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.ImageOptions.Image")));
            this.btnExcluir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(165, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.ImageOptions.Image")));
            this.btnAtualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(246, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 74);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 434);
            this.panel1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clienteBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(773, 344);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome,
            this.colcep,
            this.colendereco,
            this.colnumero,
            this.colcomplemento,
            this.colbairro,
            this.coldata_nascimento,
            this.colcidadeId,
            this.colcpf_cnpj,
            this.colcriado_em});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colnome
            // 
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            // 
            // colcep
            // 
            this.colcep.FieldName = "cep";
            this.colcep.Name = "colcep";
            this.colcep.Visible = true;
            this.colcep.VisibleIndex = 2;
            // 
            // colendereco
            // 
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.Visible = true;
            this.colendereco.VisibleIndex = 3;
            // 
            // colnumero
            // 
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 4;
            // 
            // colcomplemento
            // 
            this.colcomplemento.FieldName = "complemento";
            this.colcomplemento.Name = "colcomplemento";
            this.colcomplemento.Visible = true;
            this.colcomplemento.VisibleIndex = 5;
            // 
            // colbairro
            // 
            this.colbairro.FieldName = "bairro";
            this.colbairro.Name = "colbairro";
            this.colbairro.Visible = true;
            this.colbairro.VisibleIndex = 6;
            // 
            // coldata_nascimento
            // 
            this.coldata_nascimento.FieldName = "data_nascimento";
            this.coldata_nascimento.Name = "coldata_nascimento";
            this.coldata_nascimento.Visible = true;
            this.coldata_nascimento.VisibleIndex = 7;
            // 
            // colcidadeId
            // 
            this.colcidadeId.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colcidadeId.FieldName = "cidadeId";
            this.colcidadeId.Name = "colcidadeId";
            this.colcidadeId.Visible = true;
            this.colcidadeId.VisibleIndex = 8;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.cidadeBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nome";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcpf_cnpj
            // 
            this.colcpf_cnpj.FieldName = "cpf_cnpj";
            this.colcpf_cnpj.Name = "colcpf_cnpj";
            this.colcpf_cnpj.Visible = true;
            this.colcpf_cnpj.VisibleIndex = 9;
            // 
            // colcriado_em
            // 
            this.colcriado_em.FieldName = "criado_em";
            this.colcriado_em.Name = "colcriado_em";
            this.colcriado_em.Visible = true;
            this.colcriado_em.VisibleIndex = 10;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colcep;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colcomplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colbairro;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn colcidadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf_cnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colcriado_em;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
    }
}