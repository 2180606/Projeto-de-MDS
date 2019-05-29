using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class VenderCarro : Form
    {
        private BaseDadosContainer container;
        public Cliente clienteSelecionado;
        public VenderCarro(Cliente clienteSelecionado)
        {
            InitializeComponent();
            container = new BaseDadosContainer();
            this.clienteSelecionado = clienteSelecionado;
        }

        private void ButtonVenderCarro_Click(object sender, EventArgs e)
        {
            CarroVenda carroSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            if (carroSelecionado.Vendido)
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
            DateTime dataVenda = dateTimePickerDia.Value.Date + dateTimePickerHora.Value.TimeOfDay;

            if (dataVenda.Date > DateTime.Now)
            {
                MessageBox.Show("Selecione uma data válida(Não posterior à hora atual!!)");
                return;
            }
            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um Estado para a Venda.");
                return;
            }
            Venda tempVenda = new Venda(Data: dataVenda, Valor: tempValor, Estado: comboBoxEstado.Text, carroSelecionado: carroSelecionado);
            carroSelecionado.Vendido = true;
            clienteSelecionado.Vendas.Add(tempVenda);
            container.SaveChanges();
            AtualizarListBoxes();

        }

        private void VenderCarro_Load(object sender, EventArgs e)
        {
            labelNomeCliente.Text = clienteSelecionado.Nome;
            AtualizarListBoxes();
        }


        private void AtualizarListBoxes()
        {
            listBoxCarrosVenda.DataSource = null;
            listBoxVendas.DataSource = null;
            listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList<Venda>();
            listBoxCarrosVenda.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();

        }
        private void ButtonHoraDataAtual_Click(object sender, EventArgs e)
        {
            dateTimePickerDia.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTime.Now;
        }

        private void VenderCarro_FormClosing(object sender, FormClosingEventArgs e)
        {
            container.SaveChanges();
        }
    }
}
