using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class RealStand : Form
    {
        private BaseDadosContainer container;
        GestaoClientes gestaoClientes = new GestaoClientes();
        GestaoVendas gestaoVendas = new GestaoVendas();
        public RealStand()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
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
            if (container.Clientes.Count<Cliente>() != 0)
            {
                labelNClientes.Text = container.Clientes.Count<Cliente>().ToString();
                foreach (Cliente cliente in container.Clientes)
                {
                    vendas += cliente.Vendas.Count();
                }
                foreach (Cliente cliente in container.Clientes)
                {
                    foreach (Aluguer aluguer in cliente.Alugueres)
                    {
                        alugueres += cliente.Vendas.Count();
                    }
                }
                foreach (Cliente cliente in container.Clientes)
                {

                    foreach (CarroOficina carroOficina in cliente.CarrosOficina)
                    {
                        reparacoes += carroOficina.Servicos.Count();
                    }
                }
                labelNAluguer.Text = Convert.ToString(alugueres);
                labelNVendas.Text = Convert.ToString(vendas);
                labelNOficina.Text = Convert.ToString(reparacoes);
            }

        }

        private void ButtonGestaoClientes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = gestaoClientes.ShowDialog(this);
        }

        private void ButtonGestaoVendas_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = gestaoVendas.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
            {
                MessageBox.Show("Algo correu mal.");
            }
        }

        private void RealStand_FormClosing(object sender, FormClosingEventArgs e)
        {
            container.SaveChanges();
            container.Dispose();
        }
    }
}
