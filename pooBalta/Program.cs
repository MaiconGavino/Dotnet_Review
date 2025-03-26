using pooBalta.ContentContext;
using pooBalta.NotificationContext;

namespace pooBalta
{
    class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Fundamentos do DotNet", "/fmt_DotNet"));
            articles.Add(new Article("Fundamentos do C#", "/fmt_CSharp"));
            articles.Add(new Article("Fundamentos do AspNet", "/fmt_AspNet"));
            foreach (var article in articles)
            {
                Console.WriteLine("===========================");
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var courses = new List<Course>();
            
            var courseOOP = new Course("Course OOP", "/c-opp");
            var courseCSharp = new Course("Course C#", "/c-csharp");
            var courseAspNet = new Course("Course Aspnet", "/c-aspnet");
            
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);
            
            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "/career-esp-dotnet");
            var careerItem = new CareerItem(1, "Start Dev", "", courseCSharp);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var items in career.Items.OrderBy(o => o.Ordem))
                {
                    Console.WriteLine($"{items.Ordem} - {items.Title}");
                    Console.WriteLine(items.Course?.Title);
                    foreach (var notification in items.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}

