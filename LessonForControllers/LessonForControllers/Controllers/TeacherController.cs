using AutoMapper;
using LessonForControllers.Context;
using LessonForControllers.Dtos;
using LessonForControllers.Models;
using LessonForControllers.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LessonForControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IGenericRepository<Teacher> _repository;

    public TeacherController(IMapper mapper, IGenericRepository<Teacher> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    [HttpPost]//elave edecek
    public IActionResult Add(TeacherDto dto)
    {
        // Teacher teacher = new Teacher();
        // teacher.Name = dto.Name;
        // teacher.Surname = dto.Surname;
        // teacher.Salary = dto.Salary;
        var teacher = _mapper.Map<Teacher>(dto);
        
        // _context.Teachers.Add(teacher);
        // _context.SaveChanges();
        _repository.Add(teacher);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        // var teachers = _context.Teachers.ToList();
        var teachers =  _repository.GetAll();

        // List<TeacherGetDto> result = new List<TeacherGetDto>();
        // foreach (var teacher in teachers)
        // {
        //     var dto = new TeacherGetDto();
        //     dto.Name = teacher.Name;
        //     dto.Surname = teacher.Surname;
        //     dto.Salary = teacher.Salary;
        //     dto.Id = teacher.Id;
        //     result.Add(dto);
        // }
        var result = _mapper.Map<List<TeacherGetDto>>(teachers);
        
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // var teacher = _context.Teachers.Find(id);
        var teacher = _repository.Get(id);
        
        // var dto = new TeacherGetDto();
        // dto.Name = teacher.Name;
        // dto.Surname = teacher.Surname;
        // dto.Salary = teacher.Salary;
        // dto.Id = teacher.Id;
        var dto =  _mapper.Map<TeacherGetDto>(teacher);
        
        return Ok(dto);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, TeacherDto dto)
    {
        // var updatedTeacher = _context.Teachers.Find(id);
        var updatedTeacher = _repository.Get(id);
        
        if(updatedTeacher == null)
            return NotFound();
        
        // updatedTeacher.Name = dto.Name;
        // updatedTeacher.Surname = dto.Surname;
        // updatedTeacher.Salary = dto.Salary;
        _mapper.Map(dto, updatedTeacher);
        
        // _context.Teachers.Update(updatedTeacher);
        // _context.SaveChanges();
        
        _repository.Update(updatedTeacher);
        
        return Ok(updatedTeacher);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // var teacher = _context.Teachers.Find(id);
        var teacher = _repository.Get(id);

        // _context.Teachers.Remove(teacher);
        // _context.SaveChanges();
        _repository.Delete(teacher);
        return Ok();
    }
    
}