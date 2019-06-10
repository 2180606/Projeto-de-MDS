using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public GestaoClientes(BaseDadosContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        int selectedRow;


        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDADataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
            clientesDataGridView.DataSource = container.Clientes.Local.ToBindingList();
        }


        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            selectedRow = clientesDataGridView.CurrentCell.RowIndex;
            clientesDataGridView.Rows.RemoveAt(selectedRow);

            if (clientesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("No item selected.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //this.clientesBindingSource.Remove(clientesBindingSource.Current);
            }

            container.SaveChanges();
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {

                //this.clientesTableAdapter.SearchName(this.baseDadosDADataSet.Clientes, textBoxFiltrar.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAlterar_Click(object sender, EventArgs e)
        {

            this.Validate();

            //this.clientesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.baseDadosDADataSet);
            MessageBox.Show("alteracao feita com sucesso", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void ClientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = this.clientesDataGridView.Rows[e.RowIndex];
            }
            catch
            {
                return;
            }
           

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxNomeCliente.Text = row.Cells[0].Value.ToString();
                TextBoxNifCliente.Text = row.Cells[1].Value.ToString();
                textBoxContactoCliente.Text = row.Cells[2].Value.ToString();
                textBoxMoradaCliente.Text = row.Cells[3].Value.ToString();

            }

        }


        private void ButtonInserir_Click(object sender, EventArgs e)
        {
            //converter string to int

            int.TryParse(TextBoxNifCliente.Text, out int tempNif);
            Cliente tempcliente = new Cliente();

            //verificacoes
            if (string.IsNullOrWhiteSpace(textBoxNomeCliente.Text))
            {
                // Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxNomeCliente.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxNifCliente.Text))
            {
                // Meter label para servir de Mensagem de Erros de Preenchimento
                TextBoxNifCliente.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxContactoCliente.Text))
            {
                // Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxContactoCliente.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMoradaCliente.Text))
            {
                // Meter label para servir de Mensagem de Erros de Preenchimento
                textBoxMoradaCliente.Select();
                return;
            }

            foreach (Cliente cliente in container.Clientes.ToList<Cliente>())
            {
                if (tempNif == cliente.NIF)
                {
                    MessageBox.Show("O Cliente com o respetivo NIF ja se encontra inserido na base de dados");
                    TextBoxNifCliente.Select();
                    return;
                }
            }

            tempcliente.Nome = textBoxNomeCliente.Text;
            tempcliente.NIF = tempNif;
            tempcliente.Morada = textBoxMoradaCliente.Text;
            tempcliente.Contacto = textBoxContactoCliente.Text;

            container.Clientes.Add(tempcliente);
            container.SaveChanges();

            textBoxNomeCliente.Text = "";
            TextBoxNifCliente.Text = "";
            textBoxContactoCliente.Text = "";
            textBoxMoradaCliente.Text = "";
        }

        private void GestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
