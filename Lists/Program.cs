using System;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            IList<Payment> payments = new List<Payment>
            {
                new Payment(1),
                new Payment(2),
                new Payment(3),
                new Payment(4),
                new Payment(5)
            };


            foreach (Payment payment in payments)
            {
                Console.WriteLine(payment.ToString());
            }

            payments.Add(new Payment(6));
            var paids = payments.Where(x => x.Id > 2); // Traz uma lista
            foreach (var it in paids)
            {
                Console.WriteLine(it.ToString());
            }

            var one = payments.First(x => x.Id == 3);
            Console.WriteLine(one.Id);

            payments.Remove(one);
            foreach (var item in payments)
            {
                Console.WriteLine(item.ToString());
            }

            // payments.Clear(); Limpa a lista

            foreach (var item in payments.Where(x => x.Id >= 4))
            {
                Console.WriteLine(item.ToString());
            }

            var exists = payments.Any(x => x.Id == 1);
            Console.WriteLine(exists);

            var count = payments.Count(x => x.Id >= 3);
            Console.WriteLine(count);

            foreach (var item in payments.Skip(1).Take(3))
            {
                Console.WriteLine(item.ToString());
            }

            payments.AsEnumerable();
            payments.ToList();
            payments.ToArray();
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}