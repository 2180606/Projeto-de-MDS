﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDa
{
    partial class CarroVenda
    {
        public CarroVenda(string NumeroChassis, string Marca, string Modelo, string Combustivel, string Extras)
        {
            this.NumeroChassis = NumeroChassis;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Combustivel = Combustivel;
            this.Extras = Extras;
        }
    }
}