namespace Constructors;

public class Person
{
    private int Age { get; set; }
    public const double pi = 3.14;

    public Person()
    {
        Console.WriteLine("Constructor ise dusdu");
    }
    
    //Consturtors 
    //1.Return type olmayan methodlar
    //2.Classin adi ile eyni olmalidirlar
    //3.Constructorlarimiz obyekt yaratdigimiz anda ise dusurler
    //4.Constructorlar her obyekt ucun 1 defe ise dusurler
}