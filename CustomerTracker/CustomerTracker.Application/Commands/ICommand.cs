using System.Threading.Tasks;

namespace CustomerTracker.Application.Commands
{
    public interface ICommand<T, K>
    {
        Task<K> ExecuteAsync(T model);
    }
}
