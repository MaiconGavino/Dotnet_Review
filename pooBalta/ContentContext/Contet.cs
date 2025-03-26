using System.Data.Common;

namespace pooBalta.ContentContext
{
    public abstract class Contet
    {
        public Contet(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
