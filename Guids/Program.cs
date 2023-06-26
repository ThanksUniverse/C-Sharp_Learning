using System;
using System.Text;

namespace Guids
{
    class Program
    {
        static void Main()
        {
            //? Guids
            var id = Guid.NewGuid();
            string values = id.ToString().Substring(0, 8);
            Console.WriteLine(id);
            Console.WriteLine(values);
            Console.WriteLine("---------------------------------------");

            //? Interpolacao
            double price = 10.2;
            string texto;
            //var texto = "O preco do produto eh: " + price;
            texto = string.Format("O preco do produto eh: {0}", price);
            texto = $"O preco do produto eh: {price}.";
            texto = $@"O preco do produto eh
            : 
            {price}
            .";
            Console.WriteLine(texto);
            Console.WriteLine("---------------------------------------");

            //? Comparacao de Texto
            var texto2 = "testando";
            Console.WriteLine(texto2.Contains("Testa", StringComparison.OrdinalIgnoreCase)); // Return true or false based if contains ignoring Case
            Console.WriteLine(texto2.Contains("Testa", StringComparison.Ordinal)); // Return true or false based if contains in text normal
            Console.WriteLine(texto2.CompareTo("Testa")); // Return a number of different characters
            Console.WriteLine("---------------------------------------");

            //? Start With End With
            var With = "Esse texto eh um teste";
            Console.WriteLine(With.StartsWith("esse", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(With.StartsWith("Esse"));
            Console.WriteLine(With.EndsWith("TeSTe", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("---------------------------------------");

            //? Equals
            var Equals = "Esse texto eh um teste";
            Console.WriteLine(Equals.Equals("Esse texto eh um teste"));
            Console.WriteLine(Equals.Equals("Esse texto eh um test"));
            Console.WriteLine(Equals.Equals("ESSE texto eh um teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("---------------------------------------");

            //? Indices
            var Indices = "Esse texto eh um teste";
            Console.WriteLine(Indices.IndexOf("um")); // 14
            Console.WriteLine(Indices.LastIndexOf("s")); // 19, Return last index of this string
            Console.WriteLine(Indices.IndexOf("e", StringComparison.OrdinalIgnoreCase)); // 0 Return 0 because it gets the E
            Console.WriteLine(Indices.IndexOf("e")); // 3 Return 3 because it doesnt gets the E
            Console.WriteLine("---------------------------------------");

            //? Metodos adicionais
            var Methods = "Esse texto eh um teste";
            Console.WriteLine(Methods.ToUpper()); // Esse deixa todos maiusculo
            Console.WriteLine(Methods.ToLower()); // Esse deixa todos minusculo
            Console.WriteLine(Methods.ToArray()); // Esse tranforma o texto em um array
            Console.WriteLine(Methods.Insert(Methods.LastIndexOf("e") + 1, " de novo")); // Esse adicionada a palavra de novo depois do ultimo e (nota-se o + 1)
            Console.WriteLine(Methods.Remove(4, 6)); // Esse remove a palavra teste
            Console.WriteLine(Methods.Length); // Esse mostra o tamanho da linha << Nenhuma das alteracoes anteriores ficam salvas no Methods ja que nao aplicamos
            Console.WriteLine("---------------------------------------");

            //? Manipulando Strings
            var Manipulation = "Esse texto eh um teste    ";
            Manipulation = Manipulation.Trim();
            Console.WriteLine(Manipulation.Replace("esSE", "Isto", StringComparison.OrdinalIgnoreCase)); // Substitui ignorando case
            Console.WriteLine(Manipulation.Replace("e", "i", StringComparison.OrdinalIgnoreCase)); // Substitui todos e por i
            var divisao = Manipulation.Split(" ");
            Console.WriteLine(divisao);
            foreach (var line in divisao)
            {
                Console.WriteLine(line);
            }

            //var resultado = Manipulation.Substring(5, 5);
            var resultado = Manipulation.Substring(5, Manipulation.IndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine("---------------------------------------");

            //? StringBuilder
            var builder = new StringBuilder();
            builder.Append("Esse texto eh um texte");// Pode usar o @ tambem para solucionar isso, mas eh reocmendado o StringBuild
            builder.Append(" eh um teste");
            builder.Append(" esse texto");
            builder.Append("\nParabens;");

            // Em alguns casos precisamos usar builder.ToString() <--
            Console.WriteLine(builder);
            //texto += " aqui"; // Concatenacao de string // Este metodo pode dar memory leak
        }
    }
}