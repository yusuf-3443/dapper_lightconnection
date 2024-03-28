using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private readonly DapperContext _context;
    public EmployeeService()
    {
        _context= new DapperContext();
    }
    public List<Employee> GetEmployees()
    {
        var sql = $"Select * from employees";
        var result = _context.Connection().Query<Employee>(sql);
        return result.ToList();
    }

    public Employee GetEmployeeById(int id)
    {
        var sql = $"Select * from employees where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Employee>(sql);
        return result;
    }

    public string AddEmployee(Employee employee)
    {
        var sql = $"Insert into employees(fullname,age,phone)" +
                  $"values ('{employee.fullname}',{employee.age},'{employee.phone}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Employee successfully added";
        return "Failed to add employee";
    }

    public string UpdateEmployee(Employee employee)
    {
        var sql = $"Update employees " +
                  $"Set fullname = '{employee.fullname}',age = {employee.age},phone = '{employee.phone}' where id = {employee.id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Employee successfully updated";
        return "Failed to update employee";
    }

    public string DeleteEmloyee(int id)
    {
        var sql = $"Delete * from employees where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Employee deleted successfully";
        return "Failed to delete employee";
    }
}