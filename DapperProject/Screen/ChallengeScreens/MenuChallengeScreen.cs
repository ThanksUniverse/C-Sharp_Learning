namespace DapperProject.Screen.ChallengeScreens
{
    public static class MenuChallengeScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tarefas");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja executar ?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias com quantidades de posts");
            Console.WriteLine("2 - Listar tags com quantidades de posts");
            Console.WriteLine("3 - Listar posts de uma categoria");
            Console.WriteLine("4 - Listar todos os posts e sua categoria");
            Console.WriteLine("5 - Retornar ao inicio");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoriesChallengeScreen.Load();
                    break;
                case 2:
                    ListTagsPostsChallengeScreen.Load();
                    break;
                case 3:
                    ListPostsCategoryChallengeScreen.Load();
                    break;
                case 4:
                    ListPostsWithCategoryChallengeScreen.Load();
                    break;
                case 5:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}