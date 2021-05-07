using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SaldoMaior500 : Filtro
    {
        public SaldoMaior500(Filtro outroFiltro) : base(outroFiltro) { }

        public SaldoMaior500() : base() { }

        public override IList<ContaBanco> Filtra(IList<ContaBanco> contas)
        {
            IList<ContaBanco> contasFiltradas = new List<ContaBanco>();
            foreach (ContaBanco c in contas)
            {
                if (c.Saldo > 500)
                    contasFiltradas.Add(c);
            }


            foreach (ContaBanco c in CalculoDoOutroFiltro(contas))
            {

                contasFiltradas.Add(c);
            }
            return contasFiltradas;
        }
    }
}
