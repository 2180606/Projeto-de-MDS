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
            CarroVenda carroSelecionado = new CarroVenda();
            carroSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            Venda tempVenda = new Venda();
            if (string.IsNullOrWhiteSpace(textBoxValor.Text))
            {
                MessageBox.Show("Preencha o Campo do Valor");
                return;
            }

            if (decimal.TryParse(textBoxValor.Text, out decimal tempValor))
            {
                tempVenda.Valor = tempValor;
            }
            else
            {
                MessageBox.Show("Insira um numero no Valor.");
                textBoxValor.Select();
                return;
            }
            tempVenda.Cliente = clienteSelecionado;

            
            DateTime dataVenda = dateTimePickerDia.Value.Date + dateTimePickerHora.Value.TimeOfDay;
            if (dataVenda.Date > DateTime.Now)
            {
                MessageBox.Show("Selecione uma data valida(nao posterior a atual)");
                return;
            }
            tempVenda.Data = dataVenda;
            if (comboBoxEstado.SelectedIndex != -1)
                tempVenda.Estado = comboBoxEstado.Text;
            else
            {
                MessageBox.Show("Escolha um Estado para a Venda.");
                return;
            }
            tempVenda.CarroVenda = carroSelecionado;
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


    }
}
