using System;
namespace DesignPatterns
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.05;
            }

            else
            {
                return Proximo.Desconta(orcamento);
            }
             
        }
    }
}