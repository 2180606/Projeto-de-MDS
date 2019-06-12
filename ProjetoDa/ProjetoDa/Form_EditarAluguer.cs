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
    public partial class Form_EditarAluguer : Form
    {
        BaseDadosDAContainer container;
        public Form_EditarAluguer(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void EditarAluguer_Load(object sender, EventArgs e)
        {
            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = container.Alugueres.ToList();
            listBoxAlugueres.SelectedIndex = 0;
        }

        private void ListBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlugueres.SelectedIndex == -1)
                return;
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;
            dateTimePickerInicio.Text = aluguerSelecionado.DataInicio.ToShortDateString();
            dateTimePickerFim.Text = aluguerSelecionado.DataFim.ToShortDateString();
            textBoxAluguer.Text = aluguerSelecionado.IdAluguer.ToString();
            textBoxCarro.Text = aluguerSelecionado.CarroAluguer.NumeroChassis;
            textBoxCliente.Text = aluguerSelecionado.Cliente.Nome;
            textBoxValor.Text = aluguerSelecionado.Valor.ToString();
            numericUpDownKms.Value = aluguerSelecionado.Kms;
            if (aluguerSelecionado.Fatura)
            {
                textBoxAluguer.Enabled = false;
                textBoxCliente.Enabled = false;
                textBoxCarro.Enabled = false;
                textBoxValor.Enabled = false;
                dateTimePickerFim.Enabled = false;
                dateTimePickerInicio.Enabled = false;
                numericUpDownKms.Enabled = false;
            }
            else
            {
                textBoxAluguer.Enabled = false;
                textBoxCliente.Enabled = false;
                textBoxCarro.Enabled = false;
                textBoxValor.Enabled = true;
                dateTimePickerFim.Enabled = false;
                dateTimePickerInicio.Enabled = false ;
                numericUpDownKms.Enabled = true;
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            decimal tempValor;
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;
            Cliente clienteSelecionado = aluguerSelecionado.Cliente;
            CarroAluguer carroSelecionado = aluguerSelecionado.CarroAluguer;
            if (aluguerSelecionado.Fatura)
            {
                MessageBox.Show("Nao e possivel alterar dados cuja fatura ja foi enviada.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxValor.Text))
            {
                MessageBox.Show("Preencha o Campo do Valor");
                textBoxValor.Select();
                return;
            }
            if (!decimal.TryParse(textBoxValor.Text, out tempValor))
            {
                MessageBox.Show("Introduza um Numero no Campo do Valor");
                textBoxValor.Select();
                return;
            }
            if (tempValor <= 0)
            {
                MessageBox.Show("O Valor tem que ser um numero positivo/não nulo");
                textBoxValor.Select();
                return;
            }
            if (!int.TryParse(numericUpDownKms.Value.ToString(), out int tempKms))
            {
                MessageBox.Show("Nao foi possivel guardar os kilometros percorridos.");
                return;
            }
            aluguerSelecionado.Valor = tempValor;
            aluguerSelecionado.Kms = tempKms;
            container.SaveChanges();
            MessageBox.Show("Alteraçoes efetuadas com Sucesso");
        }
    }
}
