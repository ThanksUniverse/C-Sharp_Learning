using System;
using OOP_Balta.ContentContext;
using OOP_Balta.ContentContext.Enums;
using OOP_Balta.SubscriptionContext;

namespace OOP
{
    public class Program
    {
        static void Main()
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao a objetos"));
            articles.Add(new Article("Artigo sobre C#", "C-SHARP"));
            articles.Add(new Article("Artigo sobre .NET", "DOTNET"));

            /*foreach (var item in articles)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
                Console.WriteLine("------------------------");
            }*/

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop", EContentLevel.Beginner);
            var courseCSharp = new Course("CSharp", "fundamentos-csharp", EContentLevel.Beginner);
            var courseNET = new Course("NET", "fundamentos-net", EContentLevel.Beginner);
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseNET);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "C#", "", null);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseNET);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Id} - {item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }

    }
}