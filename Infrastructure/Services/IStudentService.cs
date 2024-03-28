using Domain.Models;

namespace Infrastructure.Services;

public interface IStudentService
{
    List<Student> GetStudents();
    Student GetStudentById(int id);
    string AddStudent(Student student);
    string UpdateStudent(Student student);
    bool DeleteStudent(int id);
}