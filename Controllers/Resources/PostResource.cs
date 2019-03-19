using System;
using AJ_Blog.Core.Models;

namespace AJ_Blog.Controllers.Resources
{
    public class PostResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public int AuthorId { get; set; }
        public KeyValuePairResource Author { get; set; }
    }
}