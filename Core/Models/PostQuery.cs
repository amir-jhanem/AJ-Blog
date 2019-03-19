using AJ_Blog.Extensions;

namespace AJ_Blog.Core.Models
{
    public class PostQuery: IQueryObject
    {
        public int? PostId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}