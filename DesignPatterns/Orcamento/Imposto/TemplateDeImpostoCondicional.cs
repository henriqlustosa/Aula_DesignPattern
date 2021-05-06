using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Orcamento.Imposto
{
    class TemplateDeImpostoCondicional : IImposto
    {
        public double  Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }
    }
}
