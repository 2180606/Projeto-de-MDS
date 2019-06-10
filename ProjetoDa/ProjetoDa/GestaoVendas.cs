using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class GestaoVendas : Form
    {
        private BaseDadosContainer container;
        public GestaoVendas(BaseDadosContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }
        
        
        
        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            AdicionarCarroVenda adicionarCarroVenda = new AdicionarCarroVenda(container);
            DialogResult dialogResult = adicionarCarroVenda.ShowDialog(this);
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                AtualizarListBoxCarros();
            }
        }
        private void AtualizarListBoxVendas()
        {
            listBoxVendasEfetuadas.DataSource = null;
            listBoxVendasEfetuadas.DataSource = container.Vendas.ToList();
        }
        private void AtualizarListBoxCarros()
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = container.Carros.OfType<CarroVenda>().ToList();
        }
        private void AtualizarListBoxClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList();
        }

        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {

            if (container.Carros.OfType<CarroVenda>().Count() == 0)
            {
                MessageBox.Show("Nao Existem Carros de Venda. Adicione um Carro de Venda!");
                return;
            }
            EliminarCarroVenda eliminarCarroVenda = new EliminarCarroVenda(container);
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
            AtualizarListBoxVendas();
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
                labelVendido.Text = carroSelecionado.Vendido.ToString();
            }

        }

        private void ButtonVenderCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = null;
            CarroVenda carroSelecionado;
            if (listBoxClientes.SelectedIndex != -1)
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            }
            else
            {
                MessageBox.Show("Selecione um Cliente.");
                return;
            }
            if (container.Carros.OfType<CarroVenda>().Count() == 0)
            {
                MessageBox.Show("Nao Existem Carros de Venda. Adicione um Carro de Venda!");
                return;
            }
            if(listBoxCarros.SelectedIndex!=-1)
            {
                carroSelecionado = (CarroVenda)listBoxCarros.SelectedItem;
            }
            else
            {
                MessageBox.Show("Selecione um Carro de Venda.");
                return;
            }
            if (carroSelecionado.Vendido == true)
            {
                MessageBox.Show("O Carro Selecionado já foi vendido!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxValor.Text))
            {
                MessageBox.Show("Preencha o Campo do Valor");
                textBoxValor.Select();
                return;
            }
            if (!decimal.TryParse(textBoxValor.Text, out decimal tempValor))
            {
                MessageBox.Show("Insira um numero no Valor.");
                textBoxValor.Select();
                return;
            }
            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um Estado para a Venda.");
                return;
            }
            DateTime dataVenda = dateTimePickerDia.Value.Date + dateTimePickerHora.Value.TimeOfDay;
            if (dataVenda.Date > DateTime.Now)
            {
                MessageBox.Show("Selecione uma data válida para a hora.");
                return;
            }
            Venda tempVenda = new Venda(dataVenda, tempValor, comboBoxEstado.Text,carroSelecionado);
            clienteSelecionado.Vendas.Add(tempVenda);
            carroSelecionado.Vendido = true;
            container.SaveChanges();
            AtualizarListBoxCarros();
            AtualizarListBoxVendas();

        }
        private void ButtonHoraDataAtual_Click(object sender, EventArgs e)
        {
            dateTimePickerDia.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTime.Now;
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
                AtualizarListBoxVendas();
            }

        }

        private void GestaoVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //container.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void ListBoxVendasEfetuadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            if (listBoxVendasEfetuadas.SelectedIndex != -1)
            {
                Venda vendaSelecionada = (Venda)listBoxVendasEfetuadas.SelectedItem;
                labelClienteVenda.Text = " Cliente: " + vendaSelecionada.Cliente.Nome;
                labelValorVenda.Text = "Valor: " + Convert.ToString(vendaSelecionada.Valor) + "€";
                labelEstadoVenda.Text = "Estado: " + vendaSelecionada.Estado;
                labelDataVenda.Text = "Data de Venda: " + Convert.ToString(vendaSelecionada.Data);
                labelCarroVenda.Text = "Carro de Venda:" + vendaSelecionada.CarroVenda.NumeroChassis + " " + vendaSelecionada.CarroVenda.Modelo;
                labelVendaVenda.Text = "Numero da Venda: " + vendaSelecionada.IdVenda;
            }
            
        }

        private void ButtonEditarVenda_Click(object sender, EventArgs e)
        {
            
            if (listBoxVendasEfetuadas.Items.Count > 0)
            {
                EditarVenda editarVenda = new EditarVenda(container);
                editarVenda.ShowDialog();
                AtualizarListBoxVendas();
            }
        }
        
    }
}
