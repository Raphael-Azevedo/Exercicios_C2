using POO.ContentContext.Enums;

namespace POO.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> modules { get; set; }
        public int DurationInMinutes { get; set; }   
        public EContentLevel Level { get; set; }
    }   

   
}