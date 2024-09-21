namespace Abstractions;

class Program
{
    static void Main(string[] args)
    {
        //C# da abstraction 2 usulla yaranir:
        //1.Abstract class-ile
        //2.Interface ile
        
        //abstract class-dan obyekt yaratmaq olmur
        // Person person = new Person();
        
        // Teacher teacher = new Teacher();
        
        // Teacher teacher = new Teacher();
        
        // teacher.CalculateSalary(200);

        // Person person = new Person();
        // person.Eat();
        // Person.EatStatic();
        
        //Abstract class-larda 2 nov method xususi vurgulanir
        //1.abstract method
        //--Yalniz ve yalniz abstract class-in daxilinde islenir
        //--Body-si olmur
        //--Hokmendi miras aldigi class-larda body-si yazilsin
        
        
        
        //2.virtual method
        //--Istenilen class-in daxilinde yazila biler
        //--Body-si olur
        //--Miras aldigim class-larda isteneniz ezede bilersiz,
        //ezmiyede bilersiniz.Eger ezmesek gedir base classdaki methodu ise salir
        
        
        
        
        // Person person = new Person();
        //
        // string message = person.Sleep();
        // Console.WriteLine(message);
        //
        // person.Calculate(2,4);
        
        ICar car = new Car(); //polymorphism
        
        Person teacher = new Teacher();
        car.Drive();

    }
}