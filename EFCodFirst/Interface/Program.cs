using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.data.Models;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new BDEstudoContext();
            var cliente = contexto.Clientes.Include("Bairro").FirstOrDefault(p => p.strNOME == "Charles Messias Bezerra");

            if (cliente.strNOME != null) Console.WriteLine(cliente.strNOME);

            Console.ReadLine();
        }
    }
}
