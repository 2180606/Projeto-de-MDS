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
    public partial class Menus : Form
    {
        private BaseDadosContainer container;
        GestaoClientes gestaoClientes = new GestaoClientes();
        public Menus()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }

        private void ButtonGestaoClientes_Click(object sender, EventArgs e)
        {
            //falta trycatch
            gestaoClientes.ShowDialog(this);
        }

        private void ButtonGestaoOficina_Click(object sender, EventArgs e)
        {
            //gestaoOficina.ShowDialog(this)
        }

        private void ButtonGestaoVendas_Click(object sender, EventArgs e)
        {
            //gestaoVendas.ShowDialog(this)
        }

        private void ButtonGestaoAluguer_Click(object sender, EventArgs e)
        {
            //gestaoAluguer.ShowDialog(this)
        }
    }
}
