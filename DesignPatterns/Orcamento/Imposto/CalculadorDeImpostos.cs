using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, Imposto imposto )
        {
            
            Console.WriteLine(imposto.Calcula(orcamento));
        }
       
    
    }
}
