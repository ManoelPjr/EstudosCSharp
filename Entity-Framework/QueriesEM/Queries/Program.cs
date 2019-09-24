using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //Restriction
            Console.WriteLine("--------------Restriction--------------");

            var courses = context.Courses.Where(c => c.Level == 1);
            foreach (var course in courses)
            {
                Console.WriteLine("Course: {0} - Leve: {1}", course.Name, course.Level);
            }

            //Ordering
            Console.WriteLine("--------------Ordering--------------");
            var courses1 = context
                .Courses.Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(C => C.Level);

            foreach (var course in courses1)
            {
                Console.WriteLine("Course: {0} - Leve: {1}", course.Name, course.Level);
            }

            //Projection
            Console.WriteLine("--------------Projection--------------");
            var tags = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(C => C.Level)
                .SelectMany(c => c.Tags);
            foreach (var t in tags)
            {
                Console.WriteLine(t.Name);
            }

            //Set Operations
            Console.WriteLine("--------------Set Operations--------------");
            var tags1 = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(C => C.Level)
                .SelectMany(c => c.Tags)
                .Distinct();
            foreach (var t in tags1)
            {
                Console.WriteLine(t.Name);
            }

            //Grouping
            Console.WriteLine("--------------Grouping--------------");

            var groups = context.Courses
                .GroupBy(c => c.Level);

            foreach (var group in groups)
            {
                Console.WriteLine("Key: " + group.Key);

                foreach (var course in group)
                {
                    Console.WriteLine("\t" + course.Name);
                }
            }

            //Joining
            Console.WriteLine("--------------Joining--------------");
            var courses2 =
            context.Courses.Join(
                context.Authors,
                c => c.AuthorId,
                a => a.Id,
                (course, author) => new
                {
                    CourseName = course.Name,
                    AuthorName = author.Name
                });
            foreach (var course in courses2)
            {
                Console.WriteLine(course.CourseName + " - " + course.AuthorName);
            }
            //Group Join
            Console.WriteLine("--------------Group Join--------------");
            context.Authors.GroupJoin(context.Courses, a => a.Id, c => c.AuthorId, (author, course) => new
            {
                Author = author,
                Courses = course.Count()
            });

            //Cross Joining
            Console.WriteLine("--------------Cross Joining--------------");

            var cross = context.Authors.SelectMany(a => context.Courses, (author, course) => new
            {
                AuthorName = author.Name,
                CourseName = course.Name

            });
            foreach (var item in cross)
            {
                Console.WriteLine(item.AuthorName + " - " + item.CourseName);
            }

            //Partitioning Paginação de dados
            Console.WriteLine("-------------- Partitioning --------------");
            var courses3 = context.Courses
                .Where(c => c.FullPrice > 10)
                .OrderBy(c => c.Name)
                .Skip(3)
                .Take(2)
                ;
            foreach (var curse in courses3)
            {
                Console.WriteLine(curse.Name);
            }

        }
    }
}

