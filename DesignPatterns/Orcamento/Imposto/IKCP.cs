using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class IKCP
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500 )
            {
                return orcamento.Valor * 0.1;

            }

            return orcamento.Valor * 0.006;

        }
      
    }
}
