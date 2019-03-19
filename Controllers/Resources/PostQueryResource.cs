namespace AJ_Blog.Controllers.Resources
{
    public class PostQueryResource
    {
        public int? PostId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}