using System;

namespace MainProject.Models
{
    public class New
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

        public New()
        {
            PublishDate = DateTime.Now;
        }
    }
}