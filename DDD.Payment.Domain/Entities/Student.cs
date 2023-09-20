using System.ComponentModel.DataAnnotations;

namespace DDD.Payment.Domain;

public class Student
{
    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public string Document { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    public List<Subscription> Subscriptions { get; set; } = null!;
    public string Address { get; set; } = null!;
}
