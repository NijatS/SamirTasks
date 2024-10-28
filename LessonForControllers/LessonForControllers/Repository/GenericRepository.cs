using LessonForControllers.Context;
using LessonForControllers.Models;

namespace LessonForControllers.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    private readonly LessonDbContext _context;

    public GenericRepository(LessonDbContext context)
    {
        _context = context;
    }

    //_context.Teachers = Set<T>()
    //Teacher ve ya Student = T
    //List<Teacher> ve ya List<Student> = List<T>
    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T Get(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }
}