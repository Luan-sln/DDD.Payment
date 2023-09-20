using System.ComponentModel.DataAnnotations;

namespace DDD.Payment.Domain;

public abstract class Payment
{
    public string NumberHash { get; set; } = null!;
    public DateTime PaidDate { get; set; }
    public DateTime ExpiredDate { get; set; }
    public decimal Total { get; set; }
    public decimal TotalPaid { get; set; }
    public string Payer { get; set; } = null!;
    public string Document { get; set; } = null!;
    public string Address { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
}

public class BoletoPayment : Payment
{
    public string BarCode { get; set; } = null!;
    public string BoletoNumber { get; set; } = null!;
}

public class CreditCardPayment : Payment
{
    public string CardHolderName { get; set; } = null!;
    public string CardNumber { get; set; } = null!;
    public string LastTransactionNumber { get; set; } = null!;
}

public class PayPalPayment : Payment
{
    public string TransactionCode { get; set; } = null!;
}