using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar uma category");
            Console.WriteLine("--------------");

            Console.Write("Qual o id da category que deseja deletar ?: ");
            var id = Console.ReadLine();

            Update(int.Parse(id));
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine($"Category {id} deletada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a category");
                Console.WriteLine(ex.Message);
            }
        }
    }
}