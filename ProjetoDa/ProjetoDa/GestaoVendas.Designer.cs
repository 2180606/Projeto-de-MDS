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
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(243, 109);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(225, 329);
            this.listBoxCarros.TabIndex = 1;
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
            // GestaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEliminarCarroVenda);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonAdicionarCarroVenda);
            this.Name = "GestaoVendas";
            this.Text = "GestaoVendas";
            this.Load += new System.EventHandler(this.GestaoVendas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionarCarroVenda;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonEliminarCarroVenda;
    }
}