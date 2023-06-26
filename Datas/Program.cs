using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            decimal value = 199.24m;
            Console.WriteLine("Round");
            Console.WriteLine(
                Math.Round(value) 
            );
            Console.WriteLine("-------------");
            Console.WriteLine("Ceiling");
            Console.WriteLine(
                Math.Ceiling(value)
            );
            Console.WriteLine("-------------");
            Console.WriteLine("Floor");
            Console.WriteLine(
                Math.Floor(value)
            );
            Console.WriteLine("-------------");

            Console.WriteLine(value.ToString("C", new CultureInfo("pt-BR")));
        }

        private static void DateThings()
        {
            Console.Clear();
            var date = DateTime.Now;

            Console.WriteLine(DateTime.DaysInMonth(date.Year, date.Month)); // Dias dentro de 1 mes (30)
            Console.WriteLine(IsWeekend(date.DayOfWeek)); // True or false se for dia da semana
            Console.WriteLine(date.IsDaylightSavingTime()); // Verifica se for horario de verao do lugar
        }
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}