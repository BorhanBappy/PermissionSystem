using Microsoft.EntityFrameworkCore;

namespace Domain;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public string Email { get; set; } 
    public string PhoneNumber { get; set; } 
    [Precision(18, 4)]
    public decimal Salary { get; set; }
    
}