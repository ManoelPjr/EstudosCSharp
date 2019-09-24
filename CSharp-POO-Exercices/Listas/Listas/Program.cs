using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();
            

            Lista.Add("Maria");
            Lista.Add("Alex");
            Lista.Add("Bob");
            Lista.Add("Anna");
            Lista.Insert(2, "Marco");
            foreach (string nome in Lista)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("List count: " + Lista.Count);

            string nomeEncontrado = Lista.Find(x => x[0] == 'A');
            Console.WriteLine("Frist Name: "+nomeEncontrado);

            string ultimoNomeEncontrado = Lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last Name: " + ultimoNomeEncontrado);

            int primeiraPosicao = Lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Firs Position 'A': " + primeiraPosicao);

            int ultimaPosicao = Lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + ultimaPosicao);

            List<string> Lista2 = Lista.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");
            foreach(string nome in Lista2)
            {
                Console.WriteLine(nome);
            }

            Lista.RemoveRange(2,2);
            Console.WriteLine("----------------------------------");
            foreach (string nome in Lista)
            {
                Console.WriteLine(nome);
            }

            Lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (string nome in Lista)
            {
                Console.WriteLine(nome);
            }


        }
    }
}
