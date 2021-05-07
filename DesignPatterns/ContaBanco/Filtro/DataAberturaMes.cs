using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DataAberturaMes : Filtro
    {
        public DataAberturaMes(Filtro outroFiltro) : base(outroFiltro) { }

        public DataAberturaMes() : base() { }
        public override IList<ContaBanco> Filtra(IList<ContaBanco> contas)
        {

       

            IList<ContaBanco> filtrada = new List<ContaBanco>();
            foreach (ContaBanco c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month &&
                  c.DataAbertura.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }

            foreach (ContaBanco c in CalculoDoOutroFiltro(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;

        }
    }
}
