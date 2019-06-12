namespace ProjetoDa
{
    partial class Form_GestaoOficina
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEliminarCarroVenda = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCarroVenda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.buttonEliminarParcela = new System.Windows.Forms.Button();
            this.buttonAdicionarParcela = new System.Windows.Forms.Button();
            this.textBoxValorParcela = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDescricaoParcela = new System.Windows.Forms.TextBox();
            this.buttonFatura = new System.Windows.Forms.Button();
            this.buttonEliminarServico = new System.Windows.Forms.Button();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.buttonAdicionarServico = new System.Windows.Forms.Button();
            this.listBoxServico = new System.Windows.Forms.ListBox();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.labelTipoServico = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelContactoCliente = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCombustivelCarro = new System.Windows.Forms.Label();
            this.labelkilometragem = new System.Windows.Forms.Label();
            this.labelmatricula = new System.Windows.Forms.Label();
            this.labelChassisCarro = new System.Windows.Forms.Label();
            this.labelKilometrosCarro = new System.Windows.Forms.Label();
            this.labelMatriculaCarro = new System.Windows.Forms.Label();
            this.labelchassis = new System.Windows.Forms.Label();
            this.labelcombustivel = new System.Windows.Forms.Label();
            this.labelMarcaCarro = new System.Windows.Forms.Label();
            this.labelmarca = new System.Windows.Forms.Label();
            this.labelmodelo = new System.Windows.Forms.Label();
            this.labelModeloCarro = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Carros de Oficina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Clientes";
            // 
            // buttonEliminarCarroVenda
            // 
            this.buttonEliminarCarroVenda.Location = new System.Drawing.Point(12, 373);
            this.buttonEliminarCarroVenda.Name = "buttonEliminarCarroVenda";
            this.buttonEliminarCarroVenda.Size = new System.Drawing.Size(225, 32);
            this.buttonEliminarCarroVenda.TabIndex = 21;
            this.buttonEliminarCarroVenda.Text = "Eliminar Carro Para Oficina";
            this.buttonEliminarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonEliminarCarroVenda.Click += new System.EventHandler(this.ButtonEliminarCarroVenda_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(12, 413);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(225, 264);
            this.listBoxCarros.TabIndex = 19;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.ListBoxCarros_SelectedIndexChanged);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 39);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(225, 264);
            this.listBoxClientes.TabIndex = 20;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // buttonAdicionarCarroVenda
            // 
            this.buttonAdicionarCarroVenda.Location = new System.Drawing.Point(12, 335);
            this.buttonAdicionarCarroVenda.Name = "buttonAdicionarCarroVenda";
            this.buttonAdicionarCarroVenda.Size = new System.Drawing.Size(225, 32);
            this.buttonAdicionarCarroVenda.TabIndex = 18;
            this.buttonAdicionarCarroVenda.Text = "Adicionar Novo Carro para Oficina";
            this.buttonAdicionarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarroVenda.Click += new System.EventHandler(this.ButtonAdicionarCarroVenda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonFatura);
            this.groupBox3.Controls.Add(this.buttonEliminarServico);
            this.groupBox3.Controls.Add(this.labelDataSaida);
            this.groupBox3.Controls.Add(this.buttonAdicionarServico);
            this.groupBox3.Controls.Add(this.listBoxServico);
            this.groupBox3.Controls.Add(this.labelDataEntrada);
            this.groupBox3.Controls.Add(this.labelTipoServico);
            this.groupBox3.Location = new System.Drawing.Point(246, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(708, 384);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço do Carro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxParcelas);
            this.groupBox4.Controls.Add(this.buttonEliminarParcela);
            this.groupBox4.Controls.Add(this.buttonAdicionarParcela);
            this.groupBox4.Controls.Add(this.textBoxValorParcela);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxDescricaoParcela);
            this.groupBox4.Location = new System.Drawing.Point(269, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 262);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gastos do Serviço";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(9, 94);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(418, 160);
            this.listBoxParcelas.TabIndex = 4;
            // 
            // buttonEliminarParcela
            // 
            this.buttonEliminarParcela.Location = new System.Drawing.Point(219, 67);
            this.buttonEliminarParcela.Name = "buttonEliminarParcela";
            this.buttonEliminarParcela.Size = new System.Drawing.Size(208, 21);
            this.buttonEliminarParcela.TabIndex = 2;
            this.buttonEliminarParcela.Text = "Eliminar Parcela";
            this.buttonEliminarParcela.UseVisualStyleBackColor = true;
            this.buttonEliminarParcela.Click += new System.EventHandler(this.ButtonEliminarParcela_Click);
            // 
            // buttonAdicionarParcela
            // 
            this.buttonAdicionarParcela.Location = new System.Drawing.Point(9, 68);
            this.buttonAdicionarParcela.Name = "buttonAdicionarParcela";
            this.buttonAdicionarParcela.Size = new System.Drawing.Size(208, 21);
            this.buttonAdicionarParcela.TabIndex = 2;
            this.buttonAdicionarParcela.Text = "Adicionar Parcela";
            this.buttonAdicionarParcela.UseVisualStyleBackColor = true;
            this.buttonAdicionarParcela.Click += new System.EventHandler(this.ButtonAdicionarParcela_Click);
            // 
            // textBoxValorParcela
            // 
            this.textBoxValorParcela.Location = new System.Drawing.Point(70, 42);
            this.textBoxValorParcela.Name = "textBoxValorParcela";
            this.textBoxValorParcela.Size = new System.Drawing.Size(357, 20);
            this.textBoxValorParcela.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Valor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Descrição:";
            // 
            // textBoxDescricaoParcela
            // 
            this.textBoxDescricaoParcela.Location = new System.Drawing.Point(70, 16);
            this.textBoxDescricaoParcela.Name = "textBoxDescricaoParcela";
            this.textBoxDescricaoParcela.Size = new System.Drawing.Size(357, 20);
            this.textBoxDescricaoParcela.TabIndex = 0;
            // 
            // buttonFatura
            // 
            this.buttonFatura.Location = new System.Drawing.Point(562, 70);
            this.buttonFatura.Name = "buttonFatura";
            this.buttonFatura.Size = new System.Drawing.Size(134, 35);
            this.buttonFatura.TabIndex = 2;
            this.buttonFatura.Text = "Emitir Fatura do Serviço";
            this.buttonFatura.UseVisualStyleBackColor = true;
            this.buttonFatura.Click += new System.EventHandler(this.ButtonFatura_Click);
            // 
            // buttonEliminarServico
            // 
            this.buttonEliminarServico.Location = new System.Drawing.Point(415, 70);
            this.buttonEliminarServico.Name = "buttonEliminarServico";
            this.buttonEliminarServico.Size = new System.Drawing.Size(134, 35);
            this.buttonEliminarServico.TabIndex = 2;
            this.buttonEliminarServico.Text = "Eliminar Serviço";
            this.buttonEliminarServico.UseVisualStyleBackColor = true;
            this.buttonEliminarServico.Click += new System.EventHandler(this.ButtonEliminarServico_Click);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSaida.Location = new System.Drawing.Point(266, 42);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(98, 16);
            this.labelDataSaida.TabIndex = 3;
            this.labelDataSaida.Text = "Data de Saida:";
            // 
            // buttonAdicionarServico
            // 
            this.buttonAdicionarServico.Location = new System.Drawing.Point(269, 70);
            this.buttonAdicionarServico.Name = "buttonAdicionarServico";
            this.buttonAdicionarServico.Size = new System.Drawing.Size(134, 35);
            this.buttonAdicionarServico.TabIndex = 2;
            this.buttonAdicionarServico.Text = "Adicionar Serviço";
            this.buttonAdicionarServico.UseVisualStyleBackColor = true;
            this.buttonAdicionarServico.Click += new System.EventHandler(this.ButtonAdicionarServico_Click);
            // 
            // listBoxServico
            // 
            this.listBoxServico.FormattingEnabled = true;
            this.listBoxServico.Location = new System.Drawing.Point(6, 19);
            this.listBoxServico.Name = "listBoxServico";
            this.listBoxServico.Size = new System.Drawing.Size(254, 355);
            this.listBoxServico.TabIndex = 0;
            this.listBoxServico.SelectedIndexChanged += new System.EventHandler(this.ListBoxServico_SelectedIndexChanged);
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.AutoSize = true;
            this.labelDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEntrada.Location = new System.Drawing.Point(266, 19);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(109, 16);
            this.labelDataEntrada.TabIndex = 3;
            this.labelDataEntrada.Text = "Data de Entrada:";
            // 
            // labelTipoServico
            // 
            this.labelTipoServico.AutoSize = true;
            this.labelTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoServico.Location = new System.Drawing.Point(462, 19);
            this.labelTipoServico.Name = "labelTipoServico";
            this.labelTipoServico.Size = new System.Drawing.Size(107, 16);
            this.labelTipoServico.TabIndex = 3;
            this.labelTipoServico.Text = "Tipo de Serviço:";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionado.Location = new System.Drawing.Point(15, 22);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(169, 20);
            this.labelClienteSelecionado.TabIndex = 26;
            this.labelClienteSelecionado.Text = "Cliente Selecionado";
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifCliente.Location = new System.Drawing.Point(374, 22);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(142, 20);
            this.labelNifCliente.TabIndex = 28;
            this.labelNifCliente.Text = "NIF Selecionado";
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaCliente.Location = new System.Drawing.Point(15, 54);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(130, 20);
            this.labelMoradaCliente.TabIndex = 28;
            this.labelMoradaCliente.Text = "Morada Cliente";
            // 
            // labelContactoCliente
            // 
            this.labelContactoCliente.AutoSize = true;
            this.labelContactoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactoCliente.Location = new System.Drawing.Point(374, 54);
            this.labelContactoCliente.Name = "labelContactoCliente";
            this.labelContactoCliente.Size = new System.Drawing.Size(143, 20);
            this.labelContactoCliente.TabIndex = 26;
            this.labelContactoCliente.Text = "Contacto Cliente";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.labelContactoCliente);
            this.groupBoxCliente.Controls.Add(this.labelClienteSelecionado);
            this.groupBoxCliente.Controls.Add(this.labelNifCliente);
            this.groupBoxCliente.Controls.Add(this.labelMoradaCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(243, 33);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(711, 116);
            this.groupBoxCliente.TabIndex = 29;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente Selecionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCombustivelCarro);
            this.groupBox1.Controls.Add(this.labelkilometragem);
            this.groupBox1.Controls.Add(this.labelmatricula);
            this.groupBox1.Controls.Add(this.labelChassisCarro);
            this.groupBox1.Controls.Add(this.labelKilometrosCarro);
            this.groupBox1.Controls.Add(this.labelMatriculaCarro);
            this.groupBox1.Controls.Add(this.labelchassis);
            this.groupBox1.Controls.Add(this.labelcombustivel);
            this.groupBox1.Controls.Add(this.labelMarcaCarro);
            this.groupBox1.Controls.Add(this.labelmarca);
            this.groupBox1.Controls.Add(this.labelmodelo);
            this.groupBox1.Controls.Add(this.labelModeloCarro);
            this.groupBox1.Location = new System.Drawing.Point(246, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 148);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro Selecionado";
            // 
            // labelCombustivelCarro
            // 
            this.labelCombustivelCarro.AutoSize = true;
            this.labelCombustivelCarro.Location = new System.Drawing.Point(500, 29);
            this.labelCombustivelCarro.Name = "labelCombustivelCarro";
            this.labelCombustivelCarro.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivelCarro.TabIndex = 3;
            this.labelCombustivelCarro.Text = "Combustivel";
            // 
            // labelkilometragem
            // 
            this.labelkilometragem.AutoSize = true;
            this.labelkilometragem.Location = new System.Drawing.Point(372, 87);
            this.labelkilometragem.Name = "labelkilometragem";
            this.labelkilometragem.Size = new System.Drawing.Size(116, 13);
            this.labelkilometragem.TabIndex = 3;
            this.labelkilometragem.Text = "Kilometragem do Carro:";
            // 
            // labelmatricula
            // 
            this.labelmatricula.AutoSize = true;
            this.labelmatricula.Location = new System.Drawing.Point(372, 57);
            this.labelmatricula.Name = "labelmatricula";
            this.labelmatricula.Size = new System.Drawing.Size(53, 13);
            this.labelmatricula.TabIndex = 3;
            this.labelmatricula.Text = "Matricula:";
            // 
            // labelChassisCarro
            // 
            this.labelChassisCarro.AutoSize = true;
            this.labelChassisCarro.Location = new System.Drawing.Point(135, 29);
            this.labelChassisCarro.Name = "labelChassisCarro";
            this.labelChassisCarro.Size = new System.Drawing.Size(43, 13);
            this.labelChassisCarro.TabIndex = 3;
            this.labelChassisCarro.Text = "Chassis";
            // 
            // labelKilometrosCarro
            // 
            this.labelKilometrosCarro.AutoSize = true;
            this.labelKilometrosCarro.Location = new System.Drawing.Point(500, 87);
            this.labelKilometrosCarro.Name = "labelKilometrosCarro";
            this.labelKilometrosCarro.Size = new System.Drawing.Size(54, 13);
            this.labelKilometrosCarro.TabIndex = 3;
            this.labelKilometrosCarro.Text = "kilometros";
            // 
            // labelMatriculaCarro
            // 
            this.labelMatriculaCarro.AutoSize = true;
            this.labelMatriculaCarro.Location = new System.Drawing.Point(500, 57);
            this.labelMatriculaCarro.Name = "labelMatriculaCarro";
            this.labelMatriculaCarro.Size = new System.Drawing.Size(49, 13);
            this.labelMatriculaCarro.TabIndex = 3;
            this.labelMatriculaCarro.Text = "matricula";
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
            // labelcombustivel
            // 
            this.labelcombustivel.AutoSize = true;
            this.labelcombustivel.Location = new System.Drawing.Point(372, 29);
            this.labelcombustivel.Name = "labelcombustivel";
            this.labelcombustivel.Size = new System.Drawing.Size(69, 13);
            this.labelcombustivel.TabIndex = 3;
            this.labelcombustivel.Text = "Combustível:";
            // 
            // labelMarcaCarro
            // 
            this.labelMarcaCarro.AutoSize = true;
            this.labelMarcaCarro.Location = new System.Drawing.Point(136, 57);
            this.labelMarcaCarro.Name = "labelMarcaCarro";
            this.labelMarcaCarro.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaCarro.TabIndex = 3;
            this.labelMarcaCarro.Text = "Marca";
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
            // labelModeloCarro
            // 
            this.labelModeloCarro.AutoSize = true;
            this.labelModeloCarro.Location = new System.Drawing.Point(136, 87);
            this.labelModeloCarro.Name = "labelModeloCarro";
            this.labelModeloCarro.Size = new System.Drawing.Size(42, 13);
            this.labelModeloCarro.TabIndex = 3;
            this.labelModeloCarro.Text = "Modelo";
            // 
            // Form_GestaoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminarCarroVenda);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonAdicionarCarroVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_GestaoOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestaoOficina";
            this.Load += new System.EventHandler(this.GestaoOficina_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEliminarCarroVenda;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonAdicionarCarroVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.Button buttonEliminarParcela;
        private System.Windows.Forms.Button buttonAdicionarParcela;
        private System.Windows.Forms.TextBox textBoxValorParcela;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDescricaoParcela;
        private System.Windows.Forms.Button buttonFatura;
        private System.Windows.Forms.Button buttonEliminarServico;
        private System.Windows.Forms.Button buttonAdicionarServico;
        private System.Windows.Forms.ListBox listBoxServico;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelContactoCliente;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelDataEntrada;
        private System.Windows.Forms.Label labelTipoServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCombustivelCarro;
        private System.Windows.Forms.Label labelkilometragem;
        private System.Windows.Forms.Label labelmatricula;
        private System.Windows.Forms.Label labelChassisCarro;
        private System.Windows.Forms.Label labelKilometrosCarro;
        private System.Windows.Forms.Label labelMatriculaCarro;
        private System.Windows.Forms.Label labelchassis;
        private System.Windows.Forms.Label labelcombustivel;
        private System.Windows.Forms.Label labelMarcaCarro;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.Label labelmodelo;
        private System.Windows.Forms.Label labelModeloCarro;
    }
}