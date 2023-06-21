using System;
using System.Data.SqlClient;

namespace SQLConsole
{
    public class SQLConsole
    {
        private static void ConnectDatabase(string command)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLConsole;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new(connectionString);
            con.Open();
            SqlCommand cmd = new(command, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Command executed succesfully.");
        }
        public static void Main()
        {
            string firstName = "Pedro";
            string lastName = "Bertoluchi";
            int age = 20;
            string email = "thanksuniverse333@outlook.com";
            ConnectDatabase($"INSERT INTO Person (FirstName, LastName, Age, Email) VALUES ('{firstName}', '{lastName}', {age}, '{email}')");
        }
    }
}
