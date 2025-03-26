using pooBalta.ContentContext;

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
        }
    }
}

