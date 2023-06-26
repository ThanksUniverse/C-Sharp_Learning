using System;

namespace HTMLEditor
{
    public static class Menu
    {
        private static int Stars = 0;
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void DrawStars(int columns)
        {
            for (int i = 0; i <= columns; i++) // TopBar
                Console.Write("*");
            Console.WriteLine("");

            Stars = columns;
        }

        private static void DrawBars(int maxLines)
        {
            for (int lines = 0; lines <= maxLines; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= Stars - 2; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void DrawScreen()
        {
            DrawStars(32);

            DrawBars(11);

            DrawStars(32);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma posicao");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opcao: ");
            Console.SetCursorPosition(9, 10);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    };
                default: Show(); break;
            }
        }
    }
}