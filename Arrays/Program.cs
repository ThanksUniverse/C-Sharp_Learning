using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var arrayReference = array; // Lembrar que array eh um referenceType entao editar no arrayReference nao muda o outro
            Random random = new();
            for (int i = 0; i < arrayReference.Length; i++)
            {
                arrayReference[i] = random.Next(1, 100);
            }

            var output = new StringBuilder();
            foreach (var value in arrayReference)
            {
                output.Append(value + ",");
            }

            string outputString = output.ToString();

            outputString = outputString.Remove(output.Length - 1);

            Console.WriteLine(outputString);

            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    arrayReference[i] = random.Next(1, 100);
                }
            }
            catch
            {
                Console.WriteLine("Excecao normal.");
            }
            finally
            {
                Console.WriteLine("Acabou, terminamos tudo.");
                Console.ReadLine();
            }


            try
            {
                DoThis("pedro");

            }
            catch (MinhaException ex)
            {
                Console.WriteLine($"Esse erro aconteceu em: {ex.TimeHappen:dd/MM/yyyy:hh:mm:ss}");
            }
        }

        public static void DoThis(string text)
        {
            if (text != "Pedro")
                throw new MinhaException(DateTime.Now);
        }

    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            TimeHappen = date;
        }
        public DateTime TimeHappen { get; set; }
    }
}