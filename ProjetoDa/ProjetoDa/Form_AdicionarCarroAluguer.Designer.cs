﻿namespace ProjetoDa
{
    partial class Form_AdicionarCarroAluguer
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
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(238, 143);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(207, 43);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(17, 143);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(207, 43);
            this.buttonAdicionarVeiculo.TabIndex = 15;
            this.buttonAdicionarVeiculo.Text = "Adicionar Veículo";
            this.buttonAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.buttonAdicionarVeiculo.Click += new System.EventHandler(this.ButtonAdicionarVeiculo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Combustível do Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Matricula do Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo do Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca do Veículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
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
            this.comboBoxCombustivelVeiculo.Location = new System.Drawing.Point(146, 116);
            this.comboBoxCombustivelVeiculo.Name = "comboBoxCombustivelVeiculo";
            this.comboBoxCombustivelVeiculo.Size = new System.Drawing.Size(299, 21);
            this.comboBoxCombustivelVeiculo.TabIndex = 8;
            // 
            // textBoxMatriculaVeiculo
            // 
            this.textBoxMatriculaVeiculo.Location = new System.Drawing.Point(146, 90);
            this.textBoxMatriculaVeiculo.Name = "textBoxMatriculaVeiculo";
            this.textBoxMatriculaVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxMatriculaVeiculo.TabIndex = 4;
            // 
            // textBoxModeloVeiculo
            // 
            this.textBoxModeloVeiculo.Location = new System.Drawing.Point(146, 64);
            this.textBoxModeloVeiculo.Name = "textBoxModeloVeiculo";
            this.textBoxModeloVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxModeloVeiculo.TabIndex = 5;
            // 
            // textBoxMarcaVeiculo
            // 
            this.textBoxMarcaVeiculo.Location = new System.Drawing.Point(146, 38);
            this.textBoxMarcaVeiculo.Name = "textBoxMarcaVeiculo";
            this.textBoxMarcaVeiculo.Size = new System.Drawing.Size(299, 20);
            this.textBoxMarcaVeiculo.TabIndex = 6;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(146, 12);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(299, 20);
            this.textBoxNumeroChassis.TabIndex = 7;
            // 
            // AdicionarCarroAluguer
            // 
            this.AcceptButton = this.buttonAdicionarVeiculo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(462, 201);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCombustivelVeiculo);
            this.Controls.Add(this.textBoxMatriculaVeiculo);
            this.Controls.Add(this.textBoxModeloVeiculo);
            this.Controls.Add(this.textBoxMarcaVeiculo);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarCarroAluguer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCarroAluguer";
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
    }
}