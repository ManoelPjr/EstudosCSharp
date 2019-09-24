using System;
using System.Globalization;

namespace PrimeiroExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();
            double salarioMedio;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
