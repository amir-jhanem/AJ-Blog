using System;
using System.ComponentModel.DataAnnotations;
using AJ_Blog.Core.Models;

namespace AJ_Blog.Controllers.Resources
{
    public class SavePostResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}