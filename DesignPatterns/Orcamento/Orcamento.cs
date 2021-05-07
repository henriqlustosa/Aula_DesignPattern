using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {

        public int EM_APROVACAO = 1;
        public int APROVADO = 2;
        public int REPROVADO = 3;
        public int FINALIZADO = 4;

        public int EstadoAtual { get; set; }
        public double Valor { get; private set;}
        public IList<Item> Itens {get; private set;}
        public Orcamento(double valor) 
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AplicaDescontoExtra()
        {
            if (EstadoAtual == EM_APROVACAO) Valor = Valor - (Valor * 0.05);
            else if (EstadoAtual == APROVADO) Valor = Valor - (Valor * 0.02);
            else throw new Exception(" Orcamentos reprovados/finalizados nao recebem desconto extra");
        }


        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
