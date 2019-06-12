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
    public partial class Form_EliminarCarroVenda : Form
    {
        private BaseDadosDAContainer container;
        public Form_EliminarCarroVenda(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            CarroVenda carroSelecionado;

            if (listBoxCarrosVenda.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Carro da Lista");
                return;
            }
            else
            {
                carroSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            }
            if (carroSelecionado.Vendido)
            {
                MessageBox.Show("O Carro não pode ser eliminado porque já foi vendido.");
                return;
            }
            if (textBoxNumeroChassis.Text != carroSelecionado.NumeroChassis)
            {
                MessageBox.Show("Numero de Chassis Diferente do Selecionado");
                return;
            }
            container.Carros.Remove(carroSelecionado);
            container.SaveChanges();
            MessageBox.Show("Carro Eliminado com Sucesso");
            listBoxCarrosVenda.DataSource = null;
            listBoxCarrosVenda.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();
            textBoxNumeroChassis.Clear();
        }
        private void EliminarCarroVenda_Load(object sender, EventArgs e)
        {
            listBoxCarrosVenda.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();
        }
    }
}
