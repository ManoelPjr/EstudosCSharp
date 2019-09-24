using Course2.Services;
using System;

namespace Course2
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            //BinaryNumericOperation op = CalculationService.Square;
            BinaryNumericOperation op = CalculationService.Max;
            //BinaryNumericOperation op = CalculationService.Sum;

            //double result = CalculationService.Square(a);
            double result = op(a,b);
            Console.WriteLine(result);
        }
    }
}
