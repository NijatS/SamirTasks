namespace OOPPrinciples1;

class Program
{
    static void Main(string[] args)
    { 
        //OOP-in 4 prisipi:
        
       //Encapsulation - verilen sert daxilinde get ve set olmasi
       //Inheritance - miras vermek
       //Polymorphism - formadan formaya kecmek
       //Abstraction - mucerredlik
       
       
       Employee employee = new Employee(/*"Nijat","Soltanov",100,29*/);
       
       Console.WriteLine(employee);
       // Console.WriteLine(employee._surname);
       // Console.WriteLine(employee.age);
       // Console.WriteLine(employee.salary);

    }
}