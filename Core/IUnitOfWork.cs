using System.Threading.Tasks;

namespace AJ_Blog.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}