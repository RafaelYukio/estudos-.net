namespace MVCCleanArchitecture.Domain.Interfaces.Respositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<List<T>> GetAllAsync();
    }
}
