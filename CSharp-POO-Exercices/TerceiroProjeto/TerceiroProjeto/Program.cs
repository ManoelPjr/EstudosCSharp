using System;
using System.Globalization;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 900.00);

            p.Nome = "TV 4k LCD";

            Console.WriteLine(p.Nome);
/*
            Console.WriteLine("Entre os  daos do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);
            Produto p1 = new Produto();
            Produto p3 = new Produto()
            {
                _nome = "TV",
                _preco = 900.00,
                _quantidade = 20
            };



            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade a ser removida do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

        }
    }
}

