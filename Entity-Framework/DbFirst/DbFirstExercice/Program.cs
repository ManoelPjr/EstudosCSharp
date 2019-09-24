using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyDbContext();
            //context.AddVideo("Video 1", DateTime.Today, "Horror");
            //context.AddVideo("Video 2", DateTime.Today, "Action");
            context.AddVideo("Video 3", DateTime.Today, "Comedy");
        }
    }
}
