namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //1º Regra: Mais de 5 itens
            if(orcamento.Itens.Count >5)
            {
                return orcamento.Valor * 0.1;
            }
            //2º Regra: O valor do orcamento eh maior que 500
            else if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.007;
            }

            return 0;

            // com as regras de desconto
        }

    }
}