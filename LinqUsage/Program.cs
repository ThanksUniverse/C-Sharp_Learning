using System;

namespace LinqUsage
{
    public class Program
    {
        public static void Main()
        {
            var myBooks = new List<Book>() // We create a list with all our values
            {
                new Book("C# Basics", 100, 3.8),
                new Book("C# Advanced", 200, 7.4),
                new Book("Extremely Advanced Programming", 300, 10.0),
                new Book("Basic Lua Programming", 50, 1.5),
            };

            // Then we create another one using LINQ to organize it to our like
            var OrderedBooks = myBooks.Where(a => a.GetName().Contains("C#") || a.GetName().Contains("Lua")).OrderBy(a => a.GetPrice());

            // And we print it
            foreach (Book book in OrderedBooks)
            {
                Console.WriteLine(book.GetName());
            }
        }
    }
}