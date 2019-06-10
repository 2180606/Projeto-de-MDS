﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class AdicionarCarroOficina : Form
    {
        BaseDadosContainer container;
        public AdicionarCarroOficina(BaseDadosContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }
        private void AtualizarListBox()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList();
        }

        private void ButtonAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado;
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente para adicionar o Carro de Oficina");
                return;
            }
            else
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            }
            if (string.IsNullOrWhiteSpace(textBoxNumeroChassis.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxNumeroChassis.Select();
                return;
            }
            foreach (Cliente cliente in container.Clientes)
            {
                foreach (Carro carro in cliente.CarrosOficina)
                {
                    if (carro.NumeroChassis == textBoxNumeroChassis.Text)
                    {
                        MessageBox.Show("Já existe um carro de Oficina com o Numero de Chassis Introduzido!");
                        textBoxNumeroChassis.Show();
                        return;
                    }
                }
            }
            foreach (CarroVenda carro in container.Carros.OfType<CarroVenda>())
            {
                if (carro.NumeroChassis == textBoxNumeroChassis.Text && carro.Vendido == true)
                {
                    if (textBoxMarcaVeiculo.Text != carro.Marca || textBoxModeloVeiculo.Text != carro.Modelo || comboBoxCombustivelVeiculo.Text != carro.Combustivel)
                    {
                        if (MessageBox.Show("Já existe este Numero de Chassis nos carros de Venda." +
                        "\n\t Pretende importar os dados do veiculo?" +
                        "\n (Irá eliminar quaisquer dados inseridos nesta janela)", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            textBoxMarcaVeiculo.Text = carro.Marca;
                            textBoxModeloVeiculo.Text = carro.Modelo;
                            textBoxNumeroChassis.Text = carro.NumeroChassis;
                            comboBoxCombustivelVeiculo.Text = carro.Combustivel;
                            textBoxMatriculaVeiculo.Text = null;
                            numericUpDownKilometros.Value = 0;
                            return;
                        }
                    }
                }
                if (carro.NumeroChassis == textBoxNumeroChassis.Text && carro.Vendido == false)
                {
                    if (DialogResult.Yes == MessageBox.Show("O Numero de Chassis já está a ser usado num carro de Venda que ainda nao foi vendido." +
                        " Pretende apagá-lo da lista de Carros de Venda?","Apagar Veiculo?",MessageBoxButtons.YesNo))
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
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxMarcaVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxModeloVeiculo.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxModeloVeiculo.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMatriculaVeiculo.Text))
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxMatriculaVeiculo.Select();
                return;
            }
            if (comboBoxCombustivelVeiculo.SelectedIndex == -1)
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                return;
            }
            if (numericUpDownKilometros.Value < 1)
            {// Meter label para servir de Mensagem de Erros de Preenchimento
                numericUpDownKilometros.Select();
                return;
            }
            CarroOficina tempCarroOficina = new CarroOficina(textBoxNumeroChassis.Text, textBoxMarcaVeiculo.Text, textBoxModeloVeiculo.Text, 
                comboBoxCombustivelVeiculo.Text, textBoxMatriculaVeiculo.Text, (int)numericUpDownKilometros.Value);
            clienteSelecionado.CarrosOficina.Add(tempCarroOficina);
            container.SaveChanges();
            //this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void AdicionarCarroOficina_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }
    }
}
