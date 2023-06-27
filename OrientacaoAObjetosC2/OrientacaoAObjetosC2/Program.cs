using System;
namespace Paymentsx
{
    public class Paymentsz
    {
        static void Main()
        {
            using (var payment = new Payment("Pedrow Started ITO"))
            {
                Console.WriteLine("Paymento");
            }
        }
    }

    public abstract class Pagamento : IDisposable, IPagamento
    {
        // Garbage Collector
        public Pagamento()
        {
            Console.WriteLine("Iniciando o pagamento.");
        }

        public DateTime expireDate { get; set; }

        public void Pagar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento.");
        }
    }

    public partial class Payment : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("End of it");
        }
    }

    public interface IPagamento // Nota o I na frente igual como fazemos com o enum EPagamento
    {
        DateTime expireDate { get; set; }

        void Pagar(decimal valor);
    }
}