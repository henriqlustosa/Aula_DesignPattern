using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Formatador
    {
        public void Formata(Requisicao requisicao, Conta conta)
        {
      
            IResposta f3 = new RespostaEmPorcento();
         
            IResposta f2 = new RespostaEmCsv(f3);
            IResposta f1 = new RespostaEmXML(f2);


            //Regra do encadeamento das respostas às requisicoes
            //f1.OutraResposta = f2;
            //f2.OutraResposta = f3;

            f1.Responde(requisicao, conta);
        }
    }
}
