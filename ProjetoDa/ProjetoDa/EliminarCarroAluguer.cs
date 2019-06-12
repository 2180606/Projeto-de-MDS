using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDa
{
    public partial class EliminarCarroAluguer : Form
    {
        BaseDadosDAContainer container;
        public EliminarCarroAluguer(BaseDadosDAContainer containerImp)
        {
            InitializeComponent();
            container = containerImp;
        }

        private void EliminarCarroAluguer_Load(object sender, EventArgs e)
        {
            listBoxCarrosAluguer.DataSource = container.Carros.OfType<CarroAluguer>().ToList();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxCarrosAluguer.SelectedIndex != -1)
            {
                CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
                foreach (Aluguer aluguer in container.Alugueres)
                {
                    if (aluguer.CarroAluguer == carroSelecionado)
                    {
                        MessageBox.Show("Não é possivel apagar um carro que já foi alugado.");
                        textBoxNumeroChassis.Clear();
                        return;
                    }
                }
                if (textBoxNumeroChassis.Text != carroSelecionado.NumeroChassis)
                {
                    MessageBox.Show("O numero de Chassis não corresponde ao do veiculo selecionado");
                    textBoxNumeroChassis.Select();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende eliminar o carro selecionado?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    container.Carros.Remove(carroSelecionado);
                    container.SaveChanges();
                    MessageBox.Show("Carro Apagado com Sucesso");
                    this.Close();
                }
            }
        }
    }
}
