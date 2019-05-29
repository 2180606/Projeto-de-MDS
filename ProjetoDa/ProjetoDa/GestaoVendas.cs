using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class GestaoVendas : Form
    {
        private BaseDadosContainer container;
        public GestaoVendas()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }
        AdicionarCarroVenda adicionarCarroVenda = new AdicionarCarroVenda();
        EliminarCarroVenda eliminarCarroVenda = new EliminarCarroVenda();
        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = adicionarCarroVenda.ShowDialog(this);
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                AtualizarListBoxCarros();
            }
        }
        private void AtualizarListBoxVendas(Cliente clienteSelecionado)
        {
            listBoxVendasEfetuadas.DataSource = null;
            listBoxVendasEfetuadas.DataSource = clienteSelecionado.Vendas.ToList<Venda>();
        }
        private void AtualizarListBoxCarros()
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();
        }
        private void AtualizarListBoxClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList<Cliente>();
        }

        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            if (container.Carros.OfType<CarroVenda>().Count<CarroVenda>() == 0)
            {
                MessageBox.Show("Nao Existem Carros de Venda. Adicione um Carro de Venda!");
                return;
            }
            DialogResult dialogResult = eliminarCarroVenda.ShowDialog(this); ;

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                AtualizarListBoxCarros();
            }

        }

        private void GestaoVendas_Load(object sender, EventArgs e)
        {
            AtualizarListBoxClientes();
            AtualizarListBoxCarros();
        }

        private void ListBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroVenda carroSelecionado;
            if (listBoxCarros.SelectedIndex != -1)
            {
                carroSelecionado = (CarroVenda)listBoxCarros.SelectedItem;
                labelChassisCarro.Text = carroSelecionado.NumeroChassis;
                labelCombustivelCarro.Text = carroSelecionado.Combustivel;
                labelExtrasCarro.Text = carroSelecionado.Extras;
                labelMarcaCarro.Text = carroSelecionado.Marca;
                labelModeloCarro.Text = carroSelecionado.Modelo;
            }

        }

        private void ButtonVenderCarro_Click(object sender, EventArgs e)
        {
            if (container.Carros.OfType<CarroVenda>().Count<CarroVenda>() == 0)
            {
                MessageBox.Show("Nao Existem Carros de Venda. Adicione um Carro de Venda!");
                return;
            }

            DialogResult dialogResult;
            Cliente clienteSelecionado = new Cliente();
            if (listBoxClientes.SelectedIndex != -1)
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                VenderCarro venderCarro = new VenderCarro(clienteSelecionado);
                dialogResult = venderCarro.ShowDialog();
            }
            else
            {
                dialogResult = DialogResult.Abort;
                MessageBox.Show("Escolha o Cliente ao qual pretende Vender um Carro.");
            }
            if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.OK)
            {
                AtualizarListBoxCarros();
                AtualizarListBoxVendas(clienteSelecionado);
            }
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
                AtualizarListBoxVendas(clienteSelecionado);
            }

        }

        private void GestaoVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //container.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}
