namespace PaymentContext.Domain.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; } = String.Empty;
        public string LastName { get; private set; } = String.Empty;
    }
}