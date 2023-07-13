using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.RoleScreen
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar UserRoles");
            Console.WriteLine("2 - Cadastrar usuario em uma role");
            Console.WriteLine("3 - Deletar usuario de uma role");
            Console.WriteLine("4 - Retornar ao inicio");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    DeleteRoleScreen.Load();
                    break;
                case 5:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}