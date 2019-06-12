using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class AdicionarCarroAluguer : Form
    {
        private BaseDadosDAContainer container;
        public AdicionarCarroAluguer(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumeroChassis.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                MessageBox.Show("Introduza o Numero de Chassis do Veiculo");
                textBoxNumeroChassis.Select();
                return;
            }
            foreach (CarroAluguer carro in container.Carros.OfType<CarroAluguer>())
            {
                if (carro.NumeroChassis == textBoxNumeroChassis.Text)
                {
                    MessageBox.Show("Já existe um carro de Aluguer com Este Numero de Chassis");
                    textBoxNumeroChassis.Select();
                    return;
                }
            }

            foreach (CarroOficina carro in container.Carros.OfType<CarroOficina>())
            {
                if (carro.NumeroChassis == textBoxNumeroChassis.Text)
                {
                    if (textBoxMarcaVeiculo.Text != carro.Marca || textBoxModeloVeiculo.Text != carro.Modelo || comboBoxCombustivelVeiculo.Text != carro.Combustivel)
                    {
                        if (MessageBox.Show("Já existe este Numero de Chassis nos carros de Oficina." +
                        "\n\t Pretende importar os dados do veiculo?" +
                        "\n (Irá eliminar quaisquer dados inseridos nesta janela)", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            textBoxMarcaVeiculo.Text = carro.Marca;
                            textBoxModeloVeiculo.Text = carro.Modelo;
                            textBoxNumeroChassis.Text = carro.NumeroChassis;
                            comboBoxCombustivelVeiculo.Text = carro.Combustivel;
                            textBoxMatriculaVeiculo.Text = null;
                            return;
                        }
                    }
                }
            }

            foreach (CarroVenda carro in container.Carros.OfType<CarroVenda>())
            {
                if (carro.NumeroChassis == textBoxNumeroChassis.Text && carro.Vendido == true)
                {
                    if (textBoxMarcaVeiculo.Text != carro.Marca || textBoxModeloVeiculo.Text != carro.Modelo || comboBoxCombustivelVeiculo.Text != carro.Combustivel)
                    {
                        if (MessageBox.Show("Já existe este Numero de Chassis nos carros de Oficina." +
                        "\n\t Pretende importar os dados do veiculo?" +
                        "\n (Irá eliminar quaisquer dados inseridos nesta janela)", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            textBoxMarcaVeiculo.Text = carro.Marca;
                            textBoxModeloVeiculo.Text = carro.Modelo;
                            textBoxNumeroChassis.Text = carro.NumeroChassis;
                            comboBoxCombustivelVeiculo.Text = carro.Combustivel;
                            textBoxMatriculaVeiculo.Text = null;
                            return;
                        }
                    }
                }
                if (carro.NumeroChassis == textBoxNumeroChassis.Text && carro.Vendido == false)
                {
                    if (DialogResult.Yes == MessageBox.Show("O Numero de Chassis já está a ser usado num carro de Venda que ainda nao foi vendido." +
                        " Pretende apagá-lo da lista de Carros de Venda?", "Apagar Veiculo?", MessageBoxButtons.YesNo))
                    {
                        container.Carros.Remove(carro);
                    }
                    else
                    {
                        MessageBox.Show("Então introduza outro numero de chassis.");
                        textBoxNumeroChassis.Select();
                        return;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(textBoxMarcaVeiculo.Text))
            {
                MessageBox.Show("Introduza a Marca do Veiculo");
                textBoxMarcaVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMatriculaVeiculo.Text))
            {
                MessageBox.Show("Introduza a Matricula do Veiculo");
                textBoxMatriculaVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxModeloVeiculo.Text))
            {
                MessageBox.Show("Introduza o Modelo do Veiculo");
                textBoxModeloVeiculo.Select();
                return;
            }
            if (comboBoxCombustivelVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Combustivel do Veiculo");
                comboBoxCombustivelVeiculo.Select();
                return;
            }
            CarroAluguer tempCarro = new CarroAluguer(textBoxNumeroChassis.Text, textBoxMarcaVeiculo.Text, textBoxModeloVeiculo.Text,
                comboBoxCombustivelVeiculo.Text, textBoxMatriculaVeiculo.Text);
            container.Carros.Add(tempCarro);
            container.SaveChanges();
            this.Close();
        }
    }
}
