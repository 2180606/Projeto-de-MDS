﻿using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjetoDa
{
    public partial class Form_GestaoOficina : Form
    {
        BaseDadosDAContainer container;

        public Form_GestaoOficina(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            Form_AdicionarCarroOficina adicionarCarroOficina = new Form_AdicionarCarroOficina(container);
            if (container.Clientes.Count() > 0)
                adicionarCarroOficina.ShowDialog();
            UpdateListBoxCarros();
        }
        private void UpdateListBoxCarros()
        {
            Cliente clienteSelecionado = null;
            if (listBoxClientes.SelectedIndex != -1)
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }
        }
        private void AtualizarListBoxClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList();
        }

        private void GestaoOficina_Load(object sender, EventArgs e)
        {
            AtualizarListBoxClientes();

            listBoxClientes.ClearSelected();
            listBoxCarros.ClearSelected();
            listBoxServico.ClearSelected();
            listBoxParcelas.ClearSelected();
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetLabelsCarro();
            UpdateListBoxCarros();
            UpdateLabelsClientes();
            UpdateListBoxServicos();
            UpdateListBoxParcelas();
        }
        private void ResetLabelsCarro()
        {
            labelChassisCarro.Text = "";
            labelCombustivelCarro.Text = "";
            labelKilometrosCarro.Text = "";
            labelMarcaCarro.Text = "";
            labelMatriculaCarro.Text = "";
            labelModeloCarro.Text = "";
        }
        private void UpdateLabelsClientes()
        {
            if (listBoxClientes.SelectedIndex == -1)
                return;
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            labelClienteSelecionado.Text= "Cliente: "+clienteSelecionado.Nome;
            labelContactoCliente.Text="Contacto: "+clienteSelecionado.Contacto;
            labelMoradaCliente.Text="Morada: "+clienteSelecionado.Morada;
            labelNifCliente.Text="NIF: "+clienteSelecionado.NIF.ToString();
        }
        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            Form_EliminarCarroOficina eliminarCarroOficina = new Form_EliminarCarroOficina(container);
            Cliente clienteSelecionado = null;
            if (listBoxClientes.SelectedIndex != -1)
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

                if (clienteSelecionado.CarrosOficina.Count() != 0)
                {
                    eliminarCarroOficina.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O Cliente Selecionado não tem Carros de Oficina");
                }
            }
            UpdateListBoxCarros();
        }

        private void ListBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado;
            if (listBoxCarros.SelectedIndex != -1)
            {
                carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
                labelChassisCarro.Text = carroSelecionado.NumeroChassis;
                labelCombustivelCarro.Text = carroSelecionado.Combustivel;
                labelMatriculaCarro.Text = carroSelecionado.Matricula;
                labelMarcaCarro.Text = carroSelecionado.Marca;
                labelModeloCarro.Text = carroSelecionado.Modelo;
                labelKilometrosCarro.Text = carroSelecionado.Kms.ToString();
                UpdateListBoxServicos();
            }
        }

        private void ButtonAdicionarServico_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado;
            CarroOficina carroSelecionado;
            if (listBoxClientes.SelectedIndex==-1)
            {
                MessageBox.Show("Selecione Um Cliente");
                return;
            }
            else
            {
                clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            }
            if (listBoxCarros.SelectedIndex==-1)
            {
                MessageBox.Show("Selecione Um Carro");
                return;
            }
            else
            {
                carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            }
            Form_AdicionarServicoOficina adicionarServicoOficina = new Form_AdicionarServicoOficina(container,clienteSelecionado,carroSelecionado);
            adicionarServicoOficina.ShowDialog();
            UpdateListBoxServicos();
        }
        private void UpdateListBoxServicos()
        {
            if (listBoxCarros.SelectedIndex == -1)
            {
                listBoxServico.DataSource = null;
                return;
            }
                
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            listBoxServico.DataSource = null;
            listBoxServico.DataSource = carroSelecionado.Servicos.ToList();

        }

        private void ButtonEliminarServico_Click(object sender, EventArgs e)
        {
            Form_EliminarServicoOficina eliminarServicoOficina = new Form_EliminarServicoOficina(container);
            eliminarServicoOficina.ShowDialog();
            UpdateListBoxServicos();
        }

        private void ListBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServico.SelectedIndex != -1)
            {
                UpdateLabelsServico();
                UpdateListBoxParcelas();
            }
        }
        private void UpdateListBoxParcelas()
        {
            if (listBoxServico.SelectedIndex!=-1)
            {
                Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;
                listBoxParcelas.DataSource = null;
                listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
            }
            else
            {
                listBoxParcelas.DataSource = null;
            }
        }
        private void UpdateLabelsServico()
        {
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;
            labelDataEntrada.Text = "Data de Entrada: "+servicoSelecionado.DataEntrada.ToShortDateString();
            labelDataSaida.Text = "Data de Saída: "+servicoSelecionado.DataSaida.ToShortDateString();
            labelTipoServico.Text = "Tipo de Serviço: " + servicoSelecionado.Tipo;
        }

        private void ButtonAdicionarParcela_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente");
                return;
            }
            if (listBoxCarros.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Carro");
                return;
            }
            if (listBoxServico.SelectedIndex==-1)
            {
                MessageBox.Show("Selecione um Servico");
                return;
            }
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;
            if (servicoSelecionado.Fatura)
            {
                MessageBox.Show("Não é possivel adicionar Parcelas a um Serviço já Faturado");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescricaoParcela.Text))
            {
                MessageBox.Show("Preencha o Campo da Descricao da Parcela");
                textBoxDescricaoParcela.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxValorParcela.Text))
            {
                MessageBox.Show("Preencha o campo do Valor");
                textBoxValorParcela.Select();
                return;
            }
            if(!decimal.TryParse(textBoxValorParcela.Text, out decimal tempValor))
            {
                MessageBox.Show("Introduza um numero para o valor");
                textBoxValorParcela.Select();
                return;
            }
            if (tempValor <= 0)
            {
                MessageBox.Show("Introduza um valor positivo/não nulo");
                textBoxValorParcela.Select();
                return;
            }
            Parcela tempParcela = new Parcela(tempValor, textBoxDescricaoParcela.Text);
            servicoSelecionado.Parcelas.Add(tempParcela);
            container.SaveChanges();
            UpdateListBoxParcelas();
        }

        private void ButtonEliminarParcela_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente");
                return;
            }
            if (listBoxCarros.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Carro");
                return;
            }
            if (listBoxServico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Servico");
                return;
            }
            if (listBoxParcelas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Parcela para Eliminar");
                return;
            }
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;
            if (parcelaSelecionada.Servico.Fatura)
            {
                MessageBox.Show("Não é possivel eliminar Parcelas que ja foram faturadas");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer Eliminar a Parcela Selecionada?","Confirmação",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                container.Parcelas.Remove(parcelaSelecionada);
                container.SaveChanges();
                MessageBox.Show("Parcela Eliminada com Sucesso");
                UpdateListBoxParcelas();
            }
        }

        private void ButtonFatura_Click(object sender, EventArgs e)
        {

            string TextClientes = listBoxClientes.GetItemText(listBoxClientes.SelectedItem);
            string TextCarros = listBoxCarros.GetItemText(listBoxCarros.SelectedItem);
            string TextServico = listBoxServico.GetItemText(listBoxServico.SelectedItem);
            string TextParcelas = listBoxParcelas.GetItemText(listBoxParcelas.SelectedItem);


            Servico servicoselecionado = (Servico)listBoxServico.SelectedItem;

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
                        doc.Add(new iTextSharp.text.Paragraph(TextServico));
                        doc.Add(new iTextSharp.text.Paragraph(TextParcelas));
                        doc.Add(new iTextSharp.text.Paragraph(textBoxDescricaoParcela.Text));
                        doc.Add(new iTextSharp.text.Paragraph(textBoxValorParcela.Text));
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

            servicoselecionado.Fatura = true;
            container.SaveChanges();

            listBoxClientes.ClearSelected();
            listBoxCarros.ClearSelected();
            listBoxServico.ClearSelected();
            listBoxParcelas.ClearSelected();
        }
    }
}
