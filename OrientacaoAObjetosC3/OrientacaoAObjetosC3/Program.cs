using System;

namespace PartIII
{
    public class Learning
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");

            Pessoa pessoa = new Pessoa(1, "Pedro");
            var pessoa2 = new Pessoa(1, "Pedro");

            Console.WriteLine(pessoa == pessoa2);
            Console.WriteLine(pessoa.Name == pessoa2.Name);
            Console.WriteLine(pessoa);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa.Equals(pessoa2));

            Console.WriteLine(pessoa.Equals(pessoa2)
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public Pessoa(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool Equals(Pessoa? other)
        {
            return this.Id == other.Id;
        }
    }
}

