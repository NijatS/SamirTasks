namespace Abstractions;

public class Teacher : Person
{
    public double Salary { get; set; }
    //override - ezmek

    public override void CalculateSalary(int hour)
    {
        Console.WriteLine(1.2*hour*8);
    }


    // public override void Sleep()
    // {
    //     Console.WriteLine("Teacher is sleeping");
    // }

    public override void Walk() //method signature 
    {
       Console.WriteLine("Teacher is walking"); //method body
    }
    
}