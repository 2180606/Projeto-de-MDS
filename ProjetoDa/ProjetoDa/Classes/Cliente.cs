using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class Cliente
    {
        public Cliente(string Nome, string Morada, int NIF, string Contacto)
        {
            this.Contacto = Contacto;
            this.Morada = Morada;
            this.NIF = NIF;
            this.Nome = Nome;
            this.CarrosOficina = new HashSet<CarroOficina>();
            this.Alugueres = new HashSet<Aluguer>();
            this.Vendas = new HashSet<Venda>();
        }
    }
}
