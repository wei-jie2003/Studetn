using System.Collections;
using System.Collections.Generic;
using WebApplication2.Model;

namespace WebApplication2.DataRepositoryies
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();

        Student Add(Student student);
    }
}
