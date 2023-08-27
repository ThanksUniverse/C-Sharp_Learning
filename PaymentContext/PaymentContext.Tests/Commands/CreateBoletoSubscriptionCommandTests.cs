using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        
        [TestMethod]
        public void ShouldReturnErrorWHenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";
            
            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}