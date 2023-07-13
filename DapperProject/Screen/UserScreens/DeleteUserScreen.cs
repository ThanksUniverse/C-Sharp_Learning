using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar id do usuario");
            Console.WriteLine("--------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Create(new User
            {
                Id = int.Parse(id)
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(user);
                Console.WriteLine($"User: {user.Id} deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos deletar seu usario.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}