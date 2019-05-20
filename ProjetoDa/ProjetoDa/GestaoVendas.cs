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
    public partial class GestaoVendas : Form
    {
        private BaseDadosContainer container;
        public GestaoVendas()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }
        AdicionarCarroVenda adicionarCarroVenda = new AdicionarCarroVenda();
        EliminarCarroVenda eliminarCarroVenda = new EliminarCarroVenda();
        private void ButtonAdicionarCarroVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = adicionarCarroVenda.ShowDialog(this);
            if ( dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                atualizarListBoxes();
            }
        }
        private void atualizarListBoxes()
        {
            listBoxCarros.DataSource = null;
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = container.Clientes.ToList<Cliente>();
            listBoxCarros.DataSource = container.Carros.OfType<CarroVenda>().ToList<Carro>();

        }
        private void ButtonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = eliminarCarroVenda.ShowDialog(this); ;
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                atualizarListBoxes();
            }
            
        }

        private void GestaoVendas_Load(object sender, EventArgs e)
        {
            atualizarListBoxes();
        }
    }
}
