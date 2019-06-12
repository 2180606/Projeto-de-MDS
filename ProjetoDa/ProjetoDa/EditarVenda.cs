using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class EditarVenda : Form
    {
        private BaseDadosDAContainer container;
        public Venda vendaSelecionada;
        public EditarVenda(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void EditarVenda_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
            listBoxVendas.SelectedIndex=0;
        }
        private void AtualizarListBox()
        {
            listBoxVendas.DataSource = null;
            listBoxVendas.DataSource = container.Vendas.ToList();
        }


        private void ListBoxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (vendaSelecionada != null)
            {
                if (vendaSelecionada.Estado=="Concluída")
                {
                    DisableConcluida();
                }
                else
                {
                    textBoxVenda.Enabled = true;
                    textBoxCliente.Enabled = true;
                    textBoxCarro.Enabled = true;
                    textBoxValor.Enabled = true;
                    comboBoxEstado.Enabled = true;
                    dateTimePickerDia.Enabled = true;
                    dateTimePickerHora.Enabled = true;
                }
                textBoxCarro.Text = vendaSelecionada.CarroVenda.NumeroChassis;// TODO fazer verificação se o numero existe e se ainda nao esta vendido
                textBoxCliente.Text = vendaSelecionada.Cliente.Nome;// TODO fazer verificação se o cliente existe
                comboBoxEstado.Text = vendaSelecionada.Estado;
                textBoxValor.Text = vendaSelecionada.Valor.ToString();
                textBoxVenda.Text = "Venda Numero " + vendaSelecionada.IdVenda;
                dateTimePickerDia.Value = vendaSelecionada.Data;
                dateTimePickerHora.Value = vendaSelecionada.Data;
            }
        }
        private void DisableConcluida()
        {
            textBoxVenda.Enabled = false;
            textBoxCliente.Enabled = false;
            textBoxCarro.Enabled = false;
            textBoxValor.Enabled = false;
            comboBoxEstado.Enabled = false;
            dateTimePickerDia.Enabled = false;
            dateTimePickerHora.Enabled = false;
        }
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            DateTime dataVenda = dateTimePickerDia.Value.Date + dateTimePickerHora.Value.TimeOfDay;
            if (listBoxVendas.SelectedItem != null)
            {
                if (vendaSelecionada.Fatura)
                {
                    MessageBox.Show("Não é possivel alterar dados Faturados");
                    return;
                }
                if (vendaSelecionada.Estado=="Concluída")
                {
                    MessageBox.Show("Nao é possivel editar vendas Concluidas");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBoxValor.Text))
                {
                    MessageBox.Show("Preencha o campo do Valor!");
                    textBoxValor.Select();
                    return;
                }
                if (!decimal.TryParse(textBoxValor.Text, out decimal tempValor))
                {
                    MessageBox.Show("Insira um numero para o valor");
                    textBoxValor.Select();
                    return;
                }
                if (tempValor < 0)
                {
                    MessageBox.Show("Insira um numero positivo para o valor.");
                    textBoxValor.Select();
                    return;
                }

                if (dataVenda.Date > DateTime.Now)
                {
                    MessageBox.Show("Selecione uma data válida para a hora.");
                    return;
                }
                if (MessageBox.Show("Tem a certeza que pretende efetuar as alterações", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vendaSelecionada.Estado = comboBoxEstado.Text;
                    vendaSelecionada.Data = dateTimePickerDia.Value.Date + dateTimePickerHora.Value.TimeOfDay;
                    if (tempValor != -1)
                        vendaSelecionada.Valor = tempValor;
                    container.SaveChanges();
                    this.Close();
                }
                else
                {
                    int selectedIndex = listBoxVendas.SelectedIndex;
                    AtualizarListBox();
                    listBoxVendas.SelectedItem = selectedIndex;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione Uma Venda!");
                return;
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
