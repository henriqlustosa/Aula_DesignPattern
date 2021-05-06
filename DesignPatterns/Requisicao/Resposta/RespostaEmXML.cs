using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class RespostaEmXML : IResposta
    {
        private IResposta OutraResposta { get; set; }

        public RespostaEmXML(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmXML()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
          

        }
    }
}
