using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            //good for desktop applicatios wpf etc...
            //var context = new PlutoContext();
            //var authors = context.Authors.ToList();// A Dictionary for Grids or comboBoxes
            //var author = context.Authors.Single(a => a.Id == 1);
            //var Course = new Course
            //{
            //    Name = "New Course2",
            //    Description = "New Description2",
            //    FullPrice = 20.95f,
            //    Level = 1,
            //    Author = author
            //};
            //context.Courses.Add(Course);
            //context.SaveChanges();

            // Better for MVC and webApplications
            var context = new PlutoContext();
            var Course = new Course
            {
                Name = "New Course 3",
                Description = "New Description 3",
                FullPrice = 20.95f,
                Level = 1,
                AuthorId = 1
            };
            context.Courses.Add(Course);
            context.SaveChanges();
        }
         /*Using an existing object in context 
          course.Author = context.Authors.Single(a => a.Id == 1);
          Using foreign key properties
          course.AuthorId = 1;*/
         
    }
}
