using System;
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

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);
        }
    }
}
