using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Subscription _subscription;

        public StudentTests()
        {
            _name = new Name("Pedro", "Bertoluchi");
            _document = new Document("44067339810", EDocumentType.CPF);
            _email = new Email("thanksuniverse333@outlook.com");
            _address = new Address("Rua 1", "1234", "Bairro Legal", "Sao Paulo", "SP", "BR", "12345678");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }
        [TestMethod]
        public void ShouldReturnErrorWhenHaveActiveSubscription()
        {
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(2), 100, 100, "Pedro",
                _document, _address, _email);
            
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);
            
            Assert.IsTrue(_student.Invalid);
        }
        
        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHadNoPayment()
        {
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
        }
        
        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(2), 100, 100, "Pedro",
                _document, _address, _email);
            
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            
            Assert.IsTrue(_student.Valid);
        }
    }
}