namespace OOPPrinciples1;

public class Employee
{
    private string _name;
    private string _surname;
    private double _salary;
    private int _age;
    
    //Property ile encapsulation
    public string Name { get => _name; set => _name = value; }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Ad bos ola bilmez");
            return;
        }

        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    //Menimsetme islemi
    public void SetSurname(string surname)
    {
        if (string.IsNullOrEmpty(surname))
        {
            Console.WriteLine("SoyAd bos ola bilmez");
            return;
        }

        _surname = surname;
    }

    public string GetSurname()
    {
        return _surname;
    }

    //Encapsulation constructor ile
    // public  Employee(string name, string surname, double salary, int age)
    // {
    //     if (age < 0)
    //     {
    //         Console.WriteLine("yas menfi ola bilmez");
    //         return;
    //     }
    //
    //     if (salary < 0)
    //     {
    //         Console.WriteLine("maas menfi ola bilmez");
    //         return;
    //     }
    //
    //     if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
    //     {
    //         Console.WriteLine("ad ve ya soyad duzgun daxil edilmeyib");
    //     }
    //     
    //     
    //     this.name = name;
    //     this.surname = surname;
    //     this.salary = salary;
    //     this.age = age;
    // }

    //Encapsulation Getter ve Setter methodlari ile
}