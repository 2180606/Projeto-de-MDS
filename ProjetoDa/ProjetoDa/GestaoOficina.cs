using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class GestaoOficina : Form
    {
        BaseDadosDAContainer container;

        public GestaoOficina(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            AdicionarCarroOficina adicionarCarroOficina = new AdicionarCarroOficina(container);
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
            labelTotalCarro.Text = "";
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
            //labelTotalCliente.Text=clienteSelecionado.Total;
        }
        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            EliminarCarroOficina eliminarCarroOficina = new EliminarCarroOficina(container);
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
            AdicionarServicoOficina adicionarServicoOficina = new AdicionarServicoOficina(container,clienteSelecionado,carroSelecionado);
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
            EliminarServicoOficina eliminarServicoOficina = new EliminarServicoOficina(container);
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
            labelTipoServico.Text = "Tipo de Serviço: "+servicoSelecionado.Tipo;
            //labelTotalServico.Text = servicoSelecionado.Total;

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
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;
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
            /*if(Servico Fatura cenas == true )
                rebenta*/
            
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer Eliminar a Parcela Selecionada?","Confirmação",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                container.Parcelas.Remove(parcelaSelecionada);
                container.SaveChanges();
                UpdateListBoxParcelas();
            }
        }

        private void ButtonFatura_Click(object sender, EventArgs e)
        {
            //qq coisa para imprimir a fatura
            //aluguerSelecionado.Fatura = true;
            //container.SaveChanges();
        }
    }
}
