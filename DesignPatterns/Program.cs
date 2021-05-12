
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

            //Orcamento orcamento = new Orcamento(500);

            //orcamento.AdicionaItem(new Item("CANETA", 1000));
            //orcamento.AdicionaItem(new Item("CANETA",1000));
            //orcamento.AdicionaItem(new Item("LAPIS", 200));
            //orcamento.AdicionaItem(new Item("CANETA", 1000));
            //orcamento.AdicionaItem(new Item("CANETA", 1000));
            //orcamento.AdicionaItem(new Item("LAPIS", 200));

            //Imposto impostoComplexo = new ISS(new ICMS(new ImpostoMuitoAlto()));



            //double valor = impostoComplexo.Calcula(orcamento);

            //Console.WriteLine(valor);

            //Console.ReadKey();


            //ContaBanco conta_01 = new ContaBanco("Henrique Lustosa", "019203-00", "030201-00", 12, new DateTime(2021, 06, 14));
            //ContaBanco conta_02 = new ContaBanco("Sabrina", "010204-00", "039201-01", 50000000, new DateTime(2020, 07, 20));
            //ContaBanco conta_03 = new ContaBanco("Amariles", "010205-00", "033201-02", 100, new DateTime(2021, 01, 03));
            //ContaBanco conta_04 = new ContaBanco("Joice Maria", "010206-00", "036201-03", 50, new DateTime(2021, 02, 02));
            //ContaBanco conta_05 = new ContaBanco("Luciano", "010203-01", "037201-00", 2000, new DateTime(2021, 04, 14));
            //ContaBanco conta_06 = new ContaBanco("Lucas", "010204-02", "038201-01", 50000, new DateTime(2020, 03, 20));
            //ContaBanco conta_07 = new ContaBanco("Simone", "010205-03", "038201-02", 100, new DateTime(2021, 05, 03));
            //ContaBanco conta_08 = new ContaBanco("Sineide", "010206-04", "038201-03", 55, new DateTime(2021, 05, 02));


            //List<ContaBanco> contas = new List<ContaBanco>();

            //contas.Add(conta_01);
            //contas.Add(conta_02);
            //contas.Add(conta_03);
            //contas.Add(conta_04);
            //contas.Add(conta_05);
            //contas.Add(conta_06);
            //contas.Add(conta_07);
            //contas.Add(conta_08);

            //Filtro filtro =  new DataAberturaMes( new SaldoMaior500(new SaldoMenor100()));

            //IList<ContaBanco> contasFiltradas = filtro.Filtra(contas);

            //foreach(ContaBanco c in contasFiltradas)
            //{
            //    string v = c.DataAbertura.ToString();
            //    Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo + " - " + v );
            //}

            //Console.ReadKey();

            // Orcamento reforma = new Orcamento(500);
            // Console.WriteLine(reforma.Valor);

            // reforma.AplicaDescontoExtra();
            // Console.WriteLine(reforma.Valor);

            // reforma.Aprova();
            // reforma.AplicaDescontoExtra();
            // Console.WriteLine(reforma.Valor);

            // reforma.Finaliza();
            // Console.WriteLine(reforma.Valor);


            //Console.ReadKey(); 


            // Implementação do Design Pattern State para um conta bancária
            // Onde os estados da classe ContaBanco são os seguintes:
            // Positivo e Negativo
            // e os métodos implementados pelas classses concretas são  Saca() e Deposita()

            //ContaBanco conta_01 = new ContaBanco("Henrique Lustosa", "019203-00", "030201-00", 12, new DateTime(2021, 06, 14));
            //ContaBanco conta_02 = new ContaBanco("Sabrina", "010204-00", "039201-01", 50000000, new DateTime(2020, 07, 20));

            //conta_01.Saca(500);
            //conta_01.Saca(500);
            //Console.WriteLine(conta_01.Saldo);
            //conta_01.Deposita(1000);

            //Console.WriteLine(conta_01.Saldo);

            // Implementação do Design Pattern Builder: 
            // Sem a utilização do Design Builder para criar uma nova nota fiscal
            // a classe teste teria que seguir muitos passos que dificultariam
            // a implementação. Além de um construtor recebendo muitos parâmetros.


            //IList<ItemDaNota> itens = new List<ItemDaNota>();

            //double valorTotal = 0;

            //foreach(ItemDaNota item in itens)
            //{
            //    valorTotal += item.Valor;

            //}

            //double impostos = valorTotal * 0.05;


            //NotaFiscal nf = new NotaFiscal("RazaoSocial", "cnpj", DateTime.Now, valorTotal, impostos, itens, "obs qualquer");

            //Console.ReadKey();


            // Utilizando o construtor a classe teste fica mais intelegível para a criaçõa
            // da nota fiscal.
            

            // Implementando o Design Pattern Observer para controlar as ações que são realizadas no método Constroi da construção de uma nota fiscal

            NotaFiscalBuilder builder = new NotaFiscalBuilder();

            builder.AdicionaAcao(new Impressora());
            builder.AdicionaAcao(new NotaFiscalDAO());
            builder.AdicionaAcao(new EnviadorDeSms());
            builder.AdicionaAcao(new EnviadorDeEmail());


            NotaFiscal nf = builder.ParaEmpresa("Caelum")
                                  .ComCnpj("123.456.789/0001-10")
                                  .ComItem(new ItemDaNota("item 1", 100.0))
                                  .ComItem(new ItemDaNota("item 2", 200.0))
                                  .ComItem(new ItemDaNota("item 3", 300.0))
                                  .ComObservacoes("entregar nf pessoalmente")
                                  .NaDataAtual()
                                  .Constroi();

        }
    }

}
