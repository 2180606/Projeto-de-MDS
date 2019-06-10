namespace ProjetoDa
{
    partial class EliminarCarroOficina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCombustivelCarro = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labelmatricula = new System.Windows.Forms.Label();
            this.labelChassisCarro = new System.Windows.Forms.Label();
            this.labelTotalCarro = new System.Windows.Forms.Label();
            this.labelMatriculaCarro = new System.Windows.Forms.Label();
            this.labelchassis = new System.Windows.Forms.Label();
            this.labelcombustivel = new System.Windows.Forms.Label();
            this.labelMarcaCarro = new System.Windows.Forms.Label();
            this.labelmarca = new System.Windows.Forms.Label();
            this.labelmodelo = new System.Windows.Forms.Label();
            this.labelModeloCarro = new System.Windows.Forms.Label();
            this.buttonEliminarCarro = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelkilometragem = new System.Windows.Forms.Label();
            this.labelKilometrosCarro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(249, 212);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(267, 12);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(249, 212);
            this.listBoxCarros.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCombustivelCarro);
            this.groupBox1.Controls.Add(this.labelkilometragem);
            this.groupBox1.Controls.Add(this.labeltotal);
            this.groupBox1.Controls.Add(this.labelmatricula);
            this.groupBox1.Controls.Add(this.labelChassisCarro);
            this.groupBox1.Controls.Add(this.labelKilometrosCarro);
            this.groupBox1.Controls.Add(this.labelTotalCarro);
            this.groupBox1.Controls.Add(this.labelMatriculaCarro);
            this.groupBox1.Controls.Add(this.labelchassis);
            this.groupBox1.Controls.Add(this.labelcombustivel);
            this.groupBox1.Controls.Add(this.labelMarcaCarro);
            this.groupBox1.Controls.Add(this.labelmarca);
            this.groupBox1.Controls.Add(this.labelmodelo);
            this.groupBox1.Controls.Add(this.labelModeloCarro);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 141);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro Selecionado";
            // 
            // labelCombustivelCarro
            // 
            this.labelCombustivelCarro.AutoSize = true;
            this.labelCombustivelCarro.Location = new System.Drawing.Point(355, 29);
            this.labelCombustivelCarro.Name = "labelCombustivelCarro";
            this.labelCombustivelCarro.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivelCarro.TabIndex = 3;
            this.labelCombustivelCarro.Text = "Combustivel";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(272, 87);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(77, 13);
            this.labeltotal.TabIndex = 3;
            this.labeltotal.Text = "Total do Carro:";
            // 
            // labelmatricula
            // 
            this.labelmatricula.AutoSize = true;
            this.labelmatricula.Location = new System.Drawing.Point(272, 57);
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
            // labelTotalCarro
            // 
            this.labelTotalCarro.AutoSize = true;
            this.labelTotalCarro.Location = new System.Drawing.Point(355, 87);
            this.labelTotalCarro.Name = "labelTotalCarro";
            this.labelTotalCarro.Size = new System.Drawing.Size(31, 13);
            this.labelTotalCarro.TabIndex = 3;
            this.labelTotalCarro.Text = "Total";
            // 
            // labelMatriculaCarro
            // 
            this.labelMatriculaCarro.AutoSize = true;
            this.labelMatriculaCarro.Location = new System.Drawing.Point(355, 57);
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
            this.labelcombustivel.Location = new System.Drawing.Point(272, 29);
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
            // buttonEliminarCarro
            // 
            this.buttonEliminarCarro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEliminarCarro.Location = new System.Drawing.Point(13, 377);
            this.buttonEliminarCarro.Name = "buttonEliminarCarro";
            this.buttonEliminarCarro.Size = new System.Drawing.Size(249, 44);
            this.buttonEliminarCarro.TabIndex = 24;
            this.buttonEliminarCarro.Text = "Eliminar Carro Selecionado";
            this.buttonEliminarCarro.UseVisualStyleBackColor = true;
            this.buttonEliminarCarro.Click += new System.EventHandler(this.ButtonEliminarCarro_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(268, 377);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(249, 44);
            this.buttonSair.TabIndex = 24;
            this.buttonSair.Text = "Cancelar";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // labelkilometragem
            // 
            this.labelkilometragem.AutoSize = true;
            this.labelkilometragem.Location = new System.Drawing.Point(14, 114);
            this.labelkilometragem.Name = "labelkilometragem";
            this.labelkilometragem.Size = new System.Drawing.Size(116, 13);
            this.labelkilometragem.TabIndex = 3;
            this.labelkilometragem.Text = "Kilometragem do Carro:";
            // 
            // labelKilometrosCarro
            // 
            this.labelKilometrosCarro.AutoSize = true;
            this.labelKilometrosCarro.Location = new System.Drawing.Point(136, 114);
            this.labelKilometrosCarro.Name = "labelKilometrosCarro";
            this.labelKilometrosCarro.Size = new System.Drawing.Size(54, 13);
            this.labelKilometrosCarro.TabIndex = 3;
            this.labelKilometrosCarro.Text = "kilometros";
            // 
            // EliminarCarroOficina
            // 
            this.AcceptButton = this.buttonEliminarCarro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(529, 433);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEliminarCarro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCarroOficina";
            this.ShowInTaskbar = false;
            this.Text = "EliminarCarroOficina";
            this.Load += new System.EventHandler(this.EliminarCarroOficina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCombustivelCarro;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labelmatricula;
        private System.Windows.Forms.Label labelChassisCarro;
        private System.Windows.Forms.Label labelTotalCarro;
        private System.Windows.Forms.Label labelMatriculaCarro;
        private System.Windows.Forms.Label labelchassis;
        private System.Windows.Forms.Label labelcombustivel;
        private System.Windows.Forms.Label labelMarcaCarro;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.Label labelmodelo;
        private System.Windows.Forms.Label labelModeloCarro;
        private System.Windows.Forms.Button buttonEliminarCarro;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelkilometragem;
        private System.Windows.Forms.Label labelKilometrosCarro;
    }
}