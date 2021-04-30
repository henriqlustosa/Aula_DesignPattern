using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, String imposto)
        {


            if( "ICMS".Equals(imposto))
            {
                double icms = new ICMS().CalculoICMS(orcamento);
                Console.WriteLine(icms);
            }
            else if( "ISS".Equals(imposto))
            {
                double iss = new ISS().CalculoISS(orcamento);
                Console.WriteLine(iss);
            }
        }
        

    }
}
