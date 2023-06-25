using System.Data;
using System;

namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }

            static void Open()
            {
                Console.Clear();
                Console.WriteLine("Qual o caminho do arquivo ?");
                string path = Console.ReadLine();

                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }

            static void Edit()
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do arquivo:");
                string fileName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Title: ${fileName}");
                Console.WriteLine("Digite o seu texto abaixo");
                Console.WriteLine("----------");
                string text = "";

                do
                {
                    text += Console.ReadLine();
                    text += Environment.NewLine;
                } while (Console.ReadKey().Key != ConsoleKey.Escape);

                Save(fileName, text);
            }

            static void Save(string title, string text)
            {
                Console.Clear();
                Console.WriteLine("Qual o caminho para salvar o arquivo ?");
                var path = $"./{title}.txt";

                using(var file = new StreamWriter(path))
                {
                    file.Write(text);
                }

                Console.WriteLine($"Arquivo {title}.txt salvo com sucesso.");
                Menu();
            }
        }
    }
}