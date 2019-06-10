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
        public Venda(DateTime Data, decimal Valor, string Estado,CarroVenda carroSelecionado)
        {
            this.Data = Data;
            this.Valor = Valor;
            this.Estado = Estado;
            this.CarroVenda = carroSelecionado;
        }
        public override string ToString()
        {
            return "User: "+ Cliente.Nome + "; Data Venda: "+ Data + " ; Valor da Venda:" + Valor + "; Estado: " + Estado ;
        }
    }
}
