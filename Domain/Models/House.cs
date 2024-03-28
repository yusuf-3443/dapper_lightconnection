namespace Domain.Models;

public class House
{
    public int id { get; set; }
    public required string address { get; set; }
    public int number { get; set; }
    public string owner { get; set; }
}