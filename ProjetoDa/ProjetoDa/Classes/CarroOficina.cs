using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class CarroOficina
    {
        public CarroOficina(string NumeroChassis, string Marca, string Modelo, string Combustivel, string Matricula,int Kms)
        {
            this.NumeroChassis = NumeroChassis;
            this.Marca = Marca;
            this.Matricula = Matricula;
            this.Modelo = Modelo;
            this.Combustivel = Combustivel;
            this.Kms = Kms;
            this.Servicos = new HashSet<Servico>();
        }
        public override string ToString()
        {
                return NumeroChassis + ", " + Combustivel + ": " + Kms;
        }
    }
}
