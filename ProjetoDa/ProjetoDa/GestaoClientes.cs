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
    public partial class GestaoClientes : Form
    {
        private BaseDadosContainer container;
        public GestaoClientes()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosClientes.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.baseDadosClientes.Clientes);
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            container.Clientes.Add(cliente);
            container.SaveChanges();
        }

        private void ToolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = container.Clientes.ToList<Cliente>();
        }
    }
}
