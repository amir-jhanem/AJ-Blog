using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AJ_Blog.Core;
using AJ_Blog.Core.Models;
using AJ_Blog.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AJ_Blog.Persistence
{
    public class PostRepository: IPostRepository
    {
        private readonly BlogDbContext context;

        public PostRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public async Task<Post> GetPost(int id)
        {
            return await context.Posts.Include(p=>p.Author).SingleOrDefaultAsync(p=>p.Id == id);
        }

        public void Add(Post Post) 
        {
            context.Posts.Add(Post);
        }

        public void Remove(Post Post)
        {
            context.Remove(Post);
        }

        public async Task<QueryResult<Post>> GetPosts(PostQuery queryObj)
        {
            var result = new QueryResult<Post>();

            var query = context.Posts
                .Include(p => p.Author)
                .AsQueryable();
            var columnsMap = new Dictionary<string, Expression<Func<Post, object>>>()
                {
                    ["date"] = v => v.CreationDate,
                    ["author"] = v => v.Author.Name
                };
            query = query.ApplyOrdering(queryObj, columnsMap);

            result.TotalItems = await query.CountAsync();

            query = query.ApplyPaging(queryObj);

            result.Items = await query.ToListAsync();

            return result; 
        }

    }
}