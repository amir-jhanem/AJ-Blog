using System.Threading.Tasks;
using AJ_Blog.Core.Models;

namespace AJ_Blog.Core
{
    public interface IPostRepository
    {
         Task<Post> GetPost(int id); 
        void Add(Post Post);
        void Remove(Post Post);
        Task<QueryResult<Post>> GetPosts(PostQuery filter);

    }
}