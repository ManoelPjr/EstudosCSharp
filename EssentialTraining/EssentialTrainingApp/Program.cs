using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger =  LogManager.GetCurrentClassLogger();
        public static List<string> words;
        static void Main(string[] args)
        {
            logger.Trace("The programm starterd");
            words = new List<string>();
            words.Add("Bread");
            words.Add("Milk");
            words.Add("Cheese");
            words.Add("Apples");

            CrazyMathProblem();
            ReadTextFile();

            logger.Trace("App is finished");
            Console.ReadKey();
        }
        private static void ReadTextFile()
        {
            try
            {
                using(var sr = new StreamReader(@"C:\Temp\Test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                logger.Error(e.Message);
            }
            finally
            {
                Console.WriteLine("Aqui é bloco Finnaly do try");
            }
        } 
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (int i = 10; i < 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
