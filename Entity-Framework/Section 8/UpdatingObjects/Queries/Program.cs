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
            var course = context.Courses.Find(10); //same for Single(c=>c.Id == 4)
            course.Name = "New Name";
            course.Description = "Updating by me";
            course.AuthorId = 2;
            context.SaveChanges();
        }

         
    }
}
