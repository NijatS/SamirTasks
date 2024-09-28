namespace Polymorpishm;

public class Teacher : Person
{
    public double Salary { get; set; }
    
    //override - uzerine yazmaq
    public override void Gezmek()
    {
        Console.WriteLine("Teacher-in gezmek");
    }
}