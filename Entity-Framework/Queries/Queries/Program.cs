using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            ////LINQ Syntax
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("c#")
            //    orderby c.Name
            //    select c;

            //foreach (var course in query)
            //    Console.WriteLine(course.Name);

            //// Extensions methods
            //var courses = context.Courses
            //    .Where(c => c.Name.Contains("c#"))
            //    .OrderBy(c => c.Name);

            //foreach (var course in courses)
            //    Console.WriteLine(course.Name);


            //Restriction
            Console.WriteLine("Restriction");
            var query =
                from c in context.Courses
                where c.Level == 1 && c.Author.Id == 1
                select c;
            foreach (var course in query)
                Console.WriteLine(course.Name);

            //Ordering
            Console.WriteLine("Ordering");
            var query1 =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Name
                select c;
            foreach (var course in query1)
                Console.WriteLine(course.Name);

            //Projection
            Console.WriteLine("Projection");
            var query2 =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Name
                select new {Name = c.Name, Author = c.Author };
            foreach (var course in query2)
                Console.WriteLine(course.Name);

            //Grouping
            Console.WriteLine("Grouping");
            var query3 =
                from c in context.Courses
                group c by c.Level
                into g
                select g;
            foreach (var group in query3)
            {
                Console.WriteLine(group.Key);

                foreach (var course in group)
                    Console.WriteLine("\t{0}", course.Name);

            }
            Console.WriteLine("-----------------------------");
            foreach (var group in query3)
            {
                Console.WriteLine("{0} ({1})",group.Key, group.Count());
            }

            //Joining
            Console.WriteLine("Joining");

            var query4 =
                from c in context.Courses
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = a.Name };

            foreach (var group in query4)
            {
                Console.WriteLine("{0} ({1})", group.CourseName, group.AuthorName);
            }

            //Group Join
            Console.WriteLine("Group Join");
            var query5 =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, Courses = g.Count() };
            foreach (var x in query5)
            {
                Console.WriteLine("{0} ({1})", x.AuthorName, x.Courses);
            }

            //Cross Join
            Console.WriteLine("Cross Join");
            var query6 =
                from a in context.Authors
                from c in context.Courses
                select new { AuthorName = a.Name, CourseName = c.Name };

            foreach (var x in query6)
            {
                Console.WriteLine("Author: {0} - Course: {1}", x.AuthorName, x.CourseName);
            }

        }
    }
}
