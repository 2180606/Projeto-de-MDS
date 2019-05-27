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
            // TODO: This line of code loads data into the 'baseDadosDADataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
        }




        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.SearchName(this.baseDadosDADataSet.Clientes, textBoxFiltrar.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBoxNomeCliente.Text, textBoxMoradaCliente.Text, 123456789, textBoxContactoCliente.Text);
            container.Clientes.Add(cliente);
            container.SaveChanges();
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("deseja eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if ( resposta == DialogResult.Yes)
            {
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.baseDadosDADataSet);
            }
            else
            {
                this.clientesBindingSource.CancelEdit();
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDadosDADataSet);
            MessageBox.Show("alteracao feita com sucesso", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
