using InterfacesSeptember.Interfaces;

namespace InterfacesSeptember;


//Miras alarken : -den istifade edirdik
//Interface-de implement ederken :-den istifade edecik

//Person IPerson-dan implement edib
public class Person : IPerson //alt+enter
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public void Run()
    {
        Console.WriteLine("Person running...");
    }

    public void Eat()
    {
        Console.WriteLine("Person eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Person sleeping...");
    }
}