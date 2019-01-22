using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Generos> _Generos = new List<Generos>();
            //Generos g1 = new Generos();
            //   g1.Id = 1;
            //   g1.Nome = "Rock";
            //   _Generos.Add(g1); 


            var generos = new List<Generos>
            {
                new Generos { Id = 1, Nome = "Rock" },
                new Generos { Id = 2, Nome = "Reggae" },
                new Generos { Id = 3, Nome = "Rock Progressivo" },
                new Generos { Id = 4, Nome = "Jazz" },
                new Generos { Id = 5, Nome = "Punk Rock" },
                new Generos { Id = 6, Nome = "Clássica" }
            };

            List<Musicas> musicas = new List<Musicas>
            {
                new Musicas { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
                new Musicas { Id = 2, Nome = "I Shot The Sheriff", GeneroId = 2 },
                new Musicas { Id = 3, Nome = "Danúbio Azul", GeneroId = 6 }
            };

            Console.WriteLine();

            var queryMusicas = from m in musicas
                       join g in generos on m.GeneroId equals g.Id
                       select new
                       {
                           MusicaId = m.Id,
                           Musica = m.Nome,
                           Genero = g.Nome
                       };

            var qyLab = queryMusicas.Where(c => c.Musica.Equals("Danúbio Azul"));

            foreach (var qy in qyLab)
            {
                //Console.WriteLine(qy.Musica +" - "+qy.Genero);
                Console.WriteLine("{0} - {1} / {2}", qy.MusicaId,qy.Musica, qy.Genero);
            }

            Console.ReadKey();        

        }
    }
}
