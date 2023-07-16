using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Dapper
{
    class Program
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true;";
        static void Main()
        {
            using (SqlConnection con = new(connectionString))
            {
                con.Open();
                Console.WriteLine($"Connected to: {con}");
                using (SqlCommand cmd = new("select * from Category", con))
                {
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                    }
                }
            }
        }
    }
}