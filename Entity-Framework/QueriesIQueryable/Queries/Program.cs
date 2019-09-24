using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var authors = context.Authors.ToList();
            var authorsIds = authors.Select(a => a.Id );

            context.Courses.Where(c => authorsIds.Contains(c.AuthorId) && c.FullPrice == 0).Load();

            foreach (var item in context.Courses)
            {
                Console.WriteLine("{0}", item.Author.Name);
            }

        }
    }
}
