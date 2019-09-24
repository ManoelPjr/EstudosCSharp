using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 30);
            Console.WriteLine(result);
            /* o modificador ref exige que a variável 
             * passada tenha sido inicializada
             */
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            /* Já o modificador out não exige 
             * a inicialização da variável 
             * de retorno*/

            int b = 10;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(b);
            Console.WriteLine(triple);

            /*O uso do [ref e do out] é 
             * considerado uma má prática de programação
             e deve ser evitado, para este fim existe o [return]*/
            int c = 5;
            int tripleBoasPraticas = Calculator.TripleBoaPratica(c); 
        
            Console.WriteLine(c);
            Console.WriteLine(tripleBoasPraticas);
        }
    }
}
