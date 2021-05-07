using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{   
    public abstract class Filtro
    {

        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;

        }
        public  Filtro()
        {
            this.OutroFiltro = null;
        }
        public abstract IList<ContaBanco> Filtra(IList<ContaBanco> contas);

        protected IList<ContaBanco> CalculoDoOutroFiltro(IList<ContaBanco> contas) => (OutroFiltro == null ? new List<ContaBanco>() : OutroFiltro.Filtra(contas));
    }
}
