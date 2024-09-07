namespace Constructors2;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    //Constructorlar bir methoddur hansiki return type yoxdur.
    //Constructorlar Classlarimiz ile eyni adda olurlar.
    //Obyekt yaratdigimiz anda ise dusurler
    //Default olaraq sistem bize bos constructor verir, hansiki biz onu
    //gormuruk

    // public Person(string name,string surname,int age,string email)
    // {
    //     Name = name;
    //     Surname = surname;
    //     Age = age;
    //     Email = email;
    // } //-dolu constructor

    
    public Person(string Name,string Surname,int Age,string Email)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Email = Email;
    } //-dolu constructor
    public Person()
    {
        
    }
}