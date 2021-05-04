using System;
namespace DesignPatterns
{
    public class DescontoPorMaisQuinhentosReais
    {
        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return 0;
        }
    }
}