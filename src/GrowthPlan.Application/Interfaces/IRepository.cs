using Ardalis.Result;
using Ardalis.Specification;

namespace GrowthPlan.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<Result<IReadOnlyCollection<T>>> GetAllAsync();
        Task<Result<IReadOnlyCollection<T>>> GetSpecifiedAsync(ISpecification<T> specification);
        Task<Result<T>> GetByIdAsync(int id);
        Task<Result<T>> AddAsync(T entity);
        Task<Result<T>> UpdateAsync(T entity);
        Task<Result<T>> DeleteAsync(int id);
    }
}
