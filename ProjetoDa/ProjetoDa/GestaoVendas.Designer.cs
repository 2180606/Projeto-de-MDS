namespace ProjetoDa
{
    partial class GestaoVendas
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
            this.buttonAdicionarCarroVenda = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.buttonEliminarCarroVenda = new System.Windows.Forms.Button();
            this.labelChassisCarro = new System.Windows.Forms.Label();
            this.labelMarcaCarro = new System.Windows.Forms.Label();
            this.labelModeloCarro = new System.Windows.Forms.Label();
            this.labelCombustivelCarro = new System.Windows.Forms.Label();
            this.labelExtrasCarro = new System.Windows.Forms.Label();
            this.labelchassis = new System.Windows.Forms.Label();
            this.labelmarca = new System.Windows.Forms.Label();
            this.labelmodelo = new System.Windows.Forms.Label();
            this.labelcombustivel = new System.Windows.Forms.Label();
            this.labelextras = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelVendido = new System.Windows.Forms.Label();
            this.buttonVenderCarro = new System.Windows.Forms.Button();
            this.listBoxVendasEfetuadas = new System.Windows.Forms.ListBox();
            this.buttonHoraDataAtual = new System.Windows.Forms.Button();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDataVenda = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelEstadoVenda = new System.Windows.Forms.Label();
            this.labelCarroVenda = new System.Windows.Forms.Label();
            this.labelVendaVenda = new System.Windows.Forms.Label();
            this.labelClienteVenda = new System.Windows.Forms.Label();
            this.buttonEditarVendas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFatura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdicionarCarroVenda
            // 
            this.buttonAdicionarCarroVenda.Location = new System.Drawing.Point(243, 51);
            this.buttonAdicionarCarroVenda.Name = "buttonAdicionarCarroVenda";
            this.buttonAdicionarCarroVenda.Size = new System.Drawing.Size(225, 32);
            this.buttonAdicionarCarroVenda.TabIndex = 0;
            this.buttonAdicionarCarroVenda.Text = "Adicionar Novo Carro Para Venda";
            this.buttonAdicionarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarroVenda.Click += new System.EventHandler(this.ButtonAdicionarCarroVenda_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 51);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(225, 316);
            this.listBoxClientes.TabIndex = 1;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(243, 129);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(225, 238);
            this.listBoxCarros.TabIndex = 1;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.ListBoxCarros_SelectedIndexChanged);
            // 
            // buttonEliminarCarroVenda
            // 
            this.buttonEliminarCarroVenda.Location = new System.Drawing.Point(243, 89);
            this.buttonEliminarCarroVenda.Name = "buttonEliminarCarroVenda";
            this.buttonEliminarCarroVenda.Size = new System.Drawing.Size(225, 32);
            this.buttonEliminarCarroVenda.TabIndex = 2;
            this.buttonEliminarCarroVenda.Text = "Eliminar Carro Para Venda";
            this.buttonEliminarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonEliminarCarroVenda.Click += new System.EventHandler(this.ButtonEliminarCarroVenda_Click);
            // 
            // labelChassisCarro
            // 
            this.labelChassisCarro.AutoSize = true;
            this.labelChassisCarro.Location = new System.Drawing.Point(121, 29);
            this.labelChassisCarro.Name = "labelChassisCarro";
            this.labelChassisCarro.Size = new System.Drawing.Size(43, 13);
            this.labelChassisCarro.TabIndex = 3;
            this.labelChassisCarro.Text = "Chassis";
            // 
            // labelMarcaCarro
            // 
            this.labelMarcaCarro.AutoSize = true;
            this.labelMarcaCarro.Location = new System.Drawing.Point(121, 57);
            this.labelMarcaCarro.Name = "labelMarcaCarro";
            this.labelMarcaCarro.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaCarro.TabIndex = 3;
            this.labelMarcaCarro.Text = "Marca";
            // 
            // labelModeloCarro
            // 
            this.labelModeloCarro.AutoSize = true;
            this.labelModeloCarro.Location = new System.Drawing.Point(121, 87);
            this.labelModeloCarro.Name = "labelModeloCarro";
            this.labelModeloCarro.Size = new System.Drawing.Size(42, 13);
            this.labelModeloCarro.TabIndex = 3;
            this.labelModeloCarro.Text = "Modelo";
            // 
            // labelCombustivelCarro
            // 
            this.labelCombustivelCarro.AutoSize = true;
            this.labelCombustivelCarro.Location = new System.Drawing.Point(337, 29);
            this.labelCombustivelCarro.Name = "labelCombustivelCarro";
            this.labelCombustivelCarro.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivelCarro.TabIndex = 3;
            this.labelCombustivelCarro.Text = "Combustivel";
            // 
            // labelExtrasCarro
            // 
            this.labelExtrasCarro.AutoSize = true;
            this.labelExtrasCarro.Location = new System.Drawing.Point(337, 57);
            this.labelExtrasCarro.Name = "labelExtrasCarro";
            this.labelExtrasCarro.Size = new System.Drawing.Size(36, 13);
            this.labelExtrasCarro.TabIndex = 3;
            this.labelExtrasCarro.Text = "Extras";
            // 
            // labelchassis
            // 
            this.labelchassis.AutoSize = true;
            this.labelchassis.Location = new System.Drawing.Point(14, 29);
            this.labelchassis.Name = "labelchassis";
            this.labelchassis.Size = new System.Drawing.Size(101, 13);
            this.labelchassis.TabIndex = 3;
            this.labelchassis.Text = "Numero de Chassis:";
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.Location = new System.Drawing.Point(14, 57);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(40, 13);
            this.labelmarca.TabIndex = 3;
            this.labelmarca.Text = "Marca:";
            // 
            // labelmodelo
            // 
            this.labelmodelo.AutoSize = true;
            this.labelmodelo.Location = new System.Drawing.Point(14, 87);
            this.labelmodelo.Name = "labelmodelo";
            this.labelmodelo.Size = new System.Drawing.Size(45, 13);
            this.labelmodelo.TabIndex = 3;
            this.labelmodelo.Text = "Modelo:";
            // 
            // labelcombustivel
            // 
            this.labelcombustivel.AutoSize = true;
            this.labelcombustivel.Location = new System.Drawing.Point(230, 29);
            this.labelcombustivel.Name = "labelcombustivel";
            this.labelcombustivel.Size = new System.Drawing.Size(69, 13);
            this.labelcombustivel.TabIndex = 3;
            this.labelcombustivel.Text = "Combustível:";
            // 
            // labelextras
            // 
            this.labelextras.AutoSize = true;
            this.labelextras.Location = new System.Drawing.Point(230, 57);
            this.labelextras.Name = "labelextras";
            this.labelextras.Size = new System.Drawing.Size(42, 13);
            this.labelextras.TabIndex = 3;
            this.labelextras.Text = "Extras :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCombustivelCarro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelextras);
            this.groupBox1.Controls.Add(this.labelChassisCarro);
            this.groupBox1.Controls.Add(this.labelVendido);
            this.groupBox1.Controls.Add(this.labelExtrasCarro);
            this.groupBox1.Controls.Add(this.labelchassis);
            this.groupBox1.Controls.Add(this.labelcombustivel);
            this.groupBox1.Controls.Add(this.labelMarcaCarro);
            this.groupBox1.Controls.Add(this.labelmarca);
            this.groupBox1.Controls.Add(this.labelmodelo);
            this.groupBox1.Controls.Add(this.labelModeloCarro);
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro Selecionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vendido:";
            // 
            // labelVendido
            // 
            this.labelVendido.AutoSize = true;
            this.labelVendido.Location = new System.Drawing.Point(337, 87);
            this.labelVendido.Name = "labelVendido";
            this.labelVendido.Size = new System.Drawing.Size(46, 13);
            this.labelVendido.TabIndex = 3;
            this.labelVendido.Text = "Vendido";
            // 
            // buttonVenderCarro
            // 
            this.buttonVenderCarro.Location = new System.Drawing.Point(6, 131);
            this.buttonVenderCarro.Name = "buttonVenderCarro";
            this.buttonVenderCarro.Size = new System.Drawing.Size(555, 32);
            this.buttonVenderCarro.TabIndex = 5;
            this.buttonVenderCarro.Text = "Criar Venda (Cliente Selecionado e Carro Selecionado)";
            this.buttonVenderCarro.UseVisualStyleBackColor = true;
            this.buttonVenderCarro.Click += new System.EventHandler(this.ButtonVenderCarro_Click);
            // 
            // listBoxVendasEfetuadas
            // 
            this.listBoxVendasEfetuadas.FormattingEnabled = true;
            this.listBoxVendasEfetuadas.Location = new System.Drawing.Point(6, 169);
            this.listBoxVendasEfetuadas.Name = "listBoxVendasEfetuadas";
            this.listBoxVendasEfetuadas.Size = new System.Drawing.Size(555, 186);
            this.listBoxVendasEfetuadas.TabIndex = 6;
            this.listBoxVendasEfetuadas.SelectedIndexChanged += new System.EventHandler(this.ListBoxVendasEfetuadas_SelectedIndexChanged);
            // 
            // buttonHoraDataAtual
            // 
            this.buttonHoraDataAtual.Location = new System.Drawing.Point(304, 92);
            this.buttonHoraDataAtual.Name = "buttonHoraDataAtual";
            this.buttonHoraDataAtual.Size = new System.Drawing.Size(257, 30);
            this.buttonHoraDataAtual.TabIndex = 16;
            this.buttonHoraDataAtual.Text = "Data e Hora Atuais";
            this.buttonHoraDataAtual.UseVisualStyleBackColor = true;
            this.buttonHoraDataAtual.Click += new System.EventHandler(this.ButtonHoraDataAtual_Click);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.CustomFormat = "hh:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(158, 95);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerHora.TabIndex = 14;
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(6, 95);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerDia.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Indique a Data da Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Indique o Estado da Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Indique o Valor do Veiculo:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Em Pagamento",
            "Pago, por Entregar",
            "Não Pago, por Entregar",
            "Pago e Entregue",
            "Concluída"});
            this.comboBoxEstado.Location = new System.Drawing.Point(304, 44);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(257, 21);
            this.comboBoxEstado.TabIndex = 10;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(6, 44);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(252, 20);
            this.textBoxValor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(239, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Carros de Venda";
            // 
            // labelDataVenda
            // 
            this.labelDataVenda.AutoSize = true;
            this.labelDataVenda.Location = new System.Drawing.Point(3, 411);
            this.labelDataVenda.Name = "labelDataVenda";
            this.labelDataVenda.Size = new System.Drawing.Size(82, 13);
            this.labelDataVenda.TabIndex = 3;
            this.labelDataVenda.Text = "Data da Venda:";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Location = new System.Drawing.Point(301, 411);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(87, 13);
            this.labelValorVenda.TabIndex = 3;
            this.labelValorVenda.Text = "Valor do Veiculo:";
            // 
            // labelEstadoVenda
            // 
            this.labelEstadoVenda.AutoSize = true;
            this.labelEstadoVenda.Location = new System.Drawing.Point(3, 387);
            this.labelEstadoVenda.Name = "labelEstadoVenda";
            this.labelEstadoVenda.Size = new System.Drawing.Size(43, 13);
            this.labelEstadoVenda.TabIndex = 3;
            this.labelEstadoVenda.Text = "Estado:";
            // 
            // labelCarroVenda
            // 
            this.labelCarroVenda.AutoSize = true;
            this.labelCarroVenda.Location = new System.Drawing.Point(301, 387);
            this.labelCarroVenda.Name = "labelCarroVenda";
            this.labelCarroVenda.Size = new System.Drawing.Size(77, 13);
            this.labelCarroVenda.TabIndex = 3;
            this.labelCarroVenda.Text = "Carro Vendido:";
            // 
            // labelVendaVenda
            // 
            this.labelVendaVenda.AutoSize = true;
            this.labelVendaVenda.Location = new System.Drawing.Point(3, 361);
            this.labelVendaVenda.Name = "labelVendaVenda";
            this.labelVendaVenda.Size = new System.Drawing.Size(41, 13);
            this.labelVendaVenda.TabIndex = 3;
            this.labelVendaVenda.Text = "Venda:";
            // 
            // labelClienteVenda
            // 
            this.labelClienteVenda.AutoSize = true;
            this.labelClienteVenda.Location = new System.Drawing.Point(301, 361);
            this.labelClienteVenda.Name = "labelClienteVenda";
            this.labelClienteVenda.Size = new System.Drawing.Size(88, 13);
            this.labelClienteVenda.TabIndex = 3;
            this.labelClienteVenda.Text = "Cliente da Venda";
            // 
            // buttonEditarVendas
            // 
            this.buttonEditarVendas.Location = new System.Drawing.Point(6, 440);
            this.buttonEditarVendas.Name = "buttonEditarVendas";
            this.buttonEditarVendas.Size = new System.Drawing.Size(252, 28);
            this.buttonEditarVendas.TabIndex = 5;
            this.buttonEditarVendas.Text = "Editar Vendas";
            this.buttonEditarVendas.UseVisualStyleBackColor = true;
            this.buttonEditarVendas.Click += new System.EventHandler(this.ButtonEditarVenda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelClienteVenda);
            this.groupBox2.Controls.Add(this.buttonHoraDataAtual);
            this.groupBox2.Controls.Add(this.dateTimePickerHora);
            this.groupBox2.Controls.Add(this.labelVendaVenda);
            this.groupBox2.Controls.Add(this.dateTimePickerDia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelCarroVenda);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelEstadoVenda);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelValorVenda);
            this.groupBox2.Controls.Add(this.labelDataVenda);
            this.groupBox2.Controls.Add(this.comboBoxEstado);
            this.groupBox2.Controls.Add(this.textBoxValor);
            this.groupBox2.Controls.Add(this.listBoxVendasEfetuadas);
            this.groupBox2.Controls.Add(this.buttonFatura);
            this.groupBox2.Controls.Add(this.buttonEditarVendas);
            this.groupBox2.Controls.Add(this.buttonVenderCarro);
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 484);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas";
            // 
            // buttonFatura
            // 
            this.buttonFatura.Location = new System.Drawing.Point(304, 440);
            this.buttonFatura.Name = "buttonFatura";
            this.buttonFatura.Size = new System.Drawing.Size(257, 28);
            this.buttonFatura.TabIndex = 5;
            this.buttonFatura.Text = "Imprimir Fatura da Venda";
            this.buttonFatura.UseVisualStyleBackColor = true;
            this.buttonFatura.Click += new System.EventHandler(this.ButtonEliminarVendas_Click);
            // 
            // GestaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminarCarroVenda);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonAdicionarCarroVenda);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GestaoVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoVendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoVendas_FormClosing);
            this.Load += new System.EventHandler(this.GestaoVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionarCarroVenda;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonEliminarCarroVenda;
        private System.Windows.Forms.Label labelChassisCarro;
        private System.Windows.Forms.Label labelMarcaCarro;
        private System.Windows.Forms.Label labelModeloCarro;
        private System.Windows.Forms.Label labelCombustivelCarro;
        private System.Windows.Forms.Label labelExtrasCarro;
        private System.Windows.Forms.Label labelchassis;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.Label labelmodelo;
        private System.Windows.Forms.Label labelcombustivel;
        private System.Windows.Forms.Label labelextras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVenderCarro;
        private System.Windows.Forms.ListBox listBoxVendasEfetuadas;
        private System.Windows.Forms.Button buttonHoraDataAtual;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDataVenda;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelEstadoVenda;
        private System.Windows.Forms.Label labelCarroVenda;
        private System.Windows.Forms.Label labelVendaVenda;
        private System.Windows.Forms.Label labelClienteVenda;
        private System.Windows.Forms.Button buttonEditarVendas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelVendido;
        private System.Windows.Forms.Button buttonFatura;
    }
}