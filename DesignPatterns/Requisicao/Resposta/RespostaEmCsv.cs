using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RespostaEmCsv : IResposta
    {

        public IResposta OutraResposta { get; private set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmCsv()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
   
        }

    }
}
