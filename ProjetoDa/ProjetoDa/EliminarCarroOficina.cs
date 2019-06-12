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
    public partial class EliminarCarroOficina : Form
    {
        private BaseDadosDAContainer container;
        private Cliente clienteSelecionado;
        public EliminarCarroOficina(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
        }

        private void EliminarCarroOficina_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = container.Clientes.ToList();
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
        }

        private void ButtonEliminarCarro_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um Cliente");
                return;
            }
            CarroOficina carroSelecionado=null;
            if (listBoxCarros.SelectedIndex != -1)
            {
                carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            }
            else
            {
                MessageBox.Show("Escolha um carro do cliente para eliminar.");
                return;
            }
            if (carroSelecionado.Servicos.Count() != 0)
            { // Eventualmente meter para aqui a uma verificacao qq para ver se o estupido do utilizador quer apagar os serviços/
                //parcelas associados ao carro
                MessageBox.Show("Não pode apagar um carro com serviços associados!");
                return;
            }
            if(DialogResult.Yes==MessageBox.Show("Tem a certeza que pretende eliminar o Veiculo Selecionado?","Confirmação", MessageBoxButtons.YesNo))
            {
                container.Carros.Remove(carroSelecionado);
                container.SaveChanges();
                MessageBox.Show("Carro apagado com Sucesso.");
                this.Close();
            }
        }
    }
}
