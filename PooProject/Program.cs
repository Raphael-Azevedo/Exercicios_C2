﻿using System.Linq;
using POO.SubscriptionContext;

namespace POO.ContentContext
{
    class Program
    {
        static void Main(string[] args)
        {

           var articles = new List<Article>();
           articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
           articles.Add(new Article("Artigo sobre c#", "orientacao-csharp"));
           articles.Add(new Article("Artigo sobre dotnet", "orientacao-dotnet"));

        //    foreach(var article in articles)
        //    {
        //        System.Console.WriteLine(article.Id);
        //        System.Console.WriteLine(article.Title);
        //        System.Console.WriteLine(article.Url);
        //    }

           var courses = new List<Course>();
           var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
           var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
           var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2,"Aprenda OOP", " ", null);
            var careerItem = new CareerItem(1,"Comece por aqui", " ", courseCsharp);
            var careerItem3 = new CareerItem(3,"Aprenda .NET", " ", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                System.Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(X => X.Order))
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}" );
                    System.Console.WriteLine(item.Course?.Title);
                    System.Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                    System.Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }

        }
    }
}