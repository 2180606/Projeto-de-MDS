using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class AdicionarServicoOficina : Form
    {
        private BaseDadosContainer container;
        private Cliente clienteSelecionado;
        private CarroOficina carroSelecionado;
        public AdicionarServicoOficina(BaseDadosContainer containerImp,Cliente cliente,CarroOficina carroOficina)
        {
            InitializeComponent();
            container = containerImp;
            carroSelecionado = carroOficina;
            clienteSelecionado = cliente;
        }

        private void ButtonAdicionarServico_Click(object sender, EventArgs e)
        {
            if(dateTimePickerEntrada.Value > dateTimePickerSaida.Value)
            {
                MessageBox.Show("Selecione uma Data de Saida igual ou posterior à Data de Entrada");
                return;
            }
            if(dateTimePickerEntrada.Value > DateTime.Now)
            {
                MessageBox.Show("A data de Entrada não pode ser posterior à Data de Hoje");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxTipoServico.Text))
            {
                MessageBox.Show("Escolha um Tipo de Serviço.");
                return;
            }
            //clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico tempServico = new Servico(dateTimePickerEntrada.Value,comboBoxTipoServico.Text,dateTimePickerSaida.Value);
            carroSelecionado.Servicos.Add(tempServico);
            container.SaveChanges();
        }

        private void AdicionarServicoOficina_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = container.Clientes.ToList();
            listBoxClientes.SelectedItem = clienteSelecionado;
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            listBoxCarros.SelectedItem = carroSelecionado;
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListBoxCarros();
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            labelClienteSelecionado.Text = clienteSelecionado.Nome;
            if(listBoxCarros.SelectedIndex!=-1)
            {
                carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
                labelCarroSelecionado.Text = carroSelecionado.NumeroChassis;
            }
            else
            {
                labelCarroSelecionado.Text = "Sem Carro Selecionado";
            }
                
        }
        private void AtualizarListBoxCarros()
        {
            Cliente clienteSelecionado = null;
            if (listBoxClientes.SelectedIndex != -1)
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                if (clienteSelecionado.CarrosOficina.Count != 0)
                {
                    listBoxCarros.DataSource = null;
                    listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
                }
            }
        }
    }
}
