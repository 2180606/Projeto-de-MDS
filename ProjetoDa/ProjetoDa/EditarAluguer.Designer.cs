namespace ProjetoDa
{
    partial class EditarAluguer
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
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelClienteVenda = new System.Windows.Forms.Label();
            this.labelAluguer = new System.Windows.Forms.Label();
            this.labelCarroVenda = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelDataAluguerInicio = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxCarro = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxAluguer = new System.Windows.Forms.TextBox();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownKms = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKms)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerInicio.Enabled = false;
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(143, 281);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(301, 20);
            this.dateTimePickerInicio.TabIndex = 33;
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(231, 371);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(213, 41);
            this.buttonSair.TabIndex = 30;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(12, 371);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(213, 41);
            this.buttonGuardar.TabIndex = 31;
            this.buttonGuardar.Text = "Guardar alterações";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // labelClienteVenda
            // 
            this.labelClienteVenda.AutoSize = true;
            this.labelClienteVenda.Location = new System.Drawing.Point(9, 237);
            this.labelClienteVenda.Name = "labelClienteVenda";
            this.labelClienteVenda.Size = new System.Drawing.Size(96, 13);
            this.labelClienteVenda.TabIndex = 24;
            this.labelClienteVenda.Text = "Cliente do Aluguer:";
            // 
            // labelAluguer
            // 
            this.labelAluguer.AutoSize = true;
            this.labelAluguer.Location = new System.Drawing.Point(9, 214);
            this.labelAluguer.Name = "labelAluguer";
            this.labelAluguer.Size = new System.Drawing.Size(46, 13);
            this.labelAluguer.TabIndex = 25;
            this.labelAluguer.Text = "Aluguer:";
            // 
            // labelCarroVenda
            // 
            this.labelCarroVenda.AutoSize = true;
            this.labelCarroVenda.Location = new System.Drawing.Point(9, 260);
            this.labelCarroVenda.Name = "labelCarroVenda";
            this.labelCarroVenda.Size = new System.Drawing.Size(77, 13);
            this.labelCarroVenda.TabIndex = 26;
            this.labelCarroVenda.Text = "Carro Alugado:";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Location = new System.Drawing.Point(9, 328);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(88, 13);
            this.labelValorVenda.TabIndex = 28;
            this.labelValorVenda.Text = "Valor do Aluguer:";
            // 
            // labelDataAluguerInicio
            // 
            this.labelDataAluguerInicio.AutoSize = true;
            this.labelDataAluguerInicio.Location = new System.Drawing.Point(9, 284);
            this.labelDataAluguerInicio.Name = "labelDataAluguerInicio";
            this.labelDataAluguerInicio.Size = new System.Drawing.Size(130, 13);
            this.labelDataAluguerInicio.TabIndex = 29;
            this.labelDataAluguerInicio.Text = "Data de Inicio do Aluguer:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(143, 325);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(301, 20);
            this.textBoxValor.TabIndex = 20;
            // 
            // textBoxCarro
            // 
            this.textBoxCarro.Location = new System.Drawing.Point(143, 257);
            this.textBoxCarro.Name = "textBoxCarro";
            this.textBoxCarro.ReadOnly = true;
            this.textBoxCarro.Size = new System.Drawing.Size(301, 20);
            this.textBoxCarro.TabIndex = 21;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(143, 234);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(301, 20);
            this.textBoxCliente.TabIndex = 22;
            this.textBoxCliente.TabStop = false;
            // 
            // textBoxAluguer
            // 
            this.textBoxAluguer.Location = new System.Drawing.Point(143, 211);
            this.textBoxAluguer.Name = "textBoxAluguer";
            this.textBoxAluguer.ReadOnly = true;
            this.textBoxAluguer.Size = new System.Drawing.Size(301, 20);
            this.textBoxAluguer.TabIndex = 23;
            this.textBoxAluguer.TabStop = false;
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(12, 12);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(432, 186);
            this.listBoxAlugueres.TabIndex = 19;
            this.listBoxAlugueres.SelectedIndexChanged += new System.EventHandler(this.ListBoxAlugueres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data de Fim do Aluguer:";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFim.Enabled = false;
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFim.Location = new System.Drawing.Point(143, 303);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(301, 20);
            this.dateTimePickerFim.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kilometros Percorridos:";
            // 
            // numericUpDownKms
            // 
            this.numericUpDownKms.Location = new System.Drawing.Point(143, 348);
            this.numericUpDownKms.Name = "numericUpDownKms";
            this.numericUpDownKms.Size = new System.Drawing.Size(301, 20);
            this.numericUpDownKms.TabIndex = 34;
            // 
            // EditarAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.Controls.Add(this.numericUpDownKms);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelClienteVenda);
            this.Controls.Add(this.labelAluguer);
            this.Controls.Add(this.labelCarroVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDataAluguerInicio);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxCarro);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxAluguer);
            this.Controls.Add(this.listBoxAlugueres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarAluguer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarAluguer";
            this.Load += new System.EventHandler(this.EditarAluguer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelClienteVenda;
        private System.Windows.Forms.Label labelAluguer;
        private System.Windows.Forms.Label labelCarroVenda;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelDataAluguerInicio;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxCarro;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxAluguer;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownKms;
    }
}