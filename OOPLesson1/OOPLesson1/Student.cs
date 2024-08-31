namespace OOPLesson1;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Telephone { get; set; }
    public string Email { get; set; }
    //Composition
    public int StudentAddressId { get; set; }
    public StudentAddress StudentAddress { get; set; }
}