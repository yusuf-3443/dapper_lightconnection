namespace Domain.Models;

public class Employee
{
    public int id { get; set; }
    public required string fullname { get; set; }
    public int age { get; set; }
    public string phone { get; set; }
}