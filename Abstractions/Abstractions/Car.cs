namespace Abstractions;

//interface - i implement edirik
public class Car : ICar
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }

    public void FullGas()
    {
        Console.WriteLine("Car is full gas");
    }
}