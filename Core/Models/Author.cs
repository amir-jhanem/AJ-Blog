using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AJ_Blog.Core.Models
{
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public bool IsRegistered { get; set; }
        public ICollection<Post> Posts { get; set; }
        public Author()
        {
            Posts = new Collection<Post>();
        }


    }
}