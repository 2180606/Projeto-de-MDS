using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class Cliente
    {
        public Cliente(string Nome,string Morada,int NIF, string Contacto )
        {
            this.Contacto = Contacto;
            this.Morada = Morada;
            this.NIF = NIF;
            this.Nome = Nome;
            this.CarroOficina = new HashSet<CarroOficina>();
            this.Venda = new HashSet<Venda>();
            this.Aluguer = new HashSet<Aluguer>();

        }
        public override string ToString()
        {
            return Nome + "(" + NIF +Morada+Contacto+ ")";
        }
    }
}
