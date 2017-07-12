using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFinal
{
    internal class ContaCorrente : Conta
    {

        public ContaCorrente(string nome, int numero, int idade, string bairro, string cidade, double saldo)
            : base(nome, numero, idade, bairro, cidade, saldo)
        {
        }
    }
}
