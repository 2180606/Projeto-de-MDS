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
    public partial class EliminarCarroVenda : Form
    {
        private BaseDadosContainer container;
        public EliminarCarroVenda()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            CarroVenda carroSelecionado = new CarroVenda();

            if(listBoxCarrosVenda.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Carro da Lista");
                return;
            }
            else
            {
                carroSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            }
            if (textBoxNumeroChassis.Text != carroSelecionado.NumeroChassis)
            {
                MessageBox.Show("Numero de Chassis Diferente do Selecionado");
                return;
            }
            container.Carros.Remove(carroSelecionado);
            container.SaveChanges();
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
