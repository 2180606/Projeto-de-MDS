namespace ProjetoDa
{
    partial class Form_AdicionarServicoOficina
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
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Adid = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoServico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCarroSelecionado = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.buttonAdicionarServico = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.Adid.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 25);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(213, 199);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(234, 25);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(213, 199);
            this.listBoxCarros.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selecione um Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecione um Carro de Oficina:";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(6, 73);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerEntrada.TabIndex = 15;
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Location = new System.Drawing.Point(219, 73);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerSaida.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data de Entrada:";
            // 
            // Adid
            // 
            this.Adid.Controls.Add(this.buttonSair);
            this.Adid.Controls.Add(this.buttonAdicionarServico);
            this.Adid.Controls.Add(this.labelClienteSelecionado);
            this.Adid.Controls.Add(this.labelCarroSelecionado);
            this.Adid.Controls.Add(this.comboBoxTipoServico);
            this.Adid.Controls.Add(this.dateTimePickerSaida);
            this.Adid.Controls.Add(this.dateTimePickerEntrada);
            this.Adid.Controls.Add(this.label4);
            this.Adid.Controls.Add(this.label3);
            this.Adid.Controls.Add(this.label2);
            this.Adid.Location = new System.Drawing.Point(15, 232);
            this.Adid.Name = "Adid";
            this.Adid.Size = new System.Drawing.Size(432, 215);
            this.Adid.TabIndex = 16;
            this.Adid.TabStop = false;
            this.Adid.Text = "Adicionar Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Saida:";
            // 
            // comboBoxTipoServico
            // 
            this.comboBoxTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServico.FormattingEnabled = true;
            this.comboBoxTipoServico.Items.AddRange(new object[] {
            "Revisão Automóvel",
            "Inspeção Automóvel",
            "Diagnóstico Automóvel",
            "Pintura Automóvel",
            "Bate Chapas",
            "Alinhar Direção",
            "Mudar Pneus",
            "Calibrar Pneus",
            "Mudança de Óleo",
            "Iluminação Automóvel",
            "Verificação de Travões",
            "Mudança de Travões",
            "Verificação da Suspenão",
            "Mudança da Suspensão",
            "Lavagem do Automóvel",
            "Outros Serviços"});
            this.comboBoxTipoServico.Location = new System.Drawing.Point(6, 125);
            this.comboBoxTipoServico.Name = "comboBoxTipoServico";
            this.comboBoxTipoServico.Size = new System.Drawing.Size(204, 21);
            this.comboBoxTipoServico.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Serviço:";
            // 
            // labelCarroSelecionado
            // 
            this.labelCarroSelecionado.AutoSize = true;
            this.labelCarroSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarroSelecionado.Location = new System.Drawing.Point(216, 29);
            this.labelCarroSelecionado.Name = "labelCarroSelecionado";
            this.labelCarroSelecionado.Size = new System.Drawing.Size(154, 18);
            this.labelCarroSelecionado.TabIndex = 17;
            this.labelCarroSelecionado.Text = "Carro Selecionado:";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionado.Location = new System.Drawing.Point(3, 29);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(163, 18);
            this.labelClienteSelecionado.TabIndex = 17;
            this.labelClienteSelecionado.Text = "Cliente Selecionado:";
            // 
            // buttonAdicionarServico
            // 
            this.buttonAdicionarServico.Location = new System.Drawing.Point(6, 167);
            this.buttonAdicionarServico.Name = "buttonAdicionarServico";
            this.buttonAdicionarServico.Size = new System.Drawing.Size(204, 33);
            this.buttonAdicionarServico.TabIndex = 18;
            this.buttonAdicionarServico.Text = "Adicionar Serviço";
            this.buttonAdicionarServico.UseVisualStyleBackColor = true;
            this.buttonAdicionarServico.Click += new System.EventHandler(this.ButtonAdicionarServico_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(219, 167);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(207, 33);
            this.buttonSair.TabIndex = 18;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // AdicionarServicoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.Adid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarServicoOficina";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarServicoOficina";
            this.Load += new System.EventHandler(this.AdicionarServicoOficina_Load);
            this.Adid.ResumeLayout(false);
            this.Adid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Adid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAdicionarServico;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.Label labelCarroSelecionado;
        private System.Windows.Forms.ComboBox comboBoxTipoServico;
        private System.Windows.Forms.Label label4;
    }
}