namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; set; } = String.Empty;
}