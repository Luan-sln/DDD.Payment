using System.ComponentModel.DataAnnotations;

namespace DDD.Payment.Domain;

public abstract class Payments
{
    protected Payments(DateTime paidDate, DateTime expiredDate, decimal total, 
        decimal totalPaid, string payer, string document, string address, string email)
    {
        NumberHash = Guid.NewGuid().ToString("N")[10..].ToUpper() ;
        PaidDate = paidDate;
        ExpiredDate = expiredDate;
        Total = total;
        TotalPaid = totalPaid;
        Payer = payer;
        Document = document;
        Address = address;
        Email = email;
    }

    public string NumberHash { get; private set; } = null!;
    public DateTime PaidDate { get; private set; }
    public DateTime ExpiredDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Payer { get; private set; } = null!;
    public string Document { get; private set; } = null!;
    public string Address { get; private set; } = null!;
    
    [EmailAddress]
    public string Email { get; private set; } = null!;
}