using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {

        public void RealizaCalculoICMS(Orcamento orcamento)
        {
             double icms = new ICMS().CalculoICMS(orcamento);
             Console.WriteLine(icms);
        }
        

        public void RealizaCalculoISS(Orcamento orcamento, String imposto)
        {
             double icms = new ISS().CalculoISS(orcamento);
             Console.WriteLine(icms);
        }



    }
}
