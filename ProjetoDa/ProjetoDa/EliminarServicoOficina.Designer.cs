namespace ProjetoDa
{
    partial class EliminarServicoOficina
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
            this.listBoxCarrosOficina = new System.Windows.Forms.ListBox();
            this.listBoxServico = new System.Windows.Forms.ListBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(346, 134);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(12, 152);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(346, 134);
            this.listBoxCarrosOficina.TabIndex = 0;
            this.listBoxCarrosOficina.SelectedIndexChanged += new System.EventHandler(this.ListBoxCarrosOficina_SelectedIndexChanged);
            // 
            // listBoxServico
            // 
            this.listBoxServico.FormattingEnabled = true;
            this.listBoxServico.Location = new System.Drawing.Point(12, 292);
            this.listBoxServico.Name = "listBoxServico";
            this.listBoxServico.Size = new System.Drawing.Size(346, 134);
            this.listBoxServico.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(12, 432);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(166, 37);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar Serviço";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(192, 432);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(166, 37);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // EliminarServicoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(373, 481);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.listBoxServico);
            this.Controls.Add(this.listBoxCarrosOficina);
            this.Controls.Add(this.listBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarServicoOficina";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarServicoOficina";
            this.Load += new System.EventHandler(this.EliminarServicoOficina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarrosOficina;
        private System.Windows.Forms.ListBox listBoxServico;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSair;
    }
}