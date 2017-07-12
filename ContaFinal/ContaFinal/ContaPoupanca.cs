using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFinal
{
    class ContaPoupanca :Conta
    {
        public ContaPoupanca(string nome, int numero, int idade, string bairro, string cidade, double saldo)
            : base(nome, numero, idade, bairro, cidade, saldo)
        {
        }
    }
}
