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
                AtualizarListBoxes();
            }
        }
        private void AtualizarListBoxes()
        {
            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            listBoxCarros.DataSource = null;
            listBoxClientes.DataSource = null;
            listBoxVendasEfetuadas.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList<Cliente>();
            listBoxCarros.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();
            if(clienteSelecionado!=null)
                listBoxVendasEfetuadas.DataSource = clienteSelecionado.Vendas.ToList<Venda>();
        }
        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = eliminarCarroVenda.ShowDialog(this); ;
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                AtualizarListBoxes();
            }

        }

        private void GestaoVendas_Load(object sender, EventArgs e)
        {
            AtualizarListBoxes();
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
            DialogResult dialogResult;


            if (listBoxClientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                VenderCarro venderCarro = new VenderCarro(clienteSelecionado);

                dialogResult = venderCarro.ShowDialog();

            }
            else
            {
                dialogResult = DialogResult.Abort;
                MessageBox.Show("Escolha o Cliente ao qual pretende Vender um Carro.");
            }
            if ( dialogResult == DialogResult.Cancel || dialogResult == DialogResult.OK )
            {
                AtualizarListBoxes();
            }
        }
    }
}
