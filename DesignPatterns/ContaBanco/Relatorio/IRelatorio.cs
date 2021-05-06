using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class IRelatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<ContaBanco> contas);

        public void Imprime(IList<ContaBanco> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
