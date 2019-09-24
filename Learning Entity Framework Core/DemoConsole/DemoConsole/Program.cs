using DemoConsole.Entities;
using System;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seed
            using (var db = new ActorDbContext())
            {
                if (!db.Actors.Any())
                {
                    //DB has been seeded ???
                    db.AddRange(new Actor { Name = "Manoel Jr", Age = 49, AcademyWinner = false },
                    new Actor { Name = "Manoel Pedro", Age = 48, AcademyWinner = true },
                    new Actor { Name = "Carlos Augusto", Age = 50, AcademyWinner = false });
                    var count = db.SaveChanges();
                    Console.WriteLine($"{count} - Records added");                    
                }


                foreach (var actor in db.Actors)
                {
                    Console.WriteLine($"Name - {actor.Name},\t\t" +
                        $"Age - {actor.Age},\t\t" +
                        $"Academy winner - {actor.AcademyWinner}");
                }
            }
            Console.ReadKey();
        }
    }
}
