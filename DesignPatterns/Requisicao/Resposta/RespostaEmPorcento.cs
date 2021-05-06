using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RespostaEmPorcento : IResposta
    {
        private IResposta OutraResposta { get;  set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
          

        }


        }
}
