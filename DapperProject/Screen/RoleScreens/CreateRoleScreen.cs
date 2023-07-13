using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.RoleScreen
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("Escreva o id do usuario");
            var userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o id da role");
            var roleId = int.Parse(Console.ReadLine());

            Insert(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Insert(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(userRole);
                Console.WriteLine($"{userRole.UserId} -- {userRole.RoleId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos criar sua nova conexao");
                Console.WriteLine(ex.Message);
            }
        }
    }
}