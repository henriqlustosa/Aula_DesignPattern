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
            
            

            // Não precisa utilizar a classe CalculadorDeImposto pois no metodo RealizaCalcula realiza a 
            // seguinte operação:
            
            // Console.WriteLine(imposto.Calcula(orcamento));
            
            // Que pode ser alterado nesse código para ->
            
            // Console.WriteLine(iss.Calcula(orcamento))
            // Console.WriteLine(icms.Calcula(orcamento))


            //Calculador de Imposto é responsável para impressão do valor do imposto

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);

            Console.ReadKey();

        }
    }
}
