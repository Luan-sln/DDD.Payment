using System.ComponentModel.DataAnnotations;

namespace DDD.Payment.Domain;

public class Student
{
    private readonly IList<Subscription> _subscription;
    public Student(string firstName, string lastName, string document, string email, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
        Address = address;
        _subscription = new List<Subscription>();
    }

    [Required]
    public string FirstName { get; private set; } = null!;
    [Required]
    public string LastName { get; private set; } = null!;
    [Required]
    public string Document { get; private set; } = null!;
    [EmailAddress]
    public string Email { get; private set; } = null!;
    public string Address { get; private set; } = null!;
    public IReadOnlyCollection<Subscription> Subscriptions
    {
        get
        {
            return _subscription.ToArray();
        }
        
    }

    public void AddSubscription(Subscription newSubiscription)
    {
        foreach(var sub in _subscription)
            sub.SetInactivate();
            
        _subscription.Add(newSubiscription);
    }
}
