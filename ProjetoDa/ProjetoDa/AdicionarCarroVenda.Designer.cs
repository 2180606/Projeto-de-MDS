﻿namespace ProjetoDa
{
    partial class AdicionarCarroVenda
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
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.textBoxModeloVeiculo = new System.Windows.Forms.TextBox();
            this.textBoxExtrasVeiculo = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelVeiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdicionarVeiculo = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(143, 55);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(299, 20);
            this.textBoxNumeroChassis.TabIndex = 0;
            // 
            // textBoxModeloVeiculo
            // 
            this.textBoxModeloVeiculo.Location = new System.Drawing.Point(143, 107);
            this.textBoxModeloVeiculo.Name = "textBoxModeloVeiculo";
            this.textBoxModeloVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxModeloVeiculo.TabIndex = 0;
            // 
            // textBoxExtrasVeiculo
            // 
            this.textBoxExtrasVeiculo.Location = new System.Drawing.Point(143, 133);
            this.textBoxExtrasVeiculo.Name = "textBoxExtrasVeiculo";
            this.textBoxExtrasVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxExtrasVeiculo.TabIndex = 0;
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
            this.comboBoxCombustivelVeiculo.Location = new System.Drawing.Point(143, 159);
            this.comboBoxCombustivelVeiculo.Name = "comboBoxCombustivelVeiculo";
            this.comboBoxCombustivelVeiculo.Size = new System.Drawing.Size(299, 21);
            this.comboBoxCombustivelVeiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero do Chassis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca do Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo do Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Extras do Veículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Combustível do Veículo:";
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(14, 217);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(130, 43);
            this.buttonAdicionarVeiculo.TabIndex = 3;
            this.buttonAdicionarVeiculo.Text = "Adicionar Veículo";
            this.buttonAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.buttonAdicionarVeiculo.Click += new System.EventHandler(this.ButtonAdicionarVeiculo_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(170, 217);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 43);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxMarcaVeiculo
            // 
            this.textBoxMarcaVeiculo.Location = new System.Drawing.Point(143, 81);
            this.textBoxMarcaVeiculo.Name = "textBoxMarcaVeiculo";
            this.textBoxMarcaVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxMarcaVeiculo.TabIndex = 0;
            // 
            // AdicionarCarroVenda
            // 
            this.AcceptButton = this.buttonAdicionarVeiculo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(463, 296);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCombustivelVeiculo);
            this.Controls.Add(this.textBoxExtrasVeiculo);
            this.Controls.Add(this.textBoxModeloVeiculo);
            this.Controls.Add(this.textBoxMarcaVeiculo);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Name = "AdicionarCarroVenda";
            this.Text = "AdicionarCarroVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.TextBox textBoxModeloVeiculo;
        private System.Windows.Forms.TextBox textBoxExtrasVeiculo;
        private System.Windows.Forms.ComboBox comboBoxCombustivelVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdicionarVeiculo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxMarcaVeiculo;
    }
}