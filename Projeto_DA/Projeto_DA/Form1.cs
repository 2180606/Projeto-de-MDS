using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Form1 : Form
    {
        private StandAutomoveisContainer standAutomoveis;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            standAutomoveis = new StandAutomoveisContainer();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente tempCliente = new Cliente();
            int.TryParse(textBox2.Text, out int tempNIF);
            tempCliente.Nome =    textBox1.Text; //Nome Cliente
            tempCliente.NIF = tempNIF;// NIF Cliente
            tempCliente.Morada = textBox3.Text; // Morada Cliente
            tempCliente.Contacto = textBox4.Text;// Contacto Cliente
            
            listBox1.Items.Add(tempCliente);
            //tempCliente
            //standAutomoveis
        }

       
    }
}
