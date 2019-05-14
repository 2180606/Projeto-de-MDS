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
    public partial class Form1 : Form
    {
        private BaseDadosContainer container;
        public Form1()
        {
            InitializeComponent();
            container = new BaseDadosContainer();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente tempCliente = new Cliente();
            Cliente clienteSelecionado = new Cliente();
            int.TryParse(textBox2.Text, out int tempNIF);
            tempCliente.Nome = textBox1.Text; //Nome Cliente
            tempCliente.NIF = tempNIF;// NIF Cliente
            tempCliente.Morada = textBox3.Text; // Morada Cliente
            tempCliente.Contacto = textBox4.Text;// Contacto Cliente
            container.Clientes.Add(tempCliente);
            container.SaveChanges();

        }
    }
}
