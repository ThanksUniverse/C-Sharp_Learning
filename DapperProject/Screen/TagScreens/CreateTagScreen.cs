using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("--------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine($"Tag {tag.Name} cadastrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}