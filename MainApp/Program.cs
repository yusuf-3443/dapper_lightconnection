using Domain.Models;
using Infrastructure.Services;

var employeeservice = new EmployeeService();
var employee = new Employee()
{
    fullname = "Mark Johnson",
    age = 25,
    phone = "8779846521321"
};
Console.WriteLine(employeeservice.AddEmployee(employee));