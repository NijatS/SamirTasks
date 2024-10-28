namespace LessonForControllers.Models;

public class Teacher : BaseModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
}