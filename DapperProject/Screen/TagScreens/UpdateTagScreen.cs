using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar uma tag");
            Console.WriteLine("--------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine($"Tag {tag.Name} atualizada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}