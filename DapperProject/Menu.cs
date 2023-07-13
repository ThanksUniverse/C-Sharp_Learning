using DapperProject.Screen.CategoryScreens;
using DapperProject.Screen.ChallengeScreens;
using DapperProject.Screen.PostScreens;
using DapperProject.Screen.RoleScreen;
using DapperProject.Screen.TagScreens;
using DapperProject.Screen.UserScreens;

namespace DapperProject
{
    public static class Menu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu blog");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestao de usuario");
            Console.WriteLine("2 - Gestao de roles");
            Console.WriteLine("3 - Gestao de categoria");
            Console.WriteLine("4 - Gestao de tag");
            Console.WriteLine("5 - Gestao de posts");
            Console.WriteLine("6 - Desafio");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuPostScreen.Load();
                    break;
                case 6:
                    MenuChallengeScreen.Load();
                    break;
                default: Load(); break;
            };
        }
    }
}