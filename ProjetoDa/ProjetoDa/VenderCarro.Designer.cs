namespace ProjetoDa
{
    partial class VenderCarro
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
            this.listBoxCarrosVenda = new System.Windows.Forms.ListBox();
            this.buttonVenderCarro = new System.Windows.Forms.Button();
            this.labelClienteText = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDia = new System.Windows.Forms.DateTimePicker();
            this.buttonHoraDataAtual = new System.Windows.Forms.Button();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.buttonSairForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCarrosVenda
            // 
            this.listBoxCarrosVenda.FormattingEnabled = true;
            this.listBoxCarrosVenda.Location = new System.Drawing.Point(12, 41);
            this.listBoxCarrosVenda.Name = "listBoxCarrosVenda";
            this.listBoxCarrosVenda.Size = new System.Drawing.Size(218, 394);
            this.listBoxCarrosVenda.TabIndex = 0;
            // 
            // buttonVenderCarro
            // 
            this.buttonVenderCarro.Location = new System.Drawing.Point(259, 252);
            this.buttonVenderCarro.Name = "buttonVenderCarro";
            this.buttonVenderCarro.Size = new System.Drawing.Size(218, 56);
            this.buttonVenderCarro.TabIndex = 1;
            this.buttonVenderCarro.Text = "Vender Carro Selecionado";
            this.buttonVenderCarro.UseVisualStyleBackColor = true;
            this.buttonVenderCarro.Click += new System.EventHandler(this.ButtonVenderCarro_Click);
            // 
            // labelClienteText
            // 
            this.labelClienteText.AutoSize = true;
            this.labelClienteText.Location = new System.Drawing.Point(9, 9);
            this.labelClienteText.Name = "labelClienteText";
            this.labelClienteText.Size = new System.Drawing.Size(213, 13);
            this.labelClienteText.TabIndex = 2;
            this.labelClienteText.Text = "Selecione um carro para vender ao cliente :";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(9, 22);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(71, 16);
            this.labelNomeCliente.TabIndex = 3;
            this.labelNomeCliente.Text = "CLIENTE";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(408, 34);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(380, 20);
            this.textBoxValor.TabIndex = 4;
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
            this.comboBoxEstado.Location = new System.Drawing.Point(408, 70);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(380, 21);
            this.comboBoxEstado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Indique o Valor do Veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Indique o Estado da Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indique a Data da Venda:";
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(408, 105);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDia.TabIndex = 7;
            // 
            // buttonHoraDataAtual
            // 
            this.buttonHoraDataAtual.Location = new System.Drawing.Point(636, 105);
            this.buttonHoraDataAtual.Name = "buttonHoraDataAtual";
            this.buttonHoraDataAtual.Size = new System.Drawing.Size(152, 20);
            this.buttonHoraDataAtual.TabIndex = 8;
            this.buttonHoraDataAtual.Text = "Data e Hora Atuais";
            this.buttonHoraDataAtual.UseVisualStyleBackColor = true;
            this.buttonHoraDataAtual.Click += new System.EventHandler(this.ButtonHoraDataAtual_Click);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.CustomFormat = "hh:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(535, 105);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerHora.TabIndex = 7;
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.Location = new System.Drawing.Point(259, 314);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(529, 121);
            this.listBoxVendas.TabIndex = 9;
            // 
            // buttonSairForm
            // 
            this.buttonSairForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSairForm.Location = new System.Drawing.Point(570, 252);
            this.buttonSairForm.Name = "buttonSairForm";
            this.buttonSairForm.Size = new System.Drawing.Size(218, 56);
            this.buttonSairForm.TabIndex = 1;
            this.buttonSairForm.Text = "Sair";
            this.buttonSairForm.UseVisualStyleBackColor = true;
            // 
            // VenderCarro
            // 
            this.AcceptButton = this.buttonVenderCarro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSairForm;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVendas);
            this.Controls.Add(this.buttonHoraDataAtual);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelClienteText);
            this.Controls.Add(this.buttonSairForm);
            this.Controls.Add(this.buttonVenderCarro);
            this.Controls.Add(this.listBoxCarrosVenda);
            this.Name = "VenderCarro";
            this.Text = "VenderCarro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VenderCarro_FormClosing);
            this.Load += new System.EventHandler(this.VenderCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarrosVenda;
        private System.Windows.Forms.Button buttonVenderCarro;
        private System.Windows.Forms.Label labelClienteText;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDia;
        private System.Windows.Forms.Button buttonHoraDataAtual;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.Button buttonSairForm;
    }
}