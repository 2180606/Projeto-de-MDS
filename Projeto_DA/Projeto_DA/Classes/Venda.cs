﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class Venda
    {
        public override string ToString()
        {
            return Valor + Estado + Data;
        }
    }
}
