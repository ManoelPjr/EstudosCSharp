using System;

namespace lacoforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            /*  For normal */
            for (int i = 0; i<vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("----------------------------");
            /*  Foreach */
            foreach(string nome in vect)
            {
                Console.WriteLine(nome);
            }


        }
    }
}
