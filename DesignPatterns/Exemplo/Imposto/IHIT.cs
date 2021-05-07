using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemComMesmoNomeNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return  0.01 * orcamento.Itens.Count() + CalculoDoOutroImposto(orcamento);
        }


        private bool temItemComMesmoNomeNo(Orcamento orcamento)
        {

            IList<String> noOrcamento = new List<String>();
            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }
            return false;
        }
    }
}


