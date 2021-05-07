
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //IImposto ikcp = new IKCP();
            //IImposto ippp = new IPPP();
            //IImposto ihit = new IHIT();

            //Orcamento orcamento = new Orcamento(1000.0);

            //orcamento.AdicionaItem(new Item("CANETA", 1000));
            //orcamento.AdicionaItem(new Item("CANETA",1000));

            //orcamento.AdicionaItem(new Item("LAPIS", 200));

            //Não precisa utilizar a classe CalculadorDeImposto pois no metodo RealizaCalcula realiza a
            //seguinte operação:

            // Console.WriteLine(imposto.Calcula(orcamento));

            //Que pode ser alterado nesse código para->

            //Console.WriteLine(ikcp.Calcula(orcamento));
            //Console.WriteLine(ippp.Calcula(orcamento));
            //Console.WriteLine(ihit.Calcula(orcamento));


            //Calculador de Imposto é responsável para impressão do valor do imposto

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, ikcp);
            //calculador.RealizaCalculo(orcamento, ippp);
            //calculador.RealizaCalculo(orcamento, ihit);

            //Console.ReadKey();

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

            // Exemplo utilizando o dominio de uma conta do Banco
            // Neste caso os impostos possuem uma estrutura comum: Taxação minima, Taxação máxima e uma condição de cálculo de taxação

            //ContaBanco conta_01 = new ContaBanco("Henrique Lustosa", "010203-00", "030201-00", 500);
            //ContaBanco conta_02 = new ContaBanco("Sabrina", "010204-00", "030201-01", 500);
            //ContaBanco conta_03 = new ContaBanco("Amariles", "010205-00", "030201-02", 500);
            //ContaBanco conta_04 = new ContaBanco("Joice Maria", "010206-00", "030201-03", 500);


            //IRelatorio relatorioSimples = new RelatorioSimples();
            //IRelatorio relatorioComplexo = new RelatorioComplexo();

            //List<ContaBanco> contas = new List<ContaBanco>();
            //contas.Add(conta_01);
            //contas.Add(conta_02);
            //contas.Add(conta_03);
            //contas.Add(conta_04);

            //relatorioSimples.Imprime(contas);
            //Console.ReadKey();
            //relatorioComplexo.Imprime(contas);
            //Console.ReadKey();

            // Problema: No dominio do imposto o calculo pode ser uma composicao desses impostos
            // Por exemplo: ICMS e o ISS incidem no calculo ao mesmo tempo, ou ainda o imposto 
            // ICPP pode compor o calculo.

            //Imposto iss = new ISScomICMS(); ?????!!!!!!  - muitas combinacoes
            //           ou
            //Imposto iss = new ISS(new ICMS( new ICPP));  - solucao mais elegante

            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("CANETA", 1000));
            orcamento.AdicionaItem(new Item("CANETA",1000));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("CANETA", 1000));
            orcamento.AdicionaItem(new Item("CANETA", 1000));
            orcamento.AdicionaItem(new Item("LAPIS", 200));

            Imposto iss = new ISS(new ICMS(new IHIT()));

           

            double valor = iss.Calcula(orcamento);
            
            Console.WriteLine(valor);

            Console.ReadKey();




        }
    }
}
