using LessonForControllers.Models;

namespace LessonForControllers.Repository;

public interface IGenericRepository<T> where T : BaseModel
{
    public Task AddAsync(T entity);
    public Task<List<T>> GetAllAsync();
    public Task<T> GetAsync(int id);
    public Task UpdateAsync(T entity);
    public Task DeleteAsync(T entity);
}