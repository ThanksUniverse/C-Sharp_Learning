using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.RoleScreen
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.GetWithRoles();

            foreach (var user in users)
            {
                Console.WriteLine($"Username: {user.Name}");

                foreach (var role in user.Roles)
                {
                    Console.WriteLine($"--> {role.Name}");
                }
                Console.WriteLine("-------------");
            }
        }
    }
}