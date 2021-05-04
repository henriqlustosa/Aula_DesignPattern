namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
          double desconto = new DescontoPorCincoItens().Desconta(orcamento);
          if (desconto == 0)
          {
              desconto = new DescontoPorMaisQuinhentosReais().Desconta(orcamento);

              // if (desconto == 0) ...
          }

        return desconto;
        }

    }
}