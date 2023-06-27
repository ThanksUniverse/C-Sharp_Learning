using System;

namespace Payments
{
    class Program
    {
        static void Main()
        {
            var cardPay = new CardPay();
            var payment = new Payment();
            payment.Pagar();
            cardPay.Pagar();
        }
    }
    class Payment
    {
        // Propriedades
        public DateTime expireDate;

        public Payment(DateTime expireDate)
        {

        }

        // Metodos
        public virtual void Pagar()
        {
            Console.WriteLine("Pagar");
        }
        public override string ToString()
        {
            return expireDate.ToString("dd/MM/yyy-hh:mm:ss");
        }
    }

    class CardPay : Payment
    {
        public CardPay(DateTime expireDate) : base(expireDate)
        {

        }
        public int CardNumber { get; set; }

        public override void Pagar()
        {
            Console.WriteLine("CardPay");
        }
    }

    // Metodo Primitivo
    class Pagamento
    {
        public int CardNumber { get; set; }
        public PType PaymentMethod { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
    }

    // Metodo Correto
    public class Pagamento
    {
        Address BillingAddress;
    }
}