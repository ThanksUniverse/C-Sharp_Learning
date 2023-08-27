using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            Barcode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string Barcode { get; private set; } = String.Empty;
        public string BoletoNumber { get; private set; } = String.Empty;
    }
}