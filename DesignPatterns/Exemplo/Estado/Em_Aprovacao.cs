using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Em_Aprovacao : IEstadoDeUmOrcamento
    {
        // Variável que indica se a aplicação do desconto extra já foi realizada alguma vez.
        bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {

            // Condicional para verificação do desconto aplicado
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }


        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();

        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }

    }
}
