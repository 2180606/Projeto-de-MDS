namespace ProjetoDa
{
    partial class EditarVenda
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
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.labelClienteVenda = new System.Windows.Forms.Label();
            this.labelVendaVenda = new System.Windows.Forms.Label();
            this.labelCarroVenda = new System.Windows.Forms.Label();
            this.labelEstadoVenda = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelDataVenda = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxCarro = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDia = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.Location = new System.Drawing.Point(15, 12);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(473, 186);
            this.listBoxVendas.TabIndex = 0;
            this.listBoxVendas.SelectedIndexChanged += new System.EventHandler(this.ListBoxVendas_SelectedIndexChanged);
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(146, 211);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.ReadOnly = true;
            this.textBoxVenda.Size = new System.Drawing.Size(342, 20);
            this.textBoxVenda.TabIndex = 1;
            this.textBoxVenda.TabStop = false;
            // 
            // labelClienteVenda
            // 
            this.labelClienteVenda.AutoSize = true;
            this.labelClienteVenda.Location = new System.Drawing.Point(12, 237);
            this.labelClienteVenda.Name = "labelClienteVenda";
            this.labelClienteVenda.Size = new System.Drawing.Size(88, 13);
            this.labelClienteVenda.TabIndex = 4;
            this.labelClienteVenda.Text = "Cliente da Venda";
            // 
            // labelVendaVenda
            // 
            this.labelVendaVenda.AutoSize = true;
            this.labelVendaVenda.Location = new System.Drawing.Point(12, 214);
            this.labelVendaVenda.Name = "labelVendaVenda";
            this.labelVendaVenda.Size = new System.Drawing.Size(41, 13);
            this.labelVendaVenda.TabIndex = 5;
            this.labelVendaVenda.Text = "Venda:";
            // 
            // labelCarroVenda
            // 
            this.labelCarroVenda.AutoSize = true;
            this.labelCarroVenda.Location = new System.Drawing.Point(12, 260);
            this.labelCarroVenda.Name = "labelCarroVenda";
            this.labelCarroVenda.Size = new System.Drawing.Size(77, 13);
            this.labelCarroVenda.TabIndex = 6;
            this.labelCarroVenda.Text = "Carro Vendido:";
            // 
            // labelEstadoVenda
            // 
            this.labelEstadoVenda.AutoSize = true;
            this.labelEstadoVenda.Location = new System.Drawing.Point(12, 284);
            this.labelEstadoVenda.Name = "labelEstadoVenda";
            this.labelEstadoVenda.Size = new System.Drawing.Size(43, 13);
            this.labelEstadoVenda.TabIndex = 7;
            this.labelEstadoVenda.Text = "Estado:";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Location = new System.Drawing.Point(12, 331);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(87, 13);
            this.labelValorVenda.TabIndex = 8;
            this.labelValorVenda.Text = "Valor do Veiculo:";
            // 
            // labelDataVenda
            // 
            this.labelDataVenda.AutoSize = true;
            this.labelDataVenda.Location = new System.Drawing.Point(12, 308);
            this.labelDataVenda.Name = "labelDataVenda";
            this.labelDataVenda.Size = new System.Drawing.Size(82, 13);
            this.labelDataVenda.TabIndex = 9;
            this.labelDataVenda.Text = "Data da Venda:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(146, 234);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(342, 20);
            this.textBoxCliente.TabIndex = 1;
            this.textBoxCliente.TabStop = false;
            // 
            // textBoxCarro
            // 
            this.textBoxCarro.Location = new System.Drawing.Point(146, 257);
            this.textBoxCarro.Name = "textBoxCarro";
            this.textBoxCarro.ReadOnly = true;
            this.textBoxCarro.Size = new System.Drawing.Size(342, 20);
            this.textBoxCarro.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(146, 328);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(342, 20);
            this.textBoxValor.TabIndex = 1;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(146, 362);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(162, 41);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar alterações";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(326, 362);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(162, 41);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.CustomFormat = "hh:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(326, 305);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerHora.TabIndex = 16;
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(146, 305);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerDia.TabIndex = 17;
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
            "Concluída",
            "Cancelada"});
            this.comboBoxEstado.Location = new System.Drawing.Point(146, 281);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(342, 21);
            this.comboBoxEstado.TabIndex = 18;
            // 
            // EditarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(505, 415);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerDia);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelClienteVenda);
            this.Controls.Add(this.labelVendaVenda);
            this.Controls.Add(this.labelCarroVenda);
            this.Controls.Add(this.labelEstadoVenda);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.labelDataVenda);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxCarro);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxVenda);
            this.Controls.Add(this.listBoxVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarVenda";
            this.Load += new System.EventHandler(this.EditarVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label labelClienteVenda;
        private System.Windows.Forms.Label labelVendaVenda;
        private System.Windows.Forms.Label labelCarroVenda;
        private System.Windows.Forms.Label labelEstadoVenda;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelDataVenda;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxCarro;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerDia;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}