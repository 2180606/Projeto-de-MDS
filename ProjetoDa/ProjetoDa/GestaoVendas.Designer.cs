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
            this.buttonVenderCarro = new System.Windows.Forms.Button();
            this.listBoxVendasEfetuadas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdicionarCarroVenda
            // 
            this.buttonAdicionarCarroVenda.Location = new System.Drawing.Point(29, 27);
            this.buttonAdicionarCarroVenda.Name = "buttonAdicionarCarroVenda";
            this.buttonAdicionarCarroVenda.Size = new System.Drawing.Size(124, 59);
            this.buttonAdicionarCarroVenda.TabIndex = 0;
            this.buttonAdicionarCarroVenda.Text = "Adicionar Novo Carro Para Venda";
            this.buttonAdicionarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarroVenda.Click += new System.EventHandler(this.ButtonAdicionarCarroVenda_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 109);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(225, 329);
            this.listBoxClientes.TabIndex = 1;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(243, 108);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(225, 329);
            this.listBoxCarros.TabIndex = 1;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.ListBoxCarros_SelectedIndexChanged);
            // 
            // buttonEliminarCarroVenda
            // 
            this.buttonEliminarCarroVenda.Location = new System.Drawing.Point(185, 27);
            this.buttonEliminarCarroVenda.Name = "buttonEliminarCarroVenda";
            this.buttonEliminarCarroVenda.Size = new System.Drawing.Size(124, 59);
            this.buttonEliminarCarroVenda.TabIndex = 2;
            this.buttonEliminarCarroVenda.Text = "Eliminar Carro Para Venda";
            this.buttonEliminarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonEliminarCarroVenda.Click += new System.EventHandler(this.ButtonEliminarCarroVenda_Click);
            // 
            // labelChassisCarro
            // 
            this.labelChassisCarro.AutoSize = true;
            this.labelChassisCarro.Location = new System.Drawing.Point(165, 36);
            this.labelChassisCarro.Name = "labelChassisCarro";
            this.labelChassisCarro.Size = new System.Drawing.Size(43, 13);
            this.labelChassisCarro.TabIndex = 3;
            this.labelChassisCarro.Text = "Chassis";
            // 
            // labelMarcaCarro
            // 
            this.labelMarcaCarro.AutoSize = true;
            this.labelMarcaCarro.Location = new System.Drawing.Point(165, 64);
            this.labelMarcaCarro.Name = "labelMarcaCarro";
            this.labelMarcaCarro.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaCarro.TabIndex = 3;
            this.labelMarcaCarro.Text = "Marca";
            // 
            // labelModeloCarro
            // 
            this.labelModeloCarro.AutoSize = true;
            this.labelModeloCarro.Location = new System.Drawing.Point(165, 94);
            this.labelModeloCarro.Name = "labelModeloCarro";
            this.labelModeloCarro.Size = new System.Drawing.Size(42, 13);
            this.labelModeloCarro.TabIndex = 3;
            this.labelModeloCarro.Text = "Modelo";
            // 
            // labelCombustivelCarro
            // 
            this.labelCombustivelCarro.AutoSize = true;
            this.labelCombustivelCarro.Location = new System.Drawing.Point(165, 123);
            this.labelCombustivelCarro.Name = "labelCombustivelCarro";
            this.labelCombustivelCarro.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivelCarro.TabIndex = 3;
            this.labelCombustivelCarro.Text = "Combustivel";
            // 
            // labelExtrasCarro
            // 
            this.labelExtrasCarro.AutoSize = true;
            this.labelExtrasCarro.Location = new System.Drawing.Point(165, 151);
            this.labelExtrasCarro.Name = "labelExtrasCarro";
            this.labelExtrasCarro.Size = new System.Drawing.Size(36, 13);
            this.labelExtrasCarro.TabIndex = 3;
            this.labelExtrasCarro.Text = "Extras";
            // 
            // labelchassis
            // 
            this.labelchassis.AutoSize = true;
            this.labelchassis.Location = new System.Drawing.Point(18, 36);
            this.labelchassis.Name = "labelchassis";
            this.labelchassis.Size = new System.Drawing.Size(101, 13);
            this.labelchassis.TabIndex = 3;
            this.labelchassis.Text = "Numero de Chassis:";
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.Location = new System.Drawing.Point(18, 64);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(40, 13);
            this.labelmarca.TabIndex = 3;
            this.labelmarca.Text = "Marca:";
            // 
            // labelmodelo
            // 
            this.labelmodelo.AutoSize = true;
            this.labelmodelo.Location = new System.Drawing.Point(18, 94);
            this.labelmodelo.Name = "labelmodelo";
            this.labelmodelo.Size = new System.Drawing.Size(45, 13);
            this.labelmodelo.TabIndex = 3;
            this.labelmodelo.Text = "Modelo:";
            // 
            // labelcombustivel
            // 
            this.labelcombustivel.AutoSize = true;
            this.labelcombustivel.Location = new System.Drawing.Point(18, 123);
            this.labelcombustivel.Name = "labelcombustivel";
            this.labelcombustivel.Size = new System.Drawing.Size(69, 13);
            this.labelcombustivel.TabIndex = 3;
            this.labelcombustivel.Text = "Combustível:";
            // 
            // labelextras
            // 
            this.labelextras.AutoSize = true;
            this.labelextras.Location = new System.Drawing.Point(18, 151);
            this.labelextras.Name = "labelextras";
            this.labelextras.Size = new System.Drawing.Size(42, 13);
            this.labelextras.TabIndex = 3;
            this.labelextras.Text = "Extras :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCombustivelCarro);
            this.groupBox1.Controls.Add(this.labelextras);
            this.groupBox1.Controls.Add(this.labelChassisCarro);
            this.groupBox1.Controls.Add(this.labelExtrasCarro);
            this.groupBox1.Controls.Add(this.labelchassis);
            this.groupBox1.Controls.Add(this.labelcombustivel);
            this.groupBox1.Controls.Add(this.labelMarcaCarro);
            this.groupBox1.Controls.Add(this.labelmarca);
            this.groupBox1.Controls.Add(this.labelmodelo);
            this.groupBox1.Controls.Add(this.labelModeloCarro);
            this.groupBox1.Location = new System.Drawing.Point(474, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro Selecionado";
            // 
            // buttonVenderCarro
            // 
            this.buttonVenderCarro.Location = new System.Drawing.Point(344, 27);
            this.buttonVenderCarro.Name = "buttonVenderCarro";
            this.buttonVenderCarro.Size = new System.Drawing.Size(124, 59);
            this.buttonVenderCarro.TabIndex = 5;
            this.buttonVenderCarro.Text = "Vender Carro ao Cliente Selecionado";
            this.buttonVenderCarro.UseVisualStyleBackColor = true;
            this.buttonVenderCarro.Click += new System.EventHandler(this.ButtonVenderCarro_Click);
            // 
            // listBoxVendasEfetuadas
            // 
            this.listBoxVendasEfetuadas.FormattingEnabled = true;
            this.listBoxVendasEfetuadas.Location = new System.Drawing.Point(474, 316);
            this.listBoxVendasEfetuadas.Name = "listBoxVendasEfetuadas";
            this.listBoxVendasEfetuadas.Size = new System.Drawing.Size(313, 121);
            this.listBoxVendasEfetuadas.TabIndex = 6;
            // 
            // GestaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVendasEfetuadas);
            this.Controls.Add(this.buttonVenderCarro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminarCarroVenda);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonAdicionarCarroVenda);
            this.Name = "GestaoVendas";
            this.Text = "GestaoVendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoVendas_FormClosing);
            this.Load += new System.EventHandler(this.GestaoVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}