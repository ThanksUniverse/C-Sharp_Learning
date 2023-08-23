using System.Collections.Generic;
using System;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public string FirstName { get; private set; } = String.Empty;
        public string LastName { get; private set; } = String.Empty;
        public string Document { get; private set; } = String.Empty;
        public string Email { get; private set; } = String.Empty;
        public string Address { get; private set; } = String.Empty;

        private IReadOnlyCollection<Subscription> Subscriptions
        {
            get { return _subscriptions.ToArray(); }
        }

        public void AddSubscription(Subscription subscription)
        {
            // Se ja tiver uma assinatura ativa, cancela

            // Cancela todas as outras assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
                sub.Activate();

            _subscriptions.Add(subscription);
        }
    }
}