namespace SimpleChatServer.Repositories
{
    public interface IRepositories<T>
    {
        Task<List<T>> GetByIdAsync(int id);
        Task<bool> CreateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}