namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens() ;
            IDesconto d2 = new DescontoPorMaisQuinhentosReais();
            IDesconto d3 = new SemDesconto();
            
            d1.Proximo = d2;
            d2.Proximo = d3;
            
          return d1.Desconta(orcamento);
        }

    }
}