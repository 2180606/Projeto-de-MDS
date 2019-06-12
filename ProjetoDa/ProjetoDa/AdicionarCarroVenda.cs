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
            //verificacoes
            if (string.IsNullOrWhiteSpace(textBoxNumeroChassis.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxNumeroChassis.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMarcaVeiculo.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxMarcaVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxModeloVeiculo.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxModeloVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxExtrasVeiculo.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
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
                comboBoxCombustivelVeiculo.Select();
                return;
            }
            CarroVenda tempCarroVenda = new CarroVenda(textBoxNumeroChassis.Text,textBoxMarcaVeiculo.Text,textBoxModeloVeiculo.Text,
                comboBoxCombustivelVeiculo.Text,textBoxExtrasVeiculo.Text,false);
            container.Carros.Add(tempCarroVenda);
            /*comboBoxCombustivelVeiculo.SelectedIndex = -1;
            textBoxNumeroChassis.Clear();
            textBoxMarcaVeiculo.Clear();
            textBoxExtrasVeiculo.Clear();
            textBoxModeloVeiculo.Clear();*/
            container.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
