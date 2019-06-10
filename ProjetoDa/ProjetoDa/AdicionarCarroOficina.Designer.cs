namespace ProjetoDa
{
    partial class AdicionarCarroOficina
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAdicionarVeiculo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCombustivelVeiculo = new System.Windows.Forms.ComboBox();
            this.textBoxMatriculaVeiculo = new System.Windows.Forms.TextBox();
            this.textBoxModeloVeiculo = new System.Windows.Forms.TextBox();
            this.textBoxMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.labelKilometrosVeiculo = new System.Windows.Forms.Label();
            this.numericUpDownKilometros = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilometros)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(420, 194);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(171, 43);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(245, 194);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(171, 43);
            this.buttonAdicionarVeiculo.TabIndex = 15;
            this.buttonAdicionarVeiculo.Text = "Adicionar Veículo";
            this.buttonAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.buttonAdicionarVeiculo.Click += new System.EventHandler(this.ButtonAdicionarVeiculo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Combustível do Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Matricula do Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo do Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca do Veículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero do Chassis:";
            // 
            // comboBoxCombustivelVeiculo
            // 
            this.comboBoxCombustivelVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivelVeiculo.FormattingEnabled = true;
            this.comboBoxCombustivelVeiculo.Items.AddRange(new object[] {
            "Gasolina s/Chumbo 95",
            "Gasolina s/Chumbo 98",
            "Gasolina Aditivada",
            "Gasóleo Simples",
            "Gasóleo Aditivado",
            "Gás / GPL"});
            this.comboBoxCombustivelVeiculo.Location = new System.Drawing.Point(374, 130);
            this.comboBoxCombustivelVeiculo.Name = "comboBoxCombustivelVeiculo";
            this.comboBoxCombustivelVeiculo.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCombustivelVeiculo.TabIndex = 8;
            // 
            // textBoxMatriculaVeiculo
            // 
            this.textBoxMatriculaVeiculo.Location = new System.Drawing.Point(374, 98);
            this.textBoxMatriculaVeiculo.Name = "textBoxMatriculaVeiculo";
            this.textBoxMatriculaVeiculo.Size = new System.Drawing.Size(217, 20);
            this.textBoxMatriculaVeiculo.TabIndex = 4;
            // 
            // textBoxModeloVeiculo
            // 
            this.textBoxModeloVeiculo.Location = new System.Drawing.Point(374, 67);
            this.textBoxModeloVeiculo.Name = "textBoxModeloVeiculo";
            this.textBoxModeloVeiculo.Size = new System.Drawing.Size(217, 20);
            this.textBoxModeloVeiculo.TabIndex = 5;
            // 
            // textBoxMarcaVeiculo
            // 
            this.textBoxMarcaVeiculo.Location = new System.Drawing.Point(374, 38);
            this.textBoxMarcaVeiculo.Name = "textBoxMarcaVeiculo";
            this.textBoxMarcaVeiculo.Size = new System.Drawing.Size(217, 20);
            this.textBoxMarcaVeiculo.TabIndex = 6;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(374, 9);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(217, 20);
            this.textBoxNumeroChassis.TabIndex = 7;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 25);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(225, 212);
            this.listBoxClientes.TabIndex = 16;
            // 
            // labelKilometrosVeiculo
            // 
            this.labelKilometrosVeiculo.AutoSize = true;
            this.labelKilometrosVeiculo.Location = new System.Drawing.Point(243, 166);
            this.labelKilometrosVeiculo.Name = "labelKilometrosVeiculo";
            this.labelKilometrosVeiculo.Size = new System.Drawing.Size(128, 13);
            this.labelKilometrosVeiculo.TabIndex = 9;
            this.labelKilometrosVeiculo.Text = "Kilometragem do Veículo:";
            // 
            // numericUpDownKilometros
            // 
            this.numericUpDownKilometros.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKilometros.Location = new System.Drawing.Point(374, 164);
            this.numericUpDownKilometros.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDownKilometros.Name = "numericUpDownKilometros";
            this.numericUpDownKilometros.Size = new System.Drawing.Size(217, 20);
            this.numericUpDownKilometros.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione um Cliente:";
            // 
            // AdicionarCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(599, 250);
            this.Controls.Add(this.numericUpDownKilometros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.labelKilometrosVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCombustivelVeiculo);
            this.Controls.Add(this.textBoxMatriculaVeiculo);
            this.Controls.Add(this.textBoxModeloVeiculo);
            this.Controls.Add(this.textBoxMarcaVeiculo);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdicionarCarroOficina";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCarroOficina";
            this.Load += new System.EventHandler(this.AdicionarCarroOficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilometros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAdicionarVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCombustivelVeiculo;
        private System.Windows.Forms.TextBox textBoxMatriculaVeiculo;
        private System.Windows.Forms.TextBox textBoxModeloVeiculo;
        private System.Windows.Forms.TextBox textBoxMarcaVeiculo;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelKilometrosVeiculo;
        private System.Windows.Forms.NumericUpDown numericUpDownKilometros;
        private System.Windows.Forms.Label label6;
    }
}