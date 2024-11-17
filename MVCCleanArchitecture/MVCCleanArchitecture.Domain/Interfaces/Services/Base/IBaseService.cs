namespace MVCCleanArchitecture.Domain.Interfaces.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> InsertAsync(T entity);
    }
}
