using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IPPP
    {
        public double Calcula(Orcamento orcamento)
        {
            if(orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento))
            {
                return orcamento.Valor * 0.1;

            }

            return orcamento.Valor * 0.006;

        }
        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
