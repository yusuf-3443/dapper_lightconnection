namespace Domain.Models;

public class Student
{
    public int id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }
}