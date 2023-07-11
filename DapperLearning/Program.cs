using System.Data;
using Dapper;
using DapperLearning.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace DapperLearning
{
    class Program
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true;";
        static void Main()
        {


            using SqlConnection con = new(connectionString);
            //DeleteCategory(con);
            //UpdateCategory(con);
            //CreateCategory(con);
            //CreateManyCategory(con);
            //ExecuteScalar(con);
            //ListCategories(con);
            //ExecuteReadProcedure(con);
            //ReadView(con);
            //OneToOne(con);
            //OneToMany(con);
            //QueryMultiple(con);
            //SelectIn(con);
            //Like(con, "Back");
            Transaction(con);
        }

        static void ListCategories(SqlConnection connection)
        {
            var categories = connection.Query<Category>("select [Id], [Title] from [Category]");
            foreach (var it in categories)
                Console.WriteLine($"{it.Id} - {it.Title}");
        }

        static void CreateCategory(SqlConnection connection)
        {
            // Previnir SQL Injection nao usando insert into
            var insertSql = @"insert into
                [Category]
            values(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured
            )";
            // Nao podemos concatenar strings aqui com ${}

            var category = new Category(Guid.NewGuid(), "Amazon AWS", "amazon", "AWS Cloud", 8, "Categoria destinada a servicos do AWS", false);

            // Sempre usar dessa forma para evitar sqlInjection
            int rows = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured

            });

            // con.Execute Retorna quantidade de rows editados
            Console.WriteLine($"Linhas inseridas {rows}.");
        }

        static void UpdateCategory(SqlConnection connection)
        {
            var updateQuery = "Update [Category] Set [Title]=@Title where [Id]=@Id";
            var rows = connection.Execute(updateQuery, new
            {
                Id = new Guid("AF3407AA-11AE-4621-A2EF-2028B85507C4"),
                Title = "Frontend 2023"
            });

            Console.WriteLine($"Registros atualizados {rows}");
        }

        static void DeleteCategory(SqlConnection connection)
        {
            var deleteQuery = "delete from [Category] where [Title] = @Title";
            var rows = connection.Execute(deleteQuery, new
            {
                Title = "Amazon AWS"
            });
        }

        static void CreateManyCategory(SqlConnection connection)
        {
            // Previnir SQL Injection nao usando insert into
            var insertSql = @"insert into
                [Category]
            values(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured
            )";
            // Nao podemos concatenar strings aqui com ${}

            var category = new Category(Guid.NewGuid(), "Amazon AWS", "amazon", "AWS Cloud", 8, "Categoria destinada a servicos do AWS", false);
            var category2 = new Category(Guid.NewGuid(), "Categoria Nova", "categoria-nova", "Categoria Nova", 9, "Categoria", true);

            // Sempre usar dessa forma para evitar sqlInjection
            int rows = connection.Execute(insertSql, new[]
            {
                new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                },
                new
                {
                    category2.Id,
                    category2.Title,
                    category2.Url,
                    category2.Summary,
                    category2.Order,
                    category2.Description,
                    category2.Featured
                }
            });

            // con.Execute Retorna quantidade de rows editados
            Console.WriteLine($"Linhas inseridas {rows}.");
        }

        static void ExecuteProcedure(SqlConnection connection)
        {
            var procedure = "spDeleteStudentRollback";
            var pars = new { StudentId = "21930E45-FAC9-4116-8604-B5E811E10C1B" };
            var rows = connection.Execute(
                procedure,
                pars,
                commandType: CommandType.StoredProcedure
            );
            Console.WriteLine($"Linhas afetadas {rows}");
        }

        static void ExecuteReadProcedure(SqlConnection connection)
        {
            var procedure = "spGetCoursesByCategory";
            var pars = new { CategoryId = "09CE0B7B-CFCA-497B-92C0-3290AD9D5142" };
            var courses = connection.Query(
                procedure,
                pars,
                commandType: CommandType.StoredProcedure
            );

            foreach (var it in courses)
                Console.WriteLine($"{it.Title} - {it.Id}");
        }

        static void ExecuteScalar(SqlConnection connection)
        {
            var insertSql = @"insert into
                [Category]
                Output inserted.[Id]
            values(
                NEWID(),
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured
            )";

            var category = new Category("Amazon AWS", "amazon", "AWS Cloud", 8, "Categoria destinada a servicos do AWS", false);

            var id = connection.ExecuteScalar<Guid>(insertSql, new
            {
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured

            });

            Console.WriteLine($"A categoria inserida foi: {id}.");
        }

        static void ReadView(SqlConnection connection)
        {
            var view = "Select * From [vwCourses]";
            var courses = connection.Query(view);
            foreach (var it in courses)
                Console.WriteLine($"{it.Id} - {it.Title}");
        }

        static void OneToOne(SqlConnection connection)
        {
            var sql = @"
            Select
                *
            from
                [CareerItem]
            Inner join
                [Course] on [CareerItem].[CourseId] = [Course].[Id]
            ";

            var items = connection.Query<CareerItem, Course, CareerItem>(sql,
            (careerItem, course) =>
            {
                careerItem.Course = course;
                return careerItem;
            }, splitOn: "Id");

            foreach (var it in items)
                Console.WriteLine($"{it.Title} - Curso: {it.Course?.Title}");
        }

        static void OneToMany(SqlConnection connection)
        {
            var sql = @"
           select
                [Career].[Id],
                [Career].[Title],
                [CareerItem].[CareerId],
                [CareerItem].[Title]
            from
                [Career]
            inner join
                [CareerItem] on [CareerItem].[CareerId] = [Career].[Id]
            order by
                [Career].[Title]
            ";

            var careers = new List<Career>();
            var items = connection.Query<Career, CareerItem, Career>(sql,
            (career, item) =>
            {
                var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
                if (car == null)
                {
                    car = career;
                    car.Items.Add(item);
                    careers.Add(car);
                }
                else
                {
                    car.Items.Add(item);
                }
                return career;
            }, splitOn: "CareerId");

            foreach (var career in careers)
            {
                Console.WriteLine($"{career.Title}");
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"--> {item.Title}");
                }
            }
        }

        static void QueryMultiple(SqlConnection connection)
        {
            var query = "select * from [Category]; select * from [Course]";

            using (var multi = connection.QueryMultiple(query))
            {
                var categories = multi.Read<Category>();
                var courses = multi.Read<Course>();

                foreach (var category in categories)
                    Console.WriteLine(category.Title);

                foreach (var course in courses)
                    Console.WriteLine(course.Title);
            }
        }

        static void SelectIn(SqlConnection connection)
        {
            var query = @"
            select top 10 
                * 
            from
                Career
            where
                [Id]
            IN
                @Id";

            var items = connection.Query<Career>(query, new
            {
                Id = new[]
                {
                    "01AE8A85-B4E8-4194-A0F1-1C6190AF54CB",
                    "92D7E864-BEA5-4812-80CC-C2F4E94DB1AF"
                }
            });

            foreach (var it in items)
                Console.WriteLine(it.Title);
        }

        static void Like(SqlConnection connection, string term)
        {
            var query = @"
            select 
                * 
            from
                Course
            where
                [Title]
            like
                @exp";

            var items = connection.Query<Course>(query, new
            {
                exp = $"%{term}%"
            });

            foreach (var it in items)
                Console.WriteLine(it.Title);
        }

        static void Transaction(SqlConnection connection)
        {
            // Previnir SQL Injection nao usando insert into
            var insertSql = @"insert into
                [Category]
            values(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured
            )";
            // Nao podemos concatenar strings aqui com ${}

            var category = new Category(Guid.NewGuid(), "Not saving", "nao salvado", "AWS Cloud", 8, "Categoria destinada a servicos do AWS", false);

            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                int rows = connection.Execute(insertSql, new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                }, transaction);

                transaction.Rollback();
                Console.WriteLine($"Linhas inseridas {rows}.");
            }
        }
    }
}