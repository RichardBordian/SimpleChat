namespace SimpleChatServer.Services
{
    public interface IServices<T>
    {
        Task CreateAsync(T entity);
        Task<T?> FindAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}
