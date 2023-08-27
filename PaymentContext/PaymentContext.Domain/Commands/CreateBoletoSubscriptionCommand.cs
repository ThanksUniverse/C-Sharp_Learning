using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Document { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;

        public string Barcode { get; set; } = String.Empty;
        public string BoletoNumber { get; set; } = String.Empty;

        public string PaymentNumber { get; set; } = String.Empty;
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; } = String.Empty;
        public string PayerDocument { get; set; } = String.Empty;
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; } = String.Empty;
        public string Street { get; set; } = String.Empty;
        public string Number { get; set; } = String.Empty;
        public string Neighborhood { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string ZipCode { get; set; } = String.Empty;
        
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres")
            );
        }
    }
}