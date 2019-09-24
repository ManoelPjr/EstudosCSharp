using Interpreter.Expressions;
using Interpreter.TheContext;
using System;
using System.Collections.Generic;
/// <summary>
/// This code demonstrates the Interpreter pattern which is used to change 
/// a Roman numbers to decimal.
/// </summary>
namespace Interpreter
{
    /// <summary> 
    /// Interpreter Design Pattern.
    /// </summary>
    class Client
    {
        static void Main()
        {
            string roman = "MMXVII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");

            // Wait for user
            Console.ReadKey();


        }
    }
}
