using System.Threading.Tasks;
using AJ_Blog.Core;
using AJ_Blog.Persistence;

namespace AJ_Blog.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly BlogDbContext context;

    public UnitOfWork(BlogDbContext context)
    {
      this.context = context;
    }

    public async Task CompleteAsync()
    {
      await context.SaveChangesAsync();
    }
  }
}