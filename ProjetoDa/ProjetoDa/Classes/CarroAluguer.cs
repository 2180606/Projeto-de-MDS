using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class CarroAluguer
    {
        public CarroAluguer(string NumeroChassis, string Marca, string Modelo, string Combustivel, string Estado, string Matricula)
        {
            this.NumeroChassis = NumeroChassis;
            this.Marca = Marca;
            this.Matricula = Matricula;
            this.Modelo = Modelo;
            this.Combustivel = Combustivel;
            this.Estado = Estado;
        }
    }
}
