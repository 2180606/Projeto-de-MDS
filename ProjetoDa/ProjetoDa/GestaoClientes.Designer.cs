namespace ProjetoDa
{
    partial class GestaoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.TextBoxNifCliente = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelNif = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxMoradaCliente = new System.Windows.Forms.TextBox();
            this.textBoxContactoCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.baseDadosDADataSet = new ProjetoDa.BaseDadosDADataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ProjetoDa.BaseDadosDADataSetTableAdapters.ClientesTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.buttonInserir);
            this.groupBox1.Controls.Add(this.buttonApagar);
            this.groupBox1.Controls.Add(this.TextBoxNifCliente);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.labelMorada);
            this.groupBox1.Controls.Add(this.labelContacto);
            this.groupBox1.Controls.Add(this.labelNif);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.textBoxMoradaCliente);
            this.groupBox1.Controls.Add(this.textBoxContactoCliente);
            this.groupBox1.Controls.Add(this.textBoxNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão dos Clientes";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(197, 248);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 27);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(278, 248);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 27);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // TextBoxNifCliente
            // 
            this.TextBoxNifCliente.Location = new System.Drawing.Point(118, 114);
            this.TextBoxNifCliente.Name = "TextBoxNifCliente";
            this.TextBoxNifCliente.Size = new System.Drawing.Size(259, 20);
            this.TextBoxNifCliente.TabIndex = 7;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(56, 248);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(135, 27);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "alterar dados";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.ButtonAlterar_Click);
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(9, 199);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(96, 13);
            this.labelMorada.TabIndex = 1;
            this.labelMorada.Text = "Morada do Cliente:";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(9, 158);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(103, 13);
            this.labelContacto.TabIndex = 1;
            this.labelContacto.Text = "Contacto do Cliente:";
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Location = new System.Drawing.Point(9, 117);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(77, 13);
            this.labelNif.TabIndex = 1;
            this.labelNif.Text = "NIF do Cliente:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 74);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(88, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome do Cliente:";
            // 
            // textBoxMoradaCliente
            // 
            this.textBoxMoradaCliente.Location = new System.Drawing.Point(118, 196);
            this.textBoxMoradaCliente.Name = "textBoxMoradaCliente";
            this.textBoxMoradaCliente.Size = new System.Drawing.Size(259, 20);
            this.textBoxMoradaCliente.TabIndex = 0;
            // 
            // textBoxContactoCliente
            // 
            this.textBoxContactoCliente.Location = new System.Drawing.Point(118, 155);
            this.textBoxContactoCliente.Name = "textBoxContactoCliente";
            this.textBoxContactoCliente.Size = new System.Drawing.Size(259, 20);
            this.textBoxContactoCliente.TabIndex = 0;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(118, 71);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(259, 20);
            this.textBoxNomeCliente.TabIndex = 0;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.clientesDataGridView);
            this.groupBoxClientes.Controls.Add(this.buttonFiltrar);
            this.groupBoxClientes.Controls.Add(this.textBoxFiltrar);
            this.groupBoxClientes.Controls.Add(this.labelFiltrar);
            this.groupBoxClientes.Location = new System.Drawing.Point(413, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(459, 312);
            this.groupBoxClientes.TabIndex = 6;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Listagem de Clientes";
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.AllowUserToResizeColumns = false;
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(6, 58);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.Size = new System.Drawing.Size(444, 242);
            this.clientesDataGridView.TabIndex = 3;
            this.clientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDataGridView_CellClick);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(351, 29);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(99, 23);
            this.buttonFiltrar.TabIndex = 3;
            this.buttonFiltrar.Text = "filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.ButtonFiltrar_Click);
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(118, 31);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(227, 20);
            this.textBoxFiltrar.TabIndex = 1;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(18, 34);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(94, 13);
            this.labelFiltrar.TabIndex = 2;
            this.labelFiltrar.Text = "Filtrar Clientes Por:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(389, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // baseDadosDADataSet
            // 
            this.baseDadosDADataSet.DataSetName = "BaseDadosDADataSet";
            this.baseDadosDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.baseDadosDADataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxClientes);
            this.Name = "GestaoClientes";
            this.Text = "GestaoClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoClientes_FormClosing);
            this.Load += new System.EventHandler(this.GestaoClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.TextBox TextBoxNifCliente;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxMoradaCliente;
        private System.Windows.Forms.TextBox textBoxContactoCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private BaseDadosDADataSet baseDadosDADataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BaseDadosDADataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
    }
}