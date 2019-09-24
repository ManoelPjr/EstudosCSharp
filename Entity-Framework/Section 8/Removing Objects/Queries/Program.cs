using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Simple delete
            //var context = new PlutoContext();
            //var course = context.Courses.Find(10); //same for Single(c=>c.Id == 4)
            //context.Courses.Remove(course);

            //context.SaveChanges();
            
            //Recursive dele
            var context = new PlutoContext();
            var author = context.Authors.Include(a=> a.Courses).Single(a => a.Id == 6);//select all couses of author
            context.Courses.RemoveRange(author.Courses); //remove first all couses
            context.Authors.Remove(author); // after revove Author 

            context.SaveChanges(); //final apply al changes
        }

         
    }
}
