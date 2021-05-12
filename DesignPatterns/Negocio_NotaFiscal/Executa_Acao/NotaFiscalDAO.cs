using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class NotaFiscalDAO : AcaoAposGerarNota

    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulando a inserção da Nota Fiscal no Banco de Dados");
        }
    }
}
