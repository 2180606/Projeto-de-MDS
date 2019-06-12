using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class Servico
    {
        public Servico(DateTime DataEntrada, String Tipo, DateTime DataSaida)
        {
            this.DataEntrada = DataEntrada;
            this.DataSaida = DataSaida;
            this.Tipo = Tipo;
            
        }
        public override string ToString()
        {
            return Tipo + ": de " + DataEntrada.ToShortDateString()+" até "+ DataSaida.ToShortDateString();
        }
    }
}
