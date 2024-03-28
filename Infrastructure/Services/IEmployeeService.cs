using Domain.Models;

namespace Infrastructure.Services;

public interface IEmployeeService
{
    List<Employee> GetEmployees();
    Employee GetEmployeeById(int id);
    string AddEmployee(Employee employee);
    string UpdateEmployee(Employee employee);
    string DeleteEmloyee(int id);
}