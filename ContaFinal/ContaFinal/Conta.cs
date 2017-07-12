using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFinal
{
    public class Conta
    {

        public string nome { get; private set; }
        public int numero { get; private set; }
        public int idade { get; private set; }
        public string bairro { get; private set; }
        public string cidade { get; private set; }
        public double saldo { get; private set; }

        public Conta( string nome, int numero, int idade, string bairro, string cidade, double saldo)
        {
            this.nome = nome;
            this.numero = numero;
            this.idade = idade;
            this.bairro = bairro;
            this.cidade = cidade;
            this.saldo = saldo;
        }

        public Conta()
        {
        }

        public void saca(double valor)
        {
            if (valor < saldo)
            {
                saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void deposita(double valor)
        {
            if (valor >  0)
            {
                saldo += valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void tranferencia(Conta c,double valor)
        {
            this.saldo -= valor;
            c.saldo += valor;
        }
    }
}
