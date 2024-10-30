using LessonForControllers.Context;
using LessonForControllers.Models;
using Microsoft.EntityFrameworkCore;

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
    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}