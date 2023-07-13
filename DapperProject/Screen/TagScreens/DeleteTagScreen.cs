using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar uma tag");
            Console.WriteLine("--------------");

            Console.Write("Qual o id da tag que deseja deletar ?: ");
            var id = Console.ReadLine();

            Update(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine($"Tag {id} deletada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}