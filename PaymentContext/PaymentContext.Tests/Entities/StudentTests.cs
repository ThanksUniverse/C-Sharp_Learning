using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Pedro", "Bertoluchi", "12345678910", "thanksuniverse333@outlook.com");
            student.AddSubscription(subscription);
        }
    }
}