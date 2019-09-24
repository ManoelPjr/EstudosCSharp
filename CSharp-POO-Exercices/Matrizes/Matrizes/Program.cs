using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); /*Tamanho total Linha + colunas*/
            Console.WriteLine(mat.Rank); /*Tamanho quantidade de linhas*/
            Console.WriteLine(mat.GetLength(0)); /*quantidade de linhas*/
            Console.WriteLine(mat.GetLength(1)); /*quantidade de colunas*/
        }
    }
}
