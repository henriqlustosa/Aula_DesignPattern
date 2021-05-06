using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ContaBanco
    {
        public String Nome { get; private set; }
        public String Numero { get; private set; }
        public String Agencia { get; private set; }
        public double Saldo { get; private set; }



        public ContaBanco(String nome, String numero, String agencia, double saldo)
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
        }

    }
}
