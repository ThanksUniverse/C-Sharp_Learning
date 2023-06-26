using System;
using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(" Modo Editor");
            Console.WriteLine(" -----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------");

            FileSave(file.ToString(), false);
        }

        public static void FileSave(string text, bool lastChance)
        {
            string askAgain = " Deseja salvar o arquivo ? y|n (yes or no)";
            Viewer.Show(text);
            Console.WriteLine(askAgain);
            string saveFile = Console.ReadLine();
            switch (saveFile)
            {
                case "y":
                    {
                        Console.WriteLine("Qual nome voce quer colocar no arquivo ?");
                        string fileName = Console.ReadLine();
                        using (var file = new StreamWriter($"./{fileName}.html"))
                        {
                            file.Write(text);
                        }
                        Console.WriteLine($"Arquivo {fileName}.html salvo com sucesso");
                    }; break;
                case "n":
                    {
                        if (!lastChance)
                        {
                            Console.WriteLine("You will lose all your data, Press n again to delete all edits.");
                            FileSave(text, true);
                            return;
                        }
                        Console.WriteLine("Delete file");
                    }; break;
                default: Console.WriteLine(askAgain); break;
            }
        }
    }
}