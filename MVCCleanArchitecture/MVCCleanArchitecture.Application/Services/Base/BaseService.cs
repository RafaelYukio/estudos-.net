using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Application.Services.Base
{
    public class BaseService<T>(IBaseRepository<T> baseRepository) : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository = baseRepository;

        public virtual async Task<IEnumerable<T>> GetAllAsync() =>
            await _baseRepository.GetAllAsync();

        public virtual async Task<T> InsertAsync(T entity) =>
            await _baseRepository.InsertAsync(entity);
    }
}
