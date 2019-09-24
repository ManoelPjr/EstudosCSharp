using Queries.Persistence;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                // Example1
                var course = unitOfWork.Courses.Get(1);
                System.Console.WriteLine(course.Name);
                // Example2
                var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);
                foreach (var item in courses)
                {
                    System.Console.WriteLine("Course: "+item.Name+" - Author: "+item.Author.Name);
                }
                // Example3
                //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                //unitOfWork.Courses.RemoveRange(author.Courses);
                //unitOfWork.Authors.Remove(author);
                //unitOfWork.Complete();
            }
        }
    }
}
  