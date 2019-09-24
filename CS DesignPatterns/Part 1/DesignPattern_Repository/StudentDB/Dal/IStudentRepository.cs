using StudentDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StudentDB.Dal
{
    public interface IStudentRepository : IDisposable
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int? Id);
        void InsertStudent(Student student);
        void DeleteStudent(int Id);
        void UpdateStudent(Student student);
        Task <int> Save();
    }
}