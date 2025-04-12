using StudentService.Core.Entities;
using StudentService.Core.Interfaces;

namespace StudentService.Core.Services
{
    public class StudentService : IStudentService
    {
        private static readonly List<Student> _students = [];

        public IEnumerable<Student> GetAllStudents() => _students;

        public Student? GetStudentById(int id)
        {
            Func<Student, bool> predicate = s => s.Id == id;
            return _students.FirstOrDefault(predicate);
        }

        public void AddStudent(Student student)
        {
            student.Id = _students.Count + 1;  // Simple auto-increment for Id
            _students.Add(student);
        }

        public void UpdateStudent(int id, Student student)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Grade = student.Grade;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
