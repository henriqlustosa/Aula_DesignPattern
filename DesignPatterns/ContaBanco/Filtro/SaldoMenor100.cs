using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SaldoMenor100 : Filtro
    {
        public SaldoMenor100(Filtro outroFiltro) : base(outroFiltro) { }

        public SaldoMenor100() : base() { }


        public override IList<ContaBanco> Filtra(IList<ContaBanco> contas)
        {
            IList<ContaBanco> contasFiltradas = new List<ContaBanco>();
            foreach (ContaBanco c in contas)
            {
                if (c.Saldo < 100) contasFiltradas.Add(c);
            }
            foreach (ContaBanco c in CalculoDoOutroFiltro(contas))
            {
                 contasFiltradas.Add(c);
            }
            return contasFiltradas;
        }



    }
}
