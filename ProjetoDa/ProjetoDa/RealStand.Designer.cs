namespace ProjetoDa
{
    partial class RealStand
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealStand));
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.buttonGestaoVendas = new System.Windows.Forms.Button();
            this.buttonGestaoOficina = new System.Windows.Forms.Button();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.labelData = new System.Windows.Forms.Label();
            this.labelTotalVendas = new System.Windows.Forms.Label();
            this.labelTotalAlugados = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelNAluguer = new System.Windows.Forms.Label();
            this.labelNVendas = new System.Windows.Forms.Label();
            this.labelNClientes = new System.Windows.Forms.Label();
            this.labelOficina = new System.Windows.Forms.Label();
            this.labelNOficina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoAluguer.BackColor = System.Drawing.Color.Transparent;
            this.buttonGestaoAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoAluguer.Image")));
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(637, 335);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(199, 177);
            this.buttonGestaoAluguer.TabIndex = 1;
            this.buttonGestaoAluguer.Text = "Gestão Aluguer";
            this.buttonGestaoAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoAluguer.UseVisualStyleBackColor = false;
            this.buttonGestaoAluguer.Click += new System.EventHandler(this.ButtonGestaoAluguer_Click);
            // 
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoVendas.BackColor = System.Drawing.Color.Transparent;
            this.buttonGestaoVendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGestaoVendas.BackgroundImage")));
            this.buttonGestaoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoVendas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoVendas.ImageKey = "(none)";
            this.buttonGestaoVendas.Location = new System.Drawing.Point(35, 335);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(199, 177);
            this.buttonGestaoVendas.TabIndex = 2;
            this.buttonGestaoVendas.Text = "Gestão Vendas";
            this.buttonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoVendas.UseVisualStyleBackColor = false;
            this.buttonGestaoVendas.Click += new System.EventHandler(this.ButtonGestaoVendas_Click);
            // 
            // buttonGestaoOficina
            // 
            this.buttonGestaoOficina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoOficina.BackColor = System.Drawing.Color.Transparent;
            this.buttonGestaoOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoOficina.Image")));
            this.buttonGestaoOficina.Location = new System.Drawing.Point(342, 335);
            this.buttonGestaoOficina.Name = "buttonGestaoOficina";
            this.buttonGestaoOficina.Size = new System.Drawing.Size(199, 177);
            this.buttonGestaoOficina.TabIndex = 3;
            this.buttonGestaoOficina.Text = "Gestão Oficina";
            this.buttonGestaoOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoOficina.UseVisualStyleBackColor = false;
            this.buttonGestaoOficina.Click += new System.EventHandler(this.ButtonGestaoOficina_Click);
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGestaoClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGestaoClientes.BackColor = System.Drawing.Color.Transparent;
            this.buttonGestaoClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGestaoClientes.BackgroundImage")));
            this.buttonGestaoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGestaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoClientes.Location = new System.Drawing.Point(35, 32);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(199, 177);
            this.buttonGestaoClientes.TabIndex = 4;
            this.buttonGestaoClientes.Text = "Gestão Clientes";
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = false;
            this.buttonGestaoClientes.Click += new System.EventHandler(this.ButtonGestaoClientes_Click);
            // 
            // timerData
            // 
            this.timerData.Interval = 1000;
            this.timerData.Tick += new System.EventHandler(this.TimerData_Tick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(649, 64);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(97, 20);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Dta e Hora";
            // 
            // labelTotalVendas
            // 
            this.labelTotalVendas.AutoSize = true;
            this.labelTotalVendas.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVendas.Location = new System.Drawing.Point(649, 125);
            this.labelTotalVendas.Name = "labelTotalVendas";
            this.labelTotalVendas.Size = new System.Drawing.Size(145, 20);
            this.labelTotalVendas.TabIndex = 5;
            this.labelTotalVendas.Text = "Total de Vendas:";
            // 
            // labelTotalAlugados
            // 
            this.labelTotalAlugados.AutoSize = true;
            this.labelTotalAlugados.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAlugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAlugados.Location = new System.Drawing.Point(649, 157);
            this.labelTotalAlugados.Name = "labelTotalAlugados";
            this.labelTotalAlugados.Size = new System.Drawing.Size(159, 20);
            this.labelTotalAlugados.TabIndex = 5;
            this.labelTotalAlugados.Text = "Total de Alugados:";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(649, 94);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(84, 20);
            this.labelClientes.TabIndex = 5;
            this.labelClientes.Text = "Clientes: ";
            // 
            // labelNAluguer
            // 
            this.labelNAluguer.AutoSize = true;
            this.labelNAluguer.BackColor = System.Drawing.Color.Transparent;
            this.labelNAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNAluguer.Location = new System.Drawing.Point(803, 158);
            this.labelNAluguer.Name = "labelNAluguer";
            this.labelNAluguer.Size = new System.Drawing.Size(19, 20);
            this.labelNAluguer.TabIndex = 5;
            this.labelNAluguer.Text = "0";
            // 
            // labelNVendas
            // 
            this.labelNVendas.AutoSize = true;
            this.labelNVendas.BackColor = System.Drawing.Color.Transparent;
            this.labelNVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNVendas.Location = new System.Drawing.Point(803, 126);
            this.labelNVendas.Name = "labelNVendas";
            this.labelNVendas.Size = new System.Drawing.Size(19, 20);
            this.labelNVendas.TabIndex = 5;
            this.labelNVendas.Text = "0";
            // 
            // labelNClientes
            // 
            this.labelNClientes.AutoSize = true;
            this.labelNClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelNClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNClientes.Location = new System.Drawing.Point(803, 95);
            this.labelNClientes.Name = "labelNClientes";
            this.labelNClientes.Size = new System.Drawing.Size(19, 20);
            this.labelNClientes.TabIndex = 5;
            this.labelNClientes.Text = "0";
            // 
            // labelOficina
            // 
            this.labelOficina.AutoSize = true;
            this.labelOficina.BackColor = System.Drawing.Color.Transparent;
            this.labelOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOficina.Location = new System.Drawing.Point(649, 189);
            this.labelOficina.Name = "labelOficina";
            this.labelOficina.Size = new System.Drawing.Size(156, 20);
            this.labelOficina.TabIndex = 5;
            this.labelOficina.Text = "Total Reparações:";
            // 
            // labelNOficina
            // 
            this.labelNOficina.AutoSize = true;
            this.labelNOficina.BackColor = System.Drawing.Color.Transparent;
            this.labelNOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOficina.Location = new System.Drawing.Point(803, 190);
            this.labelNOficina.Name = "labelNOficina";
            this.labelNOficina.Size = new System.Drawing.Size(19, 20);
            this.labelNOficina.TabIndex = 5;
            this.labelNOficina.Text = "0";
            // 
            // RealStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.labelNClientes);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.labelNVendas);
            this.Controls.Add(this.labelTotalVendas);
            this.Controls.Add(this.labelNOficina);
            this.Controls.Add(this.labelNAluguer);
            this.Controls.Add(this.labelOficina);
            this.Controls.Add(this.labelTotalAlugados);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RealStand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.RealStand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.Button buttonGestaoVendas;
        private System.Windows.Forms.Button buttonGestaoOficina;
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTotalVendas;
        private System.Windows.Forms.Label labelTotalAlugados;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelNAluguer;
        private System.Windows.Forms.Label labelNVendas;
        private System.Windows.Forms.Label labelNClientes;
        private System.Windows.Forms.Label labelOficina;
        private System.Windows.Forms.Label labelNOficina;
    }
}