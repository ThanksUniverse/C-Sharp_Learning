using System;

namespace BaltaIO
{
    class Program
    {
        static void Main()
        {
            Pedro it = new("Pedro Bertoluchi", 20, EJob.Unemployed);
            Console.WriteLine(it);
            Console.WriteLine(it.Name);
            Console.WriteLine(it.Age);
            Console.WriteLine((int)it.JobStats);
            Item item = new(1, "Pedro Item", EItemType.Product);
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Type);
            Console.WriteLine((int)item.Type);
        }
    }

    struct Pedro
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EJob JobStats { get; set; }

        public Pedro(string name, int age, EJob jobStats)
        {
            Name = name;
            Age = age;
            JobStats = jobStats;
            Console.WriteLine("You created a new Pedro.");
        }
    }

    struct Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EItemType Type { get; set; }

        public Item(int id, string name, EItemType type)
        {
            Id = id;
            Name = name;
            Type = type;
            Console.WriteLine("You created a new Item.");
        }
    }

    enum EJob
    {
        Working = 1,
        Unemployed = 2
    }

    enum EItemType
    {
        Service = 1,
        Product = 2,
    }
}