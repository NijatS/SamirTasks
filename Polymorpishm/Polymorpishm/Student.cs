namespace Polymorpishm;

public class Student : Person
{
    public double GPA { get; set; } //ortalama bali
    public override void Gezmek()
    {
        Console.WriteLine("Student-in gezmek");
    }
}