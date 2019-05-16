namespace ProjetoDa
{
    partial class Menus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menus));
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.buttonGestaoOficina = new System.Windows.Forms.Button();
            this.buttonGestaoVendas = new System.Windows.Forms.Button();
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoClientes.Image")));
            this.buttonGestaoClientes.Location = new System.Drawing.Point(35, 71);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(200, 200);
            this.buttonGestaoClientes.TabIndex = 0;
            this.buttonGestaoClientes.Text = "Gestão Clientes";
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = true;
            this.buttonGestaoClientes.Click += new System.EventHandler(this.ButtonGestaoClientes_Click);
            // 
            // buttonGestaoOficina
            // 
            this.buttonGestaoOficina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoOficina.Image")));
            this.buttonGestaoOficina.Location = new System.Drawing.Point(295, 71);
            this.buttonGestaoOficina.Name = "buttonGestaoOficina";
            this.buttonGestaoOficina.Size = new System.Drawing.Size(200, 200);
            this.buttonGestaoOficina.TabIndex = 0;
            this.buttonGestaoOficina.Text = "Gestão Oficina";
            this.buttonGestaoOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoOficina.UseVisualStyleBackColor = true;
            // 
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoVendas.Image")));
            this.buttonGestaoVendas.Location = new System.Drawing.Point(35, 302);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(200, 200);
            this.buttonGestaoVendas.TabIndex = 0;
            this.buttonGestaoVendas.Text = "Gestão Vendas";
            this.buttonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoVendas.UseVisualStyleBackColor = true;
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoAluguer.Image")));
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(295, 302);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(200, 200);
            this.buttonGestaoAluguer.TabIndex = 0;
            this.buttonGestaoAluguer.Text = "Gestão Aluguer";
            this.buttonGestaoAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoAluguer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha uma funcionalidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stand Automóvel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Button buttonGestaoOficina;
        private System.Windows.Forms.Button buttonGestaoVendas;
        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.Label label1;
    }
}

