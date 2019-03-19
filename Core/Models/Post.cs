using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AJ_Blog.Core.Models
{
    [Table("Posts")]
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}