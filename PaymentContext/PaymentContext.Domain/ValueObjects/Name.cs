using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres")
            );
        }

        public string FirstName { get; private set; } = String.Empty;
        public string LastName { get; private set; } = String.Empty;

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}