using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class Aluguer
    {
        public Aluguer() { }
        public Aluguer(DateTime DtaInicio, DateTime DataFim, decimal Valor, int Kms)
        {
            this.DataInicio = DtaInicio;
            this.DataFim = DataFim;
            this.Valor = Valor;
            this.Kms = Kms;
        }
    }
}
