using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name} \n -->{user.Email}");
            }
        }
    }
}