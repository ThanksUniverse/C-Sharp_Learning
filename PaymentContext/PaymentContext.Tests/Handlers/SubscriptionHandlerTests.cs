using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers;
[TestClass]
public class SubscriptionHandlerTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInvalid()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand();
        command.Barcode = "123456789";
        command.FirstName = "Bruce";
        command.LastName = "Wayne";
        command.Document = "12345678900";
        command.Email = "";
        command.BoletoNumber = "123456789";
        command.PaymentNumber = "123456789";
        command.PaidDate = DateTime.Now;
        command.ExpireDate = DateTime.Now.AddMonths(1);
        command.Total = 60;
        command.TotalPaid = 60;
        command.Payer = "Wayne Corp";
        command.PayerDocument = "12345678900";
        command.PayerDocumentType = EDocumentType.CPF;
        command.PayerEmail = "batman@dc.com";
        command.Street = "Rua 1";
        command.Number = "123";
        command.Neighborhood = "Bairro Legal";
        command.City = "Gotham";
        command.State = "SP";
        command.Country = "BR";
        command.ZipCode = "12345678";
        handler.Handle(command);
        Assert.AreEqual(false, handler.Valid);
    }
}