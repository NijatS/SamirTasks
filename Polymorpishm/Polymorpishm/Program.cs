namespace Polymorpishm;

class Program
{
    static void Main(string[] args)
    {
        // Person person = new Person();
        
        Person student = new Student(); //hem person kimi,hemde student kimi cixis ede bilir
        student.Name = "Eli";
        
        Person teacher = new Teacher();
        teacher.Name = "Veli";
        
        teacher.Gezmek();
        student.Gezmek();
        
        // SayHelloToStudent(student);
        // SayHelloToTeacher(teacher);
        
        // SayHello(teacher);
        // SayHello(student);
    }

    static void SayHello(Person person)
    {
        Console.WriteLine("Hello " + person.Name);
    }

    static void SayHelloToTeacher(Teacher teacher)
    {
        Console.WriteLine("Hello " + teacher.Name);
    }
    static void SayHelloToStudent(Student student)
    {
        Console.WriteLine("Hello " +student.Name);
    }
}