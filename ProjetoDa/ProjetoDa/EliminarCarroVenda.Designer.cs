namespace ProjetoDa
{
    partial class EliminarCarroVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCarrosVenda
            // 
            this.listBoxCarrosVenda.FormattingEnabled = true;
            this.listBoxCarrosVenda.Location = new System.Drawing.Point(12, 23);
            this.listBoxCarrosVenda.Name = "listBoxCarrosVenda";
            this.listBoxCarrosVenda.Size = new System.Drawing.Size(299, 264);
            this.listBoxCarrosVenda.TabIndex = 0;
            this.listBoxCarrosVenda.SelectedIndexChanged += new System.EventHandler(this.ListBoxCarrosVenda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Carro que Pretende Eliminar";
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(12, 306);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(299, 20);
            this.textBoxNumeroChassis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduza o Numero do Chassis do Carro que pretende Eliminar";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(12, 332);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(146, 50);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar Carro";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(164, 332);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(147, 50);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // EliminarCarroVenda
            // 
            this.AcceptButton = this.buttonEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(322, 394);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCarrosVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCarroVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCarroVenda";
            this.Load += new System.EventHandler(this.EliminarCarroVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarrosVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}