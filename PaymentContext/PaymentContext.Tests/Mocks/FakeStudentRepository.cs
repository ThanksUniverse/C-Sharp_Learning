using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks;

public class FakeStudentRepository : IStudentRepository
{
    public bool DocumentExists(string document)
    {
        if (document == "12345678900")
            return true;

        return false;
    }

    public bool EmailExists(string email)
    {
        if (email == "pedro@gmail.com")
            return true;

        return false;
    }

    public void CreateSubscription(Student student)
    {
        throw new NotImplementedException();
    }
}