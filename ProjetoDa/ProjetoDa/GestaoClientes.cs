using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; //IMPORTANTE

namespace ProjetoDa
{
    public partial class GestaoClientes : Form
    {
        private BaseDadosContainer container;
        public GestaoClientes()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
            (from clientes in container.Clientes
             orderby clientes.Nome
             select clientes.IdCliente).Load();
            clientesBindingSource.DataSource = container.Clientes.Local.ToBindingList();

        }

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosClientes.Clientes' table. You can move, or remove it, as needed.
            //his.clientesTableAdapter.Fill(this.baseDadosClientes.Clientes);

        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                container.Dispose();
                container = new BaseDadosContainer();
                (from Clientes in container.Clientes
                 where Clientes.Nome.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                 orderby Clientes.Nome
                 select Clientes.IdCliente).ToList();
                clientesBindingSource.DataSource = container.Clientes.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;
                container.Dispose();
                container = new BaseDadosContainer();
                (from Clientes in container.Clientes
                 orderby Clientes.Nome
                 select Clientes.IdCliente).Load();
                clientesBindingSource.DataSource = container.Clientes.Local.ToBindingList();
            }

        }

       
    }
}
