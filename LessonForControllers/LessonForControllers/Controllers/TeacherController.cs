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
    public async Task<IActionResult> Add(TeacherDto dto)
    {
        // Teacher teacher = new Teacher();
        // teacher.Name = dto.Name;
        // teacher.Surname = dto.Surname;
        // teacher.Salary = dto.Salary;
        var teacher = _mapper.Map<Teacher>(dto);
        
        // _context.Teachers.Add(teacher);
        // _context.SaveChanges();
        await _repository.AddAsync(teacher);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // var teachers = _context.Teachers.ToList();
        var teachers = await _repository.GetAllAsync();

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
    public async Task<IActionResult> Get(int id)
    {
        // var teacher = _context.Teachers.Find(id);
        var teacher = await _repository.GetAsync(id);
        
        // var dto = new TeacherGetDto();
        // dto.Name = teacher.Name;
        // dto.Surname = teacher.Surname;
        // dto.Salary = teacher.Salary;
        // dto.Id = teacher.Id;
        var dto =  _mapper.Map<TeacherGetDto>(teacher);
        
        return Ok(dto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult>Update(int id, TeacherDto dto)
    {
        // var updatedTeacher = _context.Teachers.Find(id);
        var updatedTeacher = await _repository.GetAsync(id);
        
        if(updatedTeacher == null)
            return NotFound();
        
        // updatedTeacher.Name = dto.Name;
        // updatedTeacher.Surname = dto.Surname;
        // updatedTeacher.Salary = dto.Salary;
        _mapper.Map(dto, updatedTeacher);
        
        // _context.Teachers.Update(updatedTeacher);
        // _context.SaveChanges();
        
        await _repository.UpdateAsync(updatedTeacher);
        
        return Ok(updatedTeacher);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        // var teacher = _context.Teachers.Find(id);
        var teacher = await _repository.GetAsync(id);

        // _context.Teachers.Remove(teacher);
        // _context.SaveChanges();
        await _repository.DeleteAsync(teacher);
        return Ok();
    }
    
}