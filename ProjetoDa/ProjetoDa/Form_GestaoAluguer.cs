﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ProjetoDa
{
    public partial class Form_GestaoAluguer : Form
    {
        private BaseDadosDAContainer container;
        public Form_GestaoAluguer(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void GestaoAluguer_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = container.Clientes.ToList();
            listBoxCarros.DataSource = container.Carros.OfType<CarroAluguer>().ToList();
            UpdateListBoxAlugueres();
            listBoxClientes.ClearSelected();
            listBoxCarros.ClearSelected();
            listBoxAlugueres.ClearSelected();

        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabelsCliente();
        }
        private void UpdateLabelsCliente()
        {
            if (listBoxClientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                labelClienteSelecionado.Text = "Cliente: " + clienteSelecionado.Nome;
                labelContactoCliente.Text = "Contacto: " + clienteSelecionado.Contacto;
                labelMoradaCliente.Text = "Morada: " + clienteSelecionado.Morada;
                labelNifCliente.Text = clienteSelecionado.NIF.ToString();
            }
        }
        private void UpdateLabelsCarro()
        {
            int kilometragem = 0;
            if (listBoxCarros.SelectedIndex != -1)
            {
                CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarros.SelectedItem;
                labelModeloCarro.Text = carroSelecionado.Modelo;
                labelMatriculaCarro.Text = carroSelecionado.Matricula;
                labelMarcaCarro.Text = carroSelecionado.Marca;
                foreach (Aluguer aluguer in container.Alugueres)
                {
                    if (carroSelecionado == aluguer.CarroAluguer)
                    {
                        kilometragem += aluguer.Kms;
                    }
                }
                labelKilometrosCarro.Text = kilometragem.ToString();
                labelCombustivelCarro.Text = carroSelecionado.Combustivel;
                labelChassisCarro.Text = carroSelecionado.NumeroChassis;
            }
        }
        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            Form_AdicionarCarroAluguer adicionarCarroAluguer = new Form_AdicionarCarroAluguer(container);
            adicionarCarroAluguer.ShowDialog();
            UpdateListBoxCarros();
        }
        private void UpdateListBoxCarros()
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = container.Carros.OfType<CarroAluguer>().ToList();
        }

        private void ListBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCarros.SelectedIndex != -1)
            {
                UpdateLabelsCarro();
            }
        }

        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            Form_EliminarCarroAluguer eliminarCarroAluguer = new Form_EliminarCarroAluguer(container);
            eliminarCarroAluguer.ShowDialog();
            UpdateListBoxCarros();
        }

        private void ButtonCriarAluguer_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado;
            CarroAluguer carroSelecionado;
            decimal tempValor;
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Um Cliente");
                return;
            }
            else
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            }
            if (listBoxCarros.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Um Carro");
                return;
            }
            else
            {
                carroSelecionado = (CarroAluguer)listBoxCarros.SelectedItem;
            }
            if (dateTimePickerInicio.Value.Date > dateTimePickerFim.Value.Date)
            {
                MessageBox.Show("A data de Fim não pode ser posterior à data de Inicio");
                dateTimePickerFim.Select();
                return;
            }
            foreach(Aluguer aluguer in clienteSelecionado.Alugueres)
            {
                if (aluguer.DataInicio <= dateTimePickerInicio.Value.Date && aluguer.DataFim >= dateTimePickerInicio.Value.Date)
                {
                    MessageBox.Show("O Cliente já tem um carro alugado nessa data");
                    return;
                }
                if(aluguer.DataInicio <= dateTimePickerFim.Value.Date && aluguer.DataFim >= dateTimePickerFim.Value.Date)
                {
                    MessageBox.Show("O Cliente já tem um carro alugado nessa data");
                    return;
                }
            }
            foreach(Aluguer aluguer in carroSelecionado.Aluguer)
            {

                if (aluguer.DataInicio <= dateTimePickerInicio.Value.Date && aluguer.DataFim >= dateTimePickerInicio.Value.Date)
                {
                    MessageBox.Show("O Carro Selecionado já está alugado nesse data");
                    return;
                }
                if (aluguer.DataInicio <= dateTimePickerFim.Value.Date && aluguer.DataFim >= dateTimePickerFim.Value.Date)
                {
                    MessageBox.Show("O Carro Selecionado já está alugado nesse data");
                    return;
                }
                if(aluguer.DataInicio>dateTimePickerInicio.Value.Date && dateTimePickerFim.Value.Date > aluguer.DataInicio)
                {
                    MessageBox.Show("O Carro Selecionado já está alugado nesse periodo de tempo");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(textBoxValorAluguer.Text))
            {
                MessageBox.Show("Preencha o Campo do Valor");
                textBoxValorAluguer.Select();
                return;
            }
            if(!decimal.TryParse(textBoxValorAluguer.Text,out tempValor))
            {
                MessageBox.Show("Introduza um Numero no Campo do Valor");
                textBoxValorAluguer.Select();
                return;
            }
            if (tempValor <= 0)
            {
                MessageBox.Show("O Valor tem que ser um numero positivo/não nulo");
                textBoxValorAluguer.Select();
                return;
            }
            if(!int.TryParse(numericUpDownKilometragem.Value.ToString(),out int tempKms))
            {
                MessageBox.Show("Nao foi possivel guardar os kilometros percorridos.");
                return;
            }
            Aluguer tempAluguer = new Aluguer(dateTimePickerInicio.Value.Date, dateTimePickerFim.Value.Date, tempValor,tempKms,carroSelecionado);
            clienteSelecionado.Alugueres.Add(tempAluguer);
            container.SaveChanges();
            MessageBox.Show("Aluguer Criado Com Sucesso");
            UpdateListBoxAlugueres();
            ResetTextBoxes();


            listBoxClientes.ClearSelected();
            listBoxCarros.ClearSelected();
            listBoxAlugueres.ClearSelected();
        }
        private void ResetTextBoxes()
        {
            textBoxValorAluguer.Clear();
            numericUpDownKilometragem.Value = 0;
            dateTimePickerFim.Value = DateTime.Now;
            dateTimePickerInicio.Value = DateTime.Now;
        }
        private void UpdateListBoxAlugueres()
        {
            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = container.Alugueres.ToList();
        }

        private void ListBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabelsAluguer();
        }
        private void UpdateLabelsAluguer()
        {
            if (listBoxAlugueres.SelectedIndex != -1)
            {
                Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;
                labelCarroAluguer.Text = "Carro Alugado: " + aluguerSelecionado.CarroAluguer.NumeroChassis;
                labelClienteAluguer.Text = "Cliente: " + aluguerSelecionado.Cliente.Nome;
                labelValorAluguer.Text = "Valor: " + aluguerSelecionado.Valor.ToString() + "€";
                labelKilometrosAluguer.Text = "Kilometros Percorridos: " + aluguerSelecionado.Kms.ToString();
                labelDtaFim.Text = "Data de Inicio: " + aluguerSelecionado.DataFim.ToShortDateString();
                labelDtaInicio.Text = "Data de Fim: " + aluguerSelecionado.DataInicio.ToShortDateString();
            }
        }

        private void ButtonEditarAluguer_Click(object sender, EventArgs e)
        {
            Form_EditarAluguer editarAluguer = new Form_EditarAluguer(container);
            editarAluguer.ShowDialog();
            UpdateListBoxAlugueres();
            UpdateLabelsAluguer();
        }

        private void ButtonEliminarAluguer_Click(object sender, EventArgs e)
        {
            if (listBoxAlugueres.SelectedIndex == -1)
                return;

            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;

            DialogResult dialogResult=MessageBox.Show("Tem a certeza que pretende apagar o Aluguer Selecionado?", "Confirmacao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (aluguerSelecionado.Fatura==false)
            {
                container.Alugueres.Remove(aluguerSelecionado);
                container.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nao e possivel apagar dados que ja foram faturados.");
                return;
            }
        }

        private void ButtonFatura_Click(object sender, EventArgs e)
        {
            //qq coisa para imprimir a fatura

            string TextClientes = listBoxClientes.GetItemText(listBoxClientes.SelectedItem);
            string TextCarros = listBoxCarros.GetItemText(listBoxCarros.SelectedItem);
            string TextAluguer = listBoxAlugueres.GetItemText(listBoxAlugueres.SelectedItem);
 

            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;

            using (SaveFileDialog SaveFDialog = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            {
                if (SaveFDialog.ShowDialog() == DialogResult.OK)
                { 
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A5.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(SaveFDialog.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(TextClientes));
                        doc.Add(new iTextSharp.text.Paragraph(TextCarros));
                        doc.Add(new iTextSharp.text.Paragraph(TextAluguer));
                        doc.Add(new iTextSharp.text.Paragraph(dateTimePickerInicio.Text));
                        doc.Add(new iTextSharp.text.Paragraph(dateTimePickerFim.Text));
                        doc.Add(new iTextSharp.text.Paragraph(textBoxValorAluguer.Text));

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }

            aluguerSelecionado.Fatura = true;
            container.SaveChanges();

            listBoxClientes.ClearSelected();
            listBoxCarros.ClearSelected();
            listBoxAlugueres.ClearSelected();
            ResetTextBoxes();


        }
    }
}
