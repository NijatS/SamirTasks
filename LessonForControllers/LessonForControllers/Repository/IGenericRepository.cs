using LessonForControllers.Models;

namespace LessonForControllers.Repository;

public interface IGenericRepository<T> where T : BaseModel
{
    void Add(T entity);
    List<T> GetAll();
    T Get(int id);
    void Update(T entity);
    void Delete(T entity);
}