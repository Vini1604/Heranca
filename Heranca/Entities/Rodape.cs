using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Rodape
    {
        public decimal ValorTotal { get; set; }

        public override string ToString()
        {
            return $"Total da nota fiscal: R$ {ValorTotal:F2}";
        }
    }
}
