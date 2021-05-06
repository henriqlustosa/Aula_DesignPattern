
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //IImposto ikcp = new IKCP();
            //IImposto ippp = new IPPP();
            IImposto ihit = new IHIT();

            Orcamento orcamento = new Orcamento(1000.0);

            orcamento.AdicionaItem(new Item("CANETA", 1000));
            orcamento.AdicionaItem(new Item("CANETA",1000));

            orcamento.AdicionaItem(new Item("LAPIS", 200));

            //Não precisa utilizar a classe CalculadorDeImposto pois no metodo RealizaCalcula realiza a
            //seguinte operação:

            // Console.WriteLine(imposto.Calcula(orcamento));

            //Que pode ser alterado nesse código para->

            //Console.WriteLine(ikcp.Calcula(orcamento));
            //Console.WriteLine(ippp.Calcula(orcamento));
            Console.WriteLine(ihit.Calcula(orcamento));
           

            //Calculador de Imposto é responsável para impressão do valor do imposto

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, ikcp);
            //calculador.RealizaCalculo(orcamento, ippp);
            calculador.RealizaCalculo(orcamento, ihit);

            Console.ReadKey();

            //CalculadorDeDescontos calculador_desconto = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(100);
            //orcamento.AdicionaItem(new Item("CANETA", 500));


            //double desconto = calculador_desconto.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Console.ReadKey();


            // Teste do design pattern - chain of responsability para formatação da exibição dos 
            // dados da conta

            //Conta conta = new Conta("Jaqueline", 2000);
            //Formatador formatador = new Formatador();



            //formatador.Formata(new Requisicao(Formato.XML), conta);
            //formatador.Formata(new Requisicao(Formato.CSV), conta);

            //formatador.Formata(new Requisicao(Formato.PORCENTO), conta);

            //Console.ReadKey();


        }
    }
}
