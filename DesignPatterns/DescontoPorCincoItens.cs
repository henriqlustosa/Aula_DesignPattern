using System;
namespace DesignPatterns
{
    public class DescontoPorCincoItens
    {
        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.05;
            }
            return 0;
        }
    }
}