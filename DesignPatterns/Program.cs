using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);
            
            //Calculador de Imposto é responsável para impressão do valor do imposto
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);

            Console.ReadKey();

        }
    }
}
