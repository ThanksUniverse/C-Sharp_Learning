using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.RoleScreen
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("Escreva o id do usuario");
            var userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o id da role");
            var roleId = int.Parse(Console.ReadLine());

            Delete(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Delete(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Delete(userRole);
                Console.WriteLine("Deletado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos deletar sua conexao");
                Console.WriteLine(ex.Message);
            }
        }
    }
}