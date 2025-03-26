using pooBalta.NotificationContext;
using pooBalta.SharedContext;

namespace pooBalta.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            AddNotificantion(new Notification("Course", "Course Invalid"));
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }
        
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}