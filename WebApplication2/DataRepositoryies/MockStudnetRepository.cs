using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Model;
using WebApplication2.Model.EnumTypes;

namespace WebApplication2.DataRepositoryies
{
    public class MockStudnetRepository : IStudentRepository
    {
        private List<Student> _studentList;
        public MockStudnetRepository()
        {
            _studentList = new List<Student>()
            {
            new Student(){Id=1,Name="张三",Major="计算机科学",Email="zhangsan.com"},
            new Student(){Id=2,Name="李四",Major="物流",Email="lisi.com"},
            new Student(){Id=3,Name="赵六",Major="电子商务",Email="zhaoliu.com"}

            };
        }
        public Student Add(Student student)
        {
            student.Id = _studentList.Max(a => a.Id) + 1;
            _studentList.Add(student);
            return student;
        }
        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(a => a.Id == id);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

       
    }
}
