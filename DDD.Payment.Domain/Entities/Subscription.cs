namespace DDD.Payment.Domain;

public class Subscription
{
    private readonly IList<Payments> _payments;
    public Subscription(DateTime? expireDate)
    {
        CreateDate = DateTime.Now;
        LastUpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        Active = true;
        _payments = new List<Payments>();
    }

    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool Active { get; private set; }
    public IReadOnlyCollection<Payments> Payments 
    {
        get
        {
            return _payments.ToArray();
        } 
    }

    public void AddPayment(Payments newPayment)
    {
        _payments.Add(newPayment);
    }

    public void SetActivate()
    {
        Active = true;
        LastUpdateDate = DateTime.Now;
    }

    public void SetInactivate()
    {
        Active = false;
        LastUpdateDate = DateTime.Now;
    }
}