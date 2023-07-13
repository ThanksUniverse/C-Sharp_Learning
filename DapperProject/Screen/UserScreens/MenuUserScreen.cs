using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuarios");
            Console.WriteLine("2 - Cadastrar usuario");
            Console.WriteLine("3 - Atualizar usuario");
            Console.WriteLine("4 - Deletar usuario");
            Console.WriteLine("5 - Retornar ao inicio");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}