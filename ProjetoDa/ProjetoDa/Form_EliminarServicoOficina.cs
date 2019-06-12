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
    public partial class Form_EliminarServicoOficina : Form
    {
        BaseDadosDAContainer container;
        public Form_EliminarServicoOficina(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente.");
                return;
            }
            if (listBoxCarrosOficina.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Carro de Oficina");
                return;
            }
            if (listBoxServico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Serviço.");
                return;
            }
           


            if (DialogResult.Yes==MessageBox.Show("Tem a certeza que pretende Eliminar o Serviço Selecionado?", "Confirmação", MessageBoxButtons.YesNo))
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
                Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;
                if (servicoSelecionado.Fatura)
                {
                    MessageBox.Show("Nao é possivel apagar Serviços ja faturados");
                    return;
                }
                if (servicoSelecionado.Parcelas.Count != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Não é possivel apagar Serviços com Parcelas Associadas\n " +
                        "Pretende Eliminar as Parcelas Associadas?", "Apagar Parcelas?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (Parcela parcela in servicoSelecionado.Parcelas)
                        {
                            servicoSelecionado.Parcelas.Remove(parcela);
                        }
                        MessageBox.Show("Parcela(s) eliminada(s) com Sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Escolha Outro Serviço ou Elimine as Parcelas Associadas a Este");
                        return;
                    }
                }
                container.Servicos.Remove(servicoSelecionado);
                container.SaveChanges();
                MessageBox.Show("Serviço eliminado com Sucesso");
                this.Close();
            }
        }

        private void EliminarServicoOficina_Load(object sender, EventArgs e)
        {
            AtualizarListBoxClientes();
            
        }
        private void AtualizarListBoxClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList();
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListBoxCarros();
        }
        private void AtualizarListBoxCarros()
        {
            if (listBoxClientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                listBoxCarrosOficina.DataSource = null;
                listBoxCarrosOficina.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }
        }

        private void ListBoxCarrosOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListBoxServicos();
        }
        private void AtualizarListBoxServicos()
        {
            if (listBoxCarrosOficina.SelectedIndex != -1)
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
                listBoxServico.DataSource = null;
                listBoxServico.DataSource = carroSelecionado.Servicos.ToList();
            }
            else
            {
                listBoxServico.DataSource = null;
            }
            
        }
    }
}
