using System.Data.Common;

namespace pooBalta.ContentContext
{
    public abstract class Contet : Base
    {
        public Contet(string title, string url)
        {
            Title = title;
            Url = url;
        }
        
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
