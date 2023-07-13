using System.Reflection.Metadata;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using DapperProject.Models;
using DapperProject.Repositories;
using DapperProject.Interface;
using DapperProject.Screen.TagScreens;

namespace DapperProject
{
    public class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=blog;TrustServerCertificate=True;User Id=sa;Password=1q2w3e4r@#$";
        static void Main()
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Menu.Load();

            Console.ReadKey();
            Database.Connection.Close();
        }



        #region Generic Method
        public static void ReadItems<T>(SqlConnection connection) where T : class, IItems
        {
            var repository = new Repository<T>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadItem<T>(SqlConnection connection) where T : class, IItems
        {
            var repository = new Repository<T>(connection);
            var item = repository.Get(1);
            Console.WriteLine(item.Name);
        }

        public static void CreateItem<T>(SqlConnection connection, T model) where T : class, IItems
        {
            var repository = new Repository<T>(connection);
            repository.Create(model);
            Console.WriteLine("Cadastro realizado com sucesso.");
        }

        public static void UpdateItem<T>(SqlConnection connection, T model) where T : class, IItems
        {
            var repository = new Repository<T>(connection);
            repository.Update(model);
            Console.WriteLine("Atualizacao realizada com sucesso.");
        }

        public static void DeleteItem<T>(SqlConnection connection) where T : class, IItems
        {
            var repository = new Repository<T>(connection);
            repository.Delete(1);
            Console.WriteLine("Exclusao realizada com sucesso.");
        }
        #endregion

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($"--> {role.Name}");
                }
            }
        }
    }
}