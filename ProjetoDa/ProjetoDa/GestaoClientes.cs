﻿using System;
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

        int selectedRow;

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDADataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);

            textBoxNomeCliente.MaxLength = 9;

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

        private void ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.baseDadosDADataSet.Clientes);



            //this.Validate();
            //this.clientesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.baseDadosDADataSet);

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //converter string to int
            int MyInteger = Convert.ToInt32(TextBoxNifCliente.Text);

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
                if (MyInteger == cliente.NIF)
                {
                    MessageBox.Show("O Cliente com o respetivo NIF ja se encontra inserido na base de dados");
                    TextBoxNifCliente.Select();
                    return;
                }
            }
            
            tempcliente.Nome = textBoxNomeCliente.Text;
            tempcliente.NIF = MyInteger;
            tempcliente.Morada = textBoxMoradaCliente.Text;
            tempcliente.Contacto = textBoxContactoCliente.Text;


            container.Clientes.Add(tempcliente);

            textBoxNomeCliente.Clear();
            TextBoxNifCliente.Clear();
            textBoxContactoCliente.Clear();
            textBoxMoradaCliente.Clear();
      

            container.SaveChanges();
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void BindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {

            // delete datagridview row selected row
            selectedRow = clientesDataGridView.CurrentCell.RowIndex;
            clientesDataGridView.Rows.RemoveAt(selectedRow);

        }


        private void ClientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.clientesDataGridView.Rows[e.RowIndex];



            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxNomeCliente.Text = row.Cells[1].Value.ToString();
                TextBoxNifCliente.Text = row.Cells[2].Value.ToString();
                textBoxContactoCliente.Text = row.Cells[3].Value.ToString();
                textBoxMoradaCliente.Text = row.Cells[4].Value.ToString();

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            selectedRow = clientesDataGridView.CurrentCell.RowIndex;
            clientesDataGridView.Rows.RemoveAt(selectedRow);
        }
    }
}
