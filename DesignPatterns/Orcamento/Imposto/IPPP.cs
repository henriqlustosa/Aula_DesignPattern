﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IPPP : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.03;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.007;
        }


        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
