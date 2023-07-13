using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar post");
            Console.WriteLine("3 - Atualizar post");
            Console.WriteLine("4 - Deletar post");
            Console.WriteLine("5 - Cadastrar a Tag");
            Console.WriteLine("6 - Listar posts e suas Tags");
            Console.WriteLine("7 - Retornar ao inicio");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListPostScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                case 5:
                    TagPostScreen.Load();
                    break;
                case 6:
                    ListPostTagsScreen.Load();
                    break;
                case 7:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}