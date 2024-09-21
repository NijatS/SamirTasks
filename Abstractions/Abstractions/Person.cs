namespace Abstractions;


//1.Instance almaq olmur
public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    
    //Static methodlar obyekt seviyesinde yox,class seviyessinde cagirilir
    public static void EatStatic()
    {
        Console.WriteLine("Eating...");
    }
    
    // public virtual void Sleep()
    // {
    //     Console.WriteLine("Person is sleeping");
    // }

    public virtual void CalculateSalary(int hour)
    {
        Console.WriteLine(hour*8);
    }

    public abstract void Walk();


    public int Calculate(int num1,int num2)
    {
        //2 ededin cemini qaytarir
       return num1 + num2;
    }

    // public void Calculate(int num1, int num2)
    // {
    //     //void-bize hecne qaytarmir
    //     Console.WriteLine(num1 + num2);
    // }
    public string Sleep()
    {
        return "Person is sleeping";
    }

    public void WakeUp()
    {
        Console.WriteLine("Person is waking up");
    }

    public void GoTo()
    {
        Console.WriteLine("Person is going to");
    }
    
    
}