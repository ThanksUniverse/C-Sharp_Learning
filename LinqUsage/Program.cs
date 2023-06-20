using System;

namespace LinqUsage
{
    public class Program
    {
        public static void Main()
        {
            var myBooks = new List<Book>();
            Book SampleBook = new("C# Basics", 100, 3.8);
            Book SampleBook2 = new("C# Advanced", 200, 7.4);
            Book SampleBook3 = new("Extremely Advanced Programming", 300, 10.0);
            Book SampleBook4 = new("Basic Lua Programming", 50, 1.5);

            myBooks.Add(SampleBook); myBooks.Add(SampleBook2); myBooks.Add(SampleBook3); myBooks.Add(SampleBook4);

            var OrderedBooks = myBooks.Where(a => a.GetName().Contains("C#") || a.GetName().Contains("Lua")).OrderBy(a => a.GetPrice());

            foreach (Book book in OrderedBooks)
            {
                Console.WriteLine(book.GetName());
            }


        }
    }
}