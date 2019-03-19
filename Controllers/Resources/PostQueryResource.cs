namespace AJ_Blog.Controllers.Resources
{
    public class PostQueryResource
    {
        public int? PostId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }

        public PostQueryResource()
        {
            // set default value
            Page = 0; // return all posts
            PageSize = 0;
            IsSortAscending = false; // set true for desc
            SortBy = "date"; // sort by "date" or "Author"
        }
    }
}