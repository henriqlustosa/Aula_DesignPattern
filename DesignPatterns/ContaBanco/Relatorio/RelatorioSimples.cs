using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class RelatorioSimples  : IRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<ContaBanco> contas)
        {
            foreach (ContaBanco c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}
