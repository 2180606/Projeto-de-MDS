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
    public partial class Form_GestaoClientes : Form
    {
        private BaseDadosDAContainer container;
        public Form_GestaoClientes(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }
        int selectedRow;
        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDADataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
            nomeTextBox.Text = "";
            nIFTextBox.Text = "";
            contactoTextBox.Text = "";
            moradaTextBox.Text = "";
            clientesDataGridView.DataSource = container.Clientes.Local.ToBindingList();
        }


        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            selectedRow = clientesDataGridView.CurrentCell.RowIndex;
            clientesDataGridView.Rows.RemoveAt(selectedRow);
            try
            {
                DialogResult resposta = default;
                if (clientesDataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum cliente selecionado.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    resposta = MessageBox.Show("Deseja eliminar o seguinte cliente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    clientesDataGridView.ClearSelection();
                }

                clientesDataGridView.ClearSelection();

                if (resposta == DialogResult.Yes)
                {
                    clientesBindingSource.Remove(clientesBindingSource.Current);
                    container.SaveChanges();
                    this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
                }
                else
                {
                    this.clientesBindingSource.CancelEdit();
                    MessageBox.Show("O cliente selecionado nao foi apagado.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text == "")
            {
                MessageBox.Show("Insira o nome do cliente a procurar.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Aparece nas textboxes mas nao na datagridview
            else
            {
                try
                {
                    this.clientesTableAdapter.SearchName(this.baseDadosDADataSet.Clientes, textBoxFiltrar.Text);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ButtonAlterar_Click(object sender, EventArgs e)
        {
            //ALTERAR
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDadosDADataSet);
            container.SaveChanges();
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
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
                nomeTextBox.Text = row.Cells[0].Value.ToString();
                nIFTextBox.Text = row.Cells[1].Value.ToString();
                contactoTextBox.Text = row.Cells[2].Value.ToString();
                moradaTextBox.Text = row.Cells[3].Value.ToString();
            }
        }
        //inserir
        private void ButtonInserir_Click(object sender, EventArgs e)
        {
            //converter string to int
            int.TryParse(nIFTextBox.Text, out int tempNif);
            Cliente tempcliente = new Cliente();

            //verificacoes
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
            {
                MessageBox.Show("Introduza o Nome do Cliente");
                nomeTextBox.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(nIFTextBox.Text))
            {
                MessageBox.Show("Introduza o NIF do Cliente");
                nIFTextBox.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(contactoTextBox.Text))
            {
                MessageBox.Show("Introduza o Contacto do Cliente");

                contactoTextBox.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(moradaTextBox.Text))
            {
                MessageBox.Show("Introduza a Morada do Cliente");

                moradaTextBox.Select();
                return;
            }
            foreach (Cliente cliente in container.Clientes.ToList<Cliente>())
            {
                if (tempNif == cliente.NIF)
                {
                    MessageBox.Show("O Cliente com o respetivo NIF ja se encontra inserido na base de dados");
                    nIFTextBox.Select();
                    return;
                }
            }
            tempcliente.Nome = nomeTextBox.Text;
            tempcliente.NIF = tempNif;
            tempcliente.Morada = moradaTextBox.Text;
            tempcliente.Contacto = contactoTextBox.Text;
            container.Clientes.Add(tempcliente);
            container.SaveChanges();
            nomeTextBox.Text = "";
            nIFTextBox.Text = "";
            contactoTextBox.Text = "";
            moradaTextBox.Text = "";
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);
        }
        private void GestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //apagar textboxes + atualizar tabela
        private void ClientesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);

            nomeTextBox.Text = "";
            nIFTextBox.Text = "";
            contactoTextBox.Text = "";
            moradaTextBox.Text = "";
            textBoxFiltrar.Text = "";
        }

    }
}
