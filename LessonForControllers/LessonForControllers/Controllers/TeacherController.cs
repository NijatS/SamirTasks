
using LessonForControllers.Context;
using LessonForControllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonForControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly LessonDbContext _context;

    public TeacherController(LessonDbContext context)
    {
        _context = context;
    }

    [HttpPost]//elave edecek
    public IActionResult Add(Teacher teacher)
    {
        _context.Teachers.Add(teacher);
        _context.SaveChanges();
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var teachers = _context.Teachers.ToList();
        return Ok(teachers);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var teacher = _context.Teachers.Find(id);
        return Ok(teacher);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var teacher = _context.Teachers.Find(id);
        _context.Teachers.Remove(teacher);
        _context.SaveChanges();
        return Ok();
    }
    
}