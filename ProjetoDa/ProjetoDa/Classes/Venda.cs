using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class Venda
    {
        public Venda() { }
        public Venda(DateTime Data, decimal Valor, string Estado)
        {
            this.Data = Data;
            this.Valor = Valor;
            this.Estado = Estado;
        }
        public override string ToString()
        {
            return "Data Venda:"+ Data + " ; Valor da Venda:" + Valor + "; Estado: " + Estado ;
        }
    }
}
