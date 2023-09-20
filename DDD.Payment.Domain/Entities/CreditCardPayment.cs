﻿namespace DDD.Payment.Domain;

public class CreditCardPayment : Payments
{
    public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber,
        DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string payer,
        string document, string address, string email) 
        : base(paidDate, expiredDate, total, 
        totalPaid, payer, document, address, email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; private set; } = null!;
    public string CardNumber { get; private set; } = null!;
    public string LastTransactionNumber { get; private set; } = null!;
}
