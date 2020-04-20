using System;

namespace Portfolio.Models
{
    public class BlogPostViewModel
    {
        public BlogPostViewModel(string title, string url, DateTime published)
        {
            Title = title;
            Url = url;
            Published = published;
        }

        public string Title { get; set; }

        public string Url { get; set; }

        public DateTime Published { get; set; }
    }
}
