using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Negativo : IEstadoDaConta
    {
        public void Deposita(ContaBanco conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positivo();
        }

        public void Saca(ContaBanco conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }
    }
}
