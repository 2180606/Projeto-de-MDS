using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class CarroVenda
    {
        public override string ToString()
        {
            return Extras+Marca+Modelo+NumeroChassis+Combustivel;
        }
    }
}
