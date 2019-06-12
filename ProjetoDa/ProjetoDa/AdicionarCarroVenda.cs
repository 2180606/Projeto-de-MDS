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
    public partial class AdicionarCarroVenda : Form
    {
        private BaseDadosDAContainer container;
        public AdicionarCarroVenda(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumeroChassis.Text))
            {
                MessageBox.Show("Insira um Numero de Chassis");
                textBoxNumeroChassis.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMarcaVeiculo.Text))
            {
                MessageBox.Show("Insira a Marca do Veiculo");
                textBoxMarcaVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxModeloVeiculo.Text))
            {
                MessageBox.Show("Insira o Modelo do Veiculo");
                textBoxModeloVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxExtrasVeiculo.Text))
            {
                MessageBox.Show("Insira o/s Extra/s do Veiculo");
                textBoxExtrasVeiculo.Select();
                return;
            }
            foreach (CarroVenda carro in container.Carros.OfType<CarroVenda>())
            {
                if (textBoxNumeroChassis.Text == carro.NumeroChassis)
                {
                    MessageBox.Show("O numero de Chassis inserido já existe na base de dados!");
                    textBoxNumeroChassis.Select();
                    return;
                }
            }
            if (comboBoxCombustivelVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de Combustivel");
                comboBoxCombustivelVeiculo.Select();
                return;
            }
            CarroVenda tempCarroVenda = new CarroVenda(textBoxNumeroChassis.Text,textBoxMarcaVeiculo.Text,textBoxModeloVeiculo.Text,
                comboBoxCombustivelVeiculo.Text,textBoxExtrasVeiculo.Text,false);
            container.Carros.Add(tempCarroVenda);
            container.SaveChanges();
            MessageBox.Show("Carro adicionado com Sucesso");
            this.Close();
        }
    }
}
