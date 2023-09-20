using DDD.Payment.Domain;
namespace DDD.Payment.Tests;

public class StudentTests
{
    private readonly Faker _faker = new Faker("pt_BR");


    [Fact(DisplayName = "Entidade Criada com Sucesso")]
    public void Create_Entity_Successfuly()
    {
        var student = new Student(_faker.Name.FirstName(), _faker.Name.LastName(), 
        _faker.Random.Number(12).ToString(), _faker.Person.Email, _faker.Address.StreetAddress());

        Assert.False(String.IsNullOrEmpty(student.FirstName));
        Assert.False(String.IsNullOrEmpty(student.LastName));
        Assert.False(String.IsNullOrEmpty(student.Email));
        Assert.False(String.IsNullOrEmpty(student.Address));
        Assert.False(String.IsNullOrEmpty(student.Document));
    }

    [Fact(DisplayName = "Teste de Assinatura")]
    public void Add_New_Subscription_Successfully()
    {
        var subs = new Subscription(null);
        var student = new Student(_faker.Name.FirstName(), _faker.Name.LastName(), 
        _faker.Random.Number(12).ToString(), _faker.Person.Email, _faker.Address.StreetAddress());

        student.AddSubscription(subs);
    }
}
