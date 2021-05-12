﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public DateTime Data { get; set; }
        public String Observacoes { get; set; }
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();


        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this; // retorno eu mesmo, o próprio builder, para que o cliente continue utilizando
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

           

            return this;
        }

        private void enviaPorEmail(NotaFiscal nf)
        {
            Console.WriteLine("Simulando o envio de Nota fiscal por email ");
        }

        private void salvaNoBanco(NotaFiscal nf)
        {
            Console.WriteLine("Simulando o salvamento da Nota fiscal  no Banco de Dados. ");

        }

        private void enviaPorSms(NotaFiscal nf)
        {
            Console.WriteLine("Simulando o envio da Nota Fiscal por SMS.");
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);

            new EnviadorDeEmail().EnviaPorEmail(nf);
            new NotaFiscalDAO().SalvaNoBanco(nf);
            new EnviadorDeSms().EnviaPorSms(nf);
            new Impressora().Imprime(nf);


            return nf;

        }
    }
}
