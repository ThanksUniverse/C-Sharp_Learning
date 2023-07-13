using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuario");
            Console.WriteLine("--------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("PasswordHash: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Image: ");
            var img = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = img,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine($"User: {user.Name} created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos criar seu usario.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}