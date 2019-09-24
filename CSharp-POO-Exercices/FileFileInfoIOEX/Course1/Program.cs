using System;
using System.IO;


namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\file1.txt";
            //Maneira 4 de fazer
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }                      
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred !");
                Console.WriteLine(e.Message);
            }
            //Maneira 3 de fazer
            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred !");
            //    Console.WriteLine(e.Message);
            //}

            ////Maneira 2 de fazer
            //StreamReader sr = null;
            //StreamReader sr2 = null;
            //try
            //{
            //    sr = File.OpenText(path);
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    sr2 = File.OpenText(path);
            //    while (!sr2.EndOfStream)
            //    {
            //        string lines = sr2.ReadLine();
            //        Console.WriteLine(lines);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred !");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //    if (sr2 != null)
            //    {
            //        sr2.Close();
            //    }
            //}
            //Maneira um de fazer
            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException e)
            //{

            //    Console.WriteLine("An error occurred !");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //    if (fs != null)
            //    {
            //        fs.Close();
            //    }
            //}
        }
    }
}
