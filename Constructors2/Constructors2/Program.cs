namespace Constructors2;

class Program
{
    static void Main(string[] args)
    {
        //obyekt yaratmaq
        //instance almaq
      Person person = new Person("Samir","Hasanli",36,"samir@gmail.com");
      Person person2 = new Person();    
      // Person person3 = new Person();
      // person.Name = "Samir";
      // person.Surname = "Hasanli";
      // person.Age = 36;
      // person.Email = "samir@gmail.com";
      Console.WriteLine(person.Name);
      Console.WriteLine(person.Age);
      Console.WriteLine(person.Surname);
      Console.WriteLine(person.Email);
      //Constructor - obyekt yaranan anda ise dusen methoddur.
      
    }
}