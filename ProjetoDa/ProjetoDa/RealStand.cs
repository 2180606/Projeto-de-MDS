using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class RealStand : Form 
    {
        private BaseDadosDAContainer container;


        public RealStand()
        {
            InitializeComponent();
            container = new BaseDadosDAContainer();
            timerData.Start();
        }


        private void TimerData_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void RealStand_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            int vendas = 0, alugueres = 0, reparacoes = 0;
            labelData.Text = DateTime.Now.ToString();
            try
            {
                if (container.Clientes.Count() != 0)
                {
                    labelNClientes.Text = container.Clientes.Count().ToString();
                    foreach (Cliente cliente in container.Clientes)
                    {
                        foreach (Venda venda in cliente.Vendas)
                        {
                            vendas += cliente.Vendas.Count;
                        }
                    }
                    foreach (Cliente cliente in container.Clientes.ToList<Cliente>())
                    {
                        foreach (Aluguer aluguer in cliente.Alugueres.ToList<Aluguer>())
                        {
                            alugueres += cliente.Vendas.Count;
                        }
                    }
                    foreach (Cliente cliente in container.Clientes.ToList<Cliente>())
                    {
                        foreach (CarroOficina carroOficina in cliente.CarrosOficina.ToList<CarroOficina>())
                        {
                            reparacoes += carroOficina.Servicos.Count;
                        }
                    }
                    labelNAluguer.Text = Convert.ToString(alugueres);
                    labelNVendas.Text = Convert.ToString(vendas);
                    labelNOficina.Text = Convert.ToString(reparacoes);
                }
            }
            catch
            {
            }
        }

        private void ButtonGestaoClientes_Click(object sender, EventArgs e)
        {
            GestaoClientes gestaoClientes = new GestaoClientes(container);
            this.Hide();
            if (gestaoClientes.ShowDialog() == DialogResult.OK)
            {
            }
            this.Show();
        }

        private void ButtonGestaoVendas_Click(object sender, EventArgs e)
        {
            GestaoVendas gestaoVendas = new GestaoVendas(container);
            this.Hide();
            if (gestaoVendas.ShowDialog() == DialogResult.OK)
            {
            }
            this.Show();
        }


        private void ButtonGestaoOficina_Click(object sender, EventArgs e)
        {
            GestaoOficina gestaoOficina = new GestaoOficina(container);
            this.Hide();
            if (gestaoOficina.ShowDialog() == DialogResult.OK)
            {
            }
            this.Show();
        }

        private void ButtonGestaoAluguer_Click(object sender, EventArgs e)
        {
            GestaoAluguer gestaoAluguer = new GestaoAluguer(container);
            this.Hide();
            if (gestaoAluguer.ShowDialog() == DialogResult.OK)
            {
            }
            this.Show();
        }
    }
}
