using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class CarroOficina
    {

        public override string ToString()
        {
            return Marca + Modelo + Combustivel + NumeroChassis + Matricula + Kms;
        }
    }
}
